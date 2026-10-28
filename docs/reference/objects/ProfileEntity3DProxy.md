# ProfileEntity3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ProfileEntity3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    object Curve { get; }
    CurveTypeEnum CurveType { get; }
    SketchPoint3D EndSketchPoint { get; }
    ProfileEntity3D NativeObject { get; }
    bool OpposedToSketchEntity { get; }
    ProfilePath3D Parent { get; }
    SketchEntity3D SketchEntity { get; }
    SketchPoint3D StartSketchPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProfileEntity3D](../objects/ProfileEntity3D.md), [ProfilePath3D](../objects/ProfilePath3D.md), [SketchEntity3D](../objects/SketchEntity3D.md), [SketchPoint3D](../objects/SketchPoint3D.md)

