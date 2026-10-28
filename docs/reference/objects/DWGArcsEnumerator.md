# DWGArcsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Arcs`

```csharp
interface DWGArcsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGArc Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).Arcs, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).Arcs

**Referenced types:** [DWGArc](../objects/DWGArc.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

