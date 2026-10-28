# DWGSplinesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Splines`

```csharp
interface DWGSplinesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGSpline Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).Splines, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).Splines

**Referenced types:** [DWGSpline](../objects/DWGSpline.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

