# ProfileEntityProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ProfileEntityProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    object Curve { get; }
    Curve2dTypeEnum CurveType { get; }
    SketchPoint EndSketchPoint { get; }
    ProfileEntity NativeObject { get; }
    bool OpposedToSketchEntity { get; }
    ProfilePath Parent { get; }
    SketchEntity SketchEntity { get; }
    SketchPoint StartSketchPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [Curve2dTypeEnum](../enums/Curve2dTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProfileEntity](../objects/ProfileEntity.md), [ProfilePath](../objects/ProfilePath.md), [SketchEntity](../objects/SketchEntity.md), [SketchPoint](../objects/SketchPoint.md)

