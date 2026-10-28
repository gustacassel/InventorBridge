# RevitExports

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.RevitExports`

```csharp
interface RevitExports
{
    // Properties
    object Application { get; }
    int Count { get; }
    RevitExport Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RevitExport Add(RevitExportDefinition Definition);
    RevitExportDefinition CreateDefinition();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).RevitExports, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).RevitExports

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevitExport](../objects/RevitExport.md), [RevitExportDefinition](../objects/RevitExportDefinition.md)

