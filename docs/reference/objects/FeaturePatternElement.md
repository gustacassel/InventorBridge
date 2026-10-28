# FeaturePatternElement

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CircularPatternFeatures.Item[…].PatternElements.Item[…]`

```csharp
interface FeaturePatternElement
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Faces Faces { get; }
    int Index { get; }
    PartFeature Parent { get; }
    ObjectsEnumerator ResultFeatures { get; }
    bool Suppressed { get; set; }
    Matrix Transform { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [FeaturePatternElementProxy](../objects/FeaturePatternElementProxy.md).NativeObject, [FeaturePatternElements](../objects/FeaturePatternElements.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Faces](../objects/Faces.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [PartFeature](../objects/PartFeature.md)

