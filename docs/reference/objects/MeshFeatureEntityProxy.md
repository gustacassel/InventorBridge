# MeshFeatureEntityProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MeshFeatureEntity](../objects/MeshFeatureEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…].Item[…].Entities.Item[…] → (MeshFeatureEntityProxy)`

```csharp
interface MeshFeatureEntityProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ColorBindingEnum ColorBinding { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; } // since 2026
    MeshFeatureEntity NativeObject { get; }
    NormalBindingEnum NormalBinding { get; }
    MeshFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

6 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ColorBindingEnum](../enums/ColorBindingEnum.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [MeshFeature](../objects/MeshFeature.md), [MeshFeatureEntity](../objects/MeshFeatureEntity.md), [NormalBindingEnum](../enums/NormalBindingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

