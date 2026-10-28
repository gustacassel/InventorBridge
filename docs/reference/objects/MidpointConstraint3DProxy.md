# MidpointConstraint3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface MidpointConstraint3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchLine3D Line { get; }
    MidpointConstraint3D NativeObject { get; }
    Sketch3D Parent { get; }
    SketchPoint3D Point { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [MidpointConstraint3D](../objects/MidpointConstraint3D.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SketchLine3D](../objects/SketchLine3D.md), [SketchPoint3D](../objects/SketchPoint3D.md)

