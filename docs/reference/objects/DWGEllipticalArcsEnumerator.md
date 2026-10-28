# DWGEllipticalArcsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.EllipticalArcs`

```csharp
interface DWGEllipticalArcsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGEllipticalArc Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).EllipticalArcs, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).EllipticalArcs

**Referenced types:** [DWGEllipticalArc](../objects/DWGEllipticalArc.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

