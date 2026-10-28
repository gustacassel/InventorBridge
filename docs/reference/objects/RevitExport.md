# RevitExport

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.RevitExports.Item[…]`

```csharp
interface RevitExport
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    RevitExportDefinition Definition { get; set; }
    string FullFileName { get; }
    string Name { get; }
    AssemblyComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void Update();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RevitExportDefinition](../objects/RevitExportDefinition.md).Parent, [RevitExports](../objects/RevitExports.md).Add, [RevitExports](../objects/RevitExports.md).Item

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevitExportDefinition](../objects/RevitExportDefinition.md)

