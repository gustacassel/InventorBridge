# PathEntity

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SweepFeatures.Item[…].SolidSweepDefinition.Path.Item[…]`

```csharp
interface PathEntity
{
    // Properties
    object Application { get; }
    object Curve { get; }
    CurveTypeEnum CurveType { get; }
    bool OpposedToSketchEntity { get; }
    Path Parent { get; }
    object SketchEntity { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [Path](../objects/Path.md).Item, [PathEntityProxy](../objects/PathEntityProxy.md).NativeObject, [PathProxy](../objects/PathProxy.md).Item

**Referenced types:** [CurveTypeEnum](../enums/CurveTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Path](../objects/Path.md)

