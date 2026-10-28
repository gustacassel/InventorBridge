# PerpendicularConstraint3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PerpendicularConstraint3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    object EntityOne { get; }
    object EntityTwo { get; }
    PerpendicularConstraint3D NativeObject { get; }
    Sketch3D Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PerpendicularConstraint3D](../objects/PerpendicularConstraint3D.md), [Sketch3D](../objects/Sketch3D.md)

