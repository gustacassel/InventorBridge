# DWGLinesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Lines`

```csharp
interface DWGLinesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGLine Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).Lines, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).Lines

**Referenced types:** [DWGLine](../objects/DWGLine.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

