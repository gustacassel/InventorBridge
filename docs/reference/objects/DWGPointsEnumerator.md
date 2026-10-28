# DWGPointsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Points`

```csharp
interface DWGPointsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGPoint Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).Points, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).Points

**Referenced types:** [DWGPoint](../objects/DWGPoint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

