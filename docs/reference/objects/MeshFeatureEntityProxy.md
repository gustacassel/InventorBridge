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
    GraphicsIndexSet ColorIndexSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    GraphicsColorSet ColorSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    ComponentOccurrence ContainingOccurrence { get; }
    GraphicsIndexSet CoordinateIndexSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    GraphicsCoordinateSet CoordinateSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; } // since 2026
    MeshFeatureEntity NativeObject { get; }
    NormalBindingEnum NormalBinding { get; }
    GraphicsIndexSet NormalIndexSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    GraphicsNormalSet NormalSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    MeshFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(ref byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ColorBindingEnum](../enums/ColorBindingEnum.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [GraphicsColorSet](../objects/GraphicsColorSet.md), [GraphicsCoordinateSet](../objects/GraphicsCoordinateSet.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [GraphicsIndexSet](../objects/GraphicsIndexSet.md), [GraphicsNormalSet](../objects/GraphicsNormalSet.md), [MeshFeature](../objects/MeshFeature.md), [MeshFeatureEntity](../objects/MeshFeatureEntity.md), [NormalBindingEnum](../enums/NormalBindingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

