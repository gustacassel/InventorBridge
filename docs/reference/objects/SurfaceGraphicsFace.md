# SurfaceGraphicsFace

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].AddSurfaceGraphics(…).DisplayedFaces.Item[…]`

```csharp
interface SurfaceGraphicsFace
{
    // Properties
    Asset Appearance { get; set; }
    object Application { get; }
    Color Color { get; set; }
    Face Face { get; }
    int Index { get; }
    SurfaceGraphics Parent { get; }
    bool Selectable { get; set; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SurfaceGraphicsFaceList](../objects/SurfaceGraphicsFaceList.md).Item

**Referenced types:** [Asset](../objects/Asset.md), [Color](../objects/Color.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceGraphics](../objects/SurfaceGraphics.md)

