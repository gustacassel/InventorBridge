# PathEntityProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PathEntityProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    object Curve { get; }
    CurveTypeEnum CurveType { get; }
    PathEntity NativeObject { get; }
    bool OpposedToSketchEntity { get; }
    Path Parent { get; }
    object SketchEntity { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Path](../objects/Path.md), [PathEntity](../objects/PathEntity.md)

