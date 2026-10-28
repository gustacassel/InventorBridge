# MidpointConstraint3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].GeometricConstraints3D.AddMidpoint(…)`

```csharp
interface MidpointConstraint3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Deletable { get; }
    SketchLine3D Line { get; }
    Sketch3D Parent { get; }
    SketchPoint3D Point { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [GeometricConstraints3D](../objects/GeometricConstraints3D.md).AddMidpoint, [MidpointConstraint3DProxy](../objects/MidpointConstraint3DProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SketchLine3D](../objects/SketchLine3D.md), [SketchPoint3D](../objects/SketchPoint3D.md)

