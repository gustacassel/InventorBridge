# MeshFeatureSets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets`

```csharp
interface MeshFeatureSets
{
    // Properties
    object Application { get; }
    int Count { get; }
    MeshFeatureSet Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MeshFeatureSet Add(string FullName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartComponentDefinition](../objects/PartComponentDefinition.md).MeshFeatureSets, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).MeshFeatureSets

**Referenced types:** [MeshFeatureSet](../objects/MeshFeatureSet.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

