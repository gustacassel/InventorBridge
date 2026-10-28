# ComponentDefinitionsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingBOMs.Item[…].DrawingBOMRows.Item[…].BOMRow.ComponentDefinitions`

```csharp
interface ComponentDefinitionsEnumerator
{
    // Properties
    int Count { get; }
    ComponentDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BOMRow](../objects/BOMRow.md).ComponentDefinitions

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

