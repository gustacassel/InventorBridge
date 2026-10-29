using InventorBridge.ReferenceGenerator.Analysis;
using InventorBridge.ReferenceGenerator.Model;
using InventorBridge.ReferenceGenerator.Output;
using InventorBridge.ReferenceGenerator.Reading;

namespace InventorBridge.ReferenceGenerator
{
    /// <summary>
    /// Generates the Inventor API reference (docs/reference) from the interop DLLs in lib/inventor/{year}/.
    /// Usage: dotnet run --project src/InventorBridge.ReferenceGenerator [-- --lib lib/inventor --out docs/reference --stdole {path}]
    /// </summary>
    internal static class Program
    {
        private const string InteropFileName = "Autodesk.Inventor.Interop.dll";
        private const string InheritanceFileName = "inheritance.txt";

        private static int Main(string[] args)
        {
            var options = Options.Parse(args);

            var versions = ReadAllVersions(options);
            if (versions.Count == 0)
            {
                Console.Error.WriteLine($"no interop found at {options.LibDirectory}/<year>/{InteropFileName}");
                return 1;
            }

            var declaredBases = InheritanceFile.Load(Path.Combine(AppContext.BaseDirectory, InheritanceFileName));

            var api = ApiMerger.Merge(versions);
            InheritanceResolver.Resolve(api, declaredBases);
            ReferenceIndexer.Index(api);
            AccessPathFinder.Find(api);

            new ReferenceWriter(api).WriteAll(options.OutputDirectory);

            PrintSummary(api, options.OutputDirectory);
            return 0;
        }

        private static List<ApiVersion> ReadAllVersions(Options options)
        {
            var versions = new List<ApiVersion>();

            foreach (var versionDirectory in Directory.GetDirectories(options.LibDirectory).Order())
            {
                var interopPath = Path.Combine(versionDirectory, InteropFileName);
                if (!File.Exists(interopPath))
                {
                    continue;
                }

                var version = InteropReader.Read(Path.GetFileName(versionDirectory), interopPath, options.StdolePath);
                var objectCount = version.Types.Values.Count(type => type.Kind == ApiTypeKind.Object);
                var enumCount = version.Types.Count - objectCount;
                Console.WriteLine($"{version.Version}: assembly {version.AssemblyVersion}, {objectCount} objects, {enumCount} enums");

                versions.Add(version);
            }

            return versions;
        }

        private static void PrintSummary(MergedApi api, string outputDirectory)
        {
            var objects = api.VisibleObjectsByName.Values.ToList();
            var withPath = objects.Count(type => type.AccessPath is not null);
            var withAncestors = objects.Count(type => type.Ancestors.Count > 0);

            Console.WriteLine($"generated in {outputDirectory}");
            Console.WriteLine($"  visible objects: {objects.Count}, with an access path from Application: {withPath}, with ancestors: {withAncestors}");
        }
    }
}
