# SplineFitPointsConstraint3D

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface SplineFitPointsConstraint3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Deletable { get; }
    Sketch3D Parent { get; }
    ObjectCollection Points { get; }
    object Spline { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [SplineFitPointsConstraint3DProxy](../objects/SplineFitPointsConstraint3DProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md)

