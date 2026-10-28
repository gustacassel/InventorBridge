# Sketches3DEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedPartComponents.Item[…].Sketches3D`

```csharp
interface Sketches3DEnumerator
{
    // Properties
    int Count { get; }
    Sketch3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedPartComponent](../objects/DerivedPartComponent.md).Sketches3D, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).Sketches3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md)

