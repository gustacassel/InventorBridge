using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using InventorBridge.ReferenceGenerator.Model;

namespace InventorBridge.ReferenceGenerator.Reading
{
    /// <summary>
    /// Reads an Autodesk.Inventor.Interop.dll as metadata only: it does not run any code from the DLL and
    /// does not need Inventor installed.
    /// </summary>
    public sealed class InteropReader
    {
        private const string InventorNamespace = "Inventor";

        // Flags stored in the TypeLibType and TypeLibFunc attributes (COM TYPEFLAGS and FUNCFLAGS).
        private const int TypeFlagHidden = 0x10;
        private const int FuncFlagRestricted = 0x1;
        private const int FuncFlagHidden = 0x40;

        private readonly Type[] exportedTypes;

        // Interfaces that only exist behind a coclass. E.g. ApplicationEventsObject behind ApplicationEvents.
        private readonly HashSet<string> coClassInterfaceNames;

        // "_Xxx" interfaces that are just an alias of "Xxx" (e.g. _Document). References to them become "Xxx".
        private readonly HashSet<string> aliasNames;

        private InteropReader(Type[] exportedTypes)
        {
            this.exportedTypes = exportedTypes;

            coClassInterfaceNames = exportedTypes
                .Where(type => type.IsInterface && FindAttribute(type, "CoClassAttribute") is not null)
                .Select(type => type.Name)
                .ToHashSet();

            var interfaceNames = exportedTypes
                .Where(type => type.IsInterface)
                .Select(type => type.Name)
                .ToHashSet();

            aliasNames = coClassInterfaceNames
                .Where(name => name.StartsWith('_') && interfaceNames.Contains(name[1..]))
                .ToHashSet();
        }

        public static ApiVersion Read(string version, string interopPath, string? stdolePath)
        {
            using var loadContext = CreateLoadContext(interopPath, stdolePath);
            var assembly = loadContext.LoadFromAssemblyPath(interopPath);
            var reader = new InteropReader(assembly.GetExportedTypes());

            return new ApiVersion
            {
                Version = version,
                AssemblyVersion = assembly.GetName().Version?.ToString() ?? "?",
                Types = reader.ReadTypes(),
            };
        }

        /// <summary>
        /// Metadata context with the DLLs of the current .NET runtime, the interop and stdole.
        /// The interop references mscorlib, which the runtime resolves through its compatibility facade.
        /// </summary>
        private static MetadataLoadContext CreateLoadContext(string interopPath, string? stdolePath)
        {
            var assemblyPaths = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll").ToList();
            assemblyPaths.Add(interopPath);
            if (stdolePath is not null)
            {
                assemblyPaths.Add(stdolePath);
            }

            return new MetadataLoadContext(new PathAssemblyResolver(assemblyPaths));
        }

        private Dictionary<string, ApiType> ReadTypes()
        {
            var types = new Dictionary<string, ApiType>();

            foreach (var type in exportedTypes)
            {
                if (type.IsEnum)
                {
                    types[type.Name] = ReadEnum(type);
                }
                else if (IsDocumentedInterface(type))
                {
                    types[type.Name] = ReadInterface(type);
                }
            }

            return types;
        }

        /// <summary>
        /// COM interfaces that get a page. Left out: event interfaces (Sink, _Event), "XxxObject" interfaces
        /// that only exist behind a coclass, and "_Xxx" aliases.
        /// </summary>
        private bool IsDocumentedInterface(Type type)
        {
            if (!type.IsInterface || FindAttribute(type, "ComImportAttribute") is null)
            {
                return false;
            }

            if (type.Name.EndsWith("Sink") || type.Name.EndsWith("_Event"))
            {
                return false;
            }

            if (type.Name.EndsWith("Object") && coClassInterfaceNames.Contains(type.Name[..^"Object".Length]))
            {
                return false;
            }

            return !aliasNames.Contains(type.Name);
        }

        private static ApiType ReadEnum(Type type)
        {
            var values = type.GetFields(BindingFlags.Public | BindingFlags.Static)
                .Select(field => new ApiEnumValue
                {
                    Name = field.Name,
                    Value = Convert.ToInt64(field.GetRawConstantValue()),
                })
                .ToList();

            return new ApiType
            {
                Name = type.Name,
                Kind = ApiTypeKind.Enum,
                IsHidden = IsTypeHidden(type),
                EnumValues = values,
            };
        }

        private ApiType ReadInterface(Type type)
        {
            // COM flattens inheritance, but events come from base interfaces (XxxSink_Event).
            // So this reads the type itself plus its base interfaces from the Inventor namespace.
            var sources = new[] { type }.Concat(type.GetInterfaces().Where(baseType => baseType.Namespace == InventorNamespace));
            var members = new Dictionary<string, ApiMember>();

            foreach (var source in sources)
            {
                var isSink = source.Name.EndsWith("Sink");
                var isEventSource = source.Name.EndsWith("_Event");

                if (!isSink && !isEventSource)
                {
                    foreach (var property in source.GetProperties())
                    {
                        AddIfNew(members, ReadProperty(property));
                    }

                    foreach (var method in source.GetMethods().Where(method => !method.IsSpecialName))
                    {
                        AddIfNew(members, ReadMethod(method));
                    }
                }

                if (isEventSource || (!isSink && source == type))
                {
                    foreach (var eventInfo in source.GetEvents())
                    {
                        AddIfNew(members, ReadEvent(eventInfo));
                    }
                }
            }

            // In ComImport interfaces, the method order in the metadata is the vtable order.
            var vtable = type.GetMethods()
                .OrderBy(method => method.MetadataToken)
                .Select(method => method.Name)
                .ToList();

            return new ApiType
            {
                Name = type.Name,
                Kind = ApiTypeKind.Object,
                IsHidden = IsTypeHidden(type),
                Members = members.Values.ToList(),
                VTable = vtable,
            };
        }

        private static void AddIfNew(Dictionary<string, ApiMember> members, ApiMember member)
        {
            members.TryAdd(member.Key, member);
        }

        private ApiMember ReadProperty(PropertyInfo property)
        {
            var accessor = property.GetMethod ?? property.SetMethod;
            var isHidden = IsFunctionHidden(property) || (accessor is not null && IsFunctionHidden(accessor));

            return new ApiMember
            {
                Name = property.Name,
                Kind = ApiMemberKind.Property,
                ReturnType = GetTypeName(property.PropertyType),
                CanRead = property.CanRead,
                CanWrite = property.CanWrite,
                IsHidden = isHidden,
                Parameters = property.GetIndexParameters().Select(ReadParameter).ToList(),
            };
        }

        private ApiMember ReadMethod(MethodInfo method)
        {
            return new ApiMember
            {
                Name = method.Name,
                Kind = ApiMemberKind.Method,
                ReturnType = GetTypeName(method.ReturnType),
                IsHidden = IsFunctionHidden(method),
                Parameters = method.GetParameters().Select(ReadParameter).ToList(),
            };
        }

        private ApiMember ReadEvent(EventInfo eventInfo)
        {
            // The event signature is the delegate's Invoke signature.
            var invoke = eventInfo.EventHandlerType?.GetMethod("Invoke");
            var parameters = invoke?.GetParameters().Select(ReadParameter).ToList() ?? [];

            return new ApiMember
            {
                Name = eventInfo.Name,
                Kind = ApiMemberKind.Event,
                ReturnType = "void",
                Parameters = parameters,
            };
        }

        private ApiParameter ReadParameter(ParameterInfo parameter)
        {
            var direction = ParameterDirection.In;
            if (parameter.ParameterType.IsByRef)
            {
                direction = parameter.IsOut ? ParameterDirection.Out : ParameterDirection.Ref;
            }

            return new ApiParameter
            {
                Name = parameter.Name ?? "arg",
                Type = GetTypeName(parameter.ParameterType),
                Direction = direction,
                IsOptional = parameter.IsOptional,
                DefaultValue = FormatDefaultValue(parameter),
            };
        }

        /// <summary>
        /// Default value of an optional parameter, as text. Enum values are shown by name
        /// (e.g. PartFeatureExtentDirectionEnum.kPositiveExtentDirection). Returns null when there is no
        /// value (the optional parameter can simply be omitted).
        /// </summary>
        private static string? FormatDefaultValue(ParameterInfo parameter)
        {
            if (!parameter.IsOptional || !parameter.HasDefaultValue)
            {
                return null;
            }

            var rawValue = parameter.RawDefaultValue;
            if (IsMissing(rawValue))
            {
                return null;
            }

            var parameterType = parameter.ParameterType.IsByRef
                ? parameter.ParameterType.GetElementType()!
                : parameter.ParameterType;

            if (parameterType.IsEnum && rawValue is not null)
            {
                var enumMemberName = parameterType.GetFields(BindingFlags.Public | BindingFlags.Static)
                    .FirstOrDefault(field => Convert.ToInt64(field.GetRawConstantValue()) == Convert.ToInt64(rawValue))?
                    .Name;

                if (enumMemberName is not null)
                {
                    return $"{parameterType.Name}.{enumMemberName}";
                }
            }

            return rawValue switch
            {
                null => "null",
                string text => $"\"{text}\"",
                bool flag => flag ? "true" : "false",
                _ => Convert.ToString(rawValue, CultureInfo.InvariantCulture),
            };
        }

        private static bool IsMissing(object? value)
        {
            return value?.GetType().FullName == "System.Reflection.Missing";
        }

        /// <summary>Type name as shown in the documentation: C# aliases, arrays with [], no ref/out.</summary>
        private string GetTypeName(Type type)
        {
            if (type.IsByRef)
            {
                return GetTypeName(type.GetElementType()!);
            }

            if (type.IsArray)
            {
                return GetTypeName(type.GetElementType()!) + "[]";
            }

            switch (type.FullName)
            {
                case "System.Object": return "object";
                case "System.String": return "string";
                case "System.Int16": return "short";
                case "System.Int32": return "int";
                case "System.Int64": return "long";
                case "System.UInt32": return "uint";
                case "System.Byte": return "byte";
                case "System.Single": return "float";
                case "System.Double": return "double";
                case "System.Boolean": return "bool";
                case "System.Void": return "void";
            }

            return aliasNames.Contains(type.Name) ? type.Name[1..] : type.Name;
        }

        private static bool IsTypeHidden(Type type)
        {
            return (ReadFlags(FindAttribute(type, "TypeLibTypeAttribute")) & TypeFlagHidden) != 0;
        }

        private static bool IsFunctionHidden(MemberInfo member)
        {
            return (ReadFlags(FindAttribute(member, "TypeLibFuncAttribute")) & (FuncFlagHidden | FuncFlagRestricted)) != 0;
        }

        private static CustomAttributeData? FindAttribute(MemberInfo member, string attributeName)
        {
            return member.GetCustomAttributesData().FirstOrDefault(attribute => attribute.AttributeType.Name == attributeName);
        }

        /// <summary>Reads the attribute's first argument (the flags), which can come as a short or as an enum.</summary>
        private static int ReadFlags(CustomAttributeData? attribute)
        {
            if (attribute is null || attribute.ConstructorArguments.Count == 0)
            {
                return 0;
            }

            return Convert.ToInt32(attribute.ConstructorArguments[0].Value);
        }
    }
}
