# SurfaceTextureStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.SurfaceTextureStyles`

```csharp
interface SurfaceTextureStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    SurfaceTextureStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).SurfaceTextureStyles

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceTextureStyle](../objects/SurfaceTextureStyle.md)

