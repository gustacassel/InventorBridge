# EdgeLoops

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Faces.Item[…].EdgeLoops`

```csharp
interface EdgeLoops
{
    // Properties
    int Count { get; }
    EdgeLoop Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Face](../objects/Face.md).EdgeLoops, [FaceProxy](../objects/FaceProxy.md).EdgeLoops

**Referenced types:** [EdgeLoop](../objects/EdgeLoop.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

