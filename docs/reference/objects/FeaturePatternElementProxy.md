# FeaturePatternElementProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface FeaturePatternElementProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Faces Faces { get; }
    int Index { get; }
    FeaturePatternElement NativeObject { get; }
    PartFeature Parent { get; }
    ObjectsEnumerator ResultFeatures { get; }
    bool Suppressed { get; set; }
    Matrix Transform { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [Faces](../objects/Faces.md), [FeaturePatternElement](../objects/FeaturePatternElement.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [PartFeature](../objects/PartFeature.md)

