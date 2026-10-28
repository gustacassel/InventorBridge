# FaceShells

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].FaceShells`

```csharp
interface FaceShells
{
    // Properties
    int Count { get; }
    FaceShell Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SurfaceBody](../objects/SurfaceBody.md).FaceShells, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).FaceShells

**Referenced types:** [FaceShell](../objects/FaceShell.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

