# SketchBlockDefinitionsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedPartComponents.Item[…].SketchBlockDefinitions`

```csharp
interface SketchBlockDefinitionsEnumerator
{
    // Properties
    int Count { get; }
    SketchBlockDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedPartComponent](../objects/DerivedPartComponent.md).SketchBlockDefinitions, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).SketchBlockDefinitions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchBlockDefinition](../objects/SketchBlockDefinition.md)

