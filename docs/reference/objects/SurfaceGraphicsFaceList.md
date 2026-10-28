# SurfaceGraphicsFaceList

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].AddSurfaceGraphics(…).DisplayedFaces`

```csharp
interface SurfaceGraphicsFaceList
{
    // Properties
    object Application { get; }
    int Count { get; }
    SurfaceGraphicsFace Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(object Faces);
    void Clear();
    void Remove(int Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ComponentGraphics](../objects/ComponentGraphics.md).DisplayedFaces, [SurfaceGraphics](../objects/SurfaceGraphics.md).DisplayedFaces

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceGraphicsFace](../objects/SurfaceGraphicsFace.md)

