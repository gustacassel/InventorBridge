# DocumentSubTypeHandler

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DocumentSubTypeHandler
{
    // Properties
    string ApplicationName { get; set; }
    EnvironmentBase DefaultEnvironment { get; }
    string DocumentSubTypeID { get; }
    ObjectTypeEnum Type { get; }
    bool UserChangeable { get; set; }
    // Events
    event OnChangeType(bool ConvertToSubType, Document Document, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [Document](../objects/Document.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

