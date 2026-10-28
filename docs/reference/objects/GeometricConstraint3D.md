# GeometricConstraint3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].GeometricConstraints3D.Item[…]`

```csharp
interface GeometricConstraint3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Deletable { get; }
    Sketch3D Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [GeometricConstraints3D](../objects/GeometricConstraints3D.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md)

