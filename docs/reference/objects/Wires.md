# Wires

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Wires`

```csharp
interface Wires
{
    // Properties
    int Count { get; }
    Wire Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Path](../objects/Path.md).Wires, [PathProxy](../objects/PathProxy.md).Wires, [Profile](../objects/Profile.md).Wires, [Profile3D](../objects/Profile3D.md).Wires, [Profile3DProxy](../objects/Profile3DProxy.md).Wires, [ProfileProxy](../objects/ProfileProxy.md).Wires, [SurfaceBody](../objects/SurfaceBody.md).Wires, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).Wires, [Wire](../objects/Wire.md).OffsetPlanarWire

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Wire](../objects/Wire.md)

