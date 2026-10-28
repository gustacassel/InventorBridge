# SplineFitPointsConstraint3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface SplineFitPointsConstraint3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SplineFitPointsConstraint3D NativeObject { get; }
    Sketch3D Parent { get; }
    ObjectCollection Points { get; }
    object Spline { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SplineFitPointsConstraint3D](../objects/SplineFitPointsConstraint3D.md)

