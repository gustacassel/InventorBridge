# ParallelToXZPlaneConstraint3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ParallelToXZPlaneConstraint3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchEntity3D Entity { get; }
    ParallelToXZPlaneConstraint3D NativeObject { get; }
    Sketch3D Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ParallelToXZPlaneConstraint3D](../objects/ParallelToXZPlaneConstraint3D.md), [Sketch3D](../objects/Sketch3D.md), [SketchEntity3D](../objects/SketchEntity3D.md)

