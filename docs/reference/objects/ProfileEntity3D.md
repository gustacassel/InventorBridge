# ProfileEntity3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].Profiles3D.Item[…].Item[…].Item[…]`

```csharp
interface ProfileEntity3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    object Curve { get; }
    CurveTypeEnum CurveType { get; }
    SketchPoint3D EndSketchPoint { get; }
    bool OpposedToSketchEntity { get; }
    ProfilePath3D Parent { get; }
    SketchEntity3D SketchEntity { get; }
    SketchPoint3D StartSketchPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [ProfileEntity3DProxy](../objects/ProfileEntity3DProxy.md).NativeObject, [ProfilePath3D](../objects/ProfilePath3D.md).Item, [ProfilePath3DProxy](../objects/ProfilePath3DProxy.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProfilePath3D](../objects/ProfilePath3D.md), [SketchEntity3D](../objects/SketchEntity3D.md), [SketchPoint3D](../objects/SketchPoint3D.md)

