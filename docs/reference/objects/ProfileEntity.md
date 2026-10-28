# ProfileEntity

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].Profiles.Item[…].Item[…].Item[…]`

```csharp
interface ProfileEntity
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    object Curve { get; }
    Curve2dTypeEnum CurveType { get; }
    SketchPoint EndSketchPoint { get; }
    bool OpposedToSketchEntity { get; }
    ProfilePath Parent { get; }
    SketchEntity SketchEntity { get; }
    SketchPoint StartSketchPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [ProfileEntityProxy](../objects/ProfileEntityProxy.md).NativeObject, [ProfilePath](../objects/ProfilePath.md).Item, [ProfilePathProxy](../objects/ProfilePathProxy.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Curve2dTypeEnum](../enums/Curve2dTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProfilePath](../objects/ProfilePath.md), [SketchEntity](../objects/SketchEntity.md), [SketchPoint](../objects/SketchPoint.md)

