# SurfaceTextureSymbol

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.SurfaceTextureSymbols.Item[…]`

```csharp
interface SurfaceTextureSymbol
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    SurfaceTextureSymbolDefinition Definition { get; set; }
    Layer Layer { get; set; }
    Leader Leader { get; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    SurfaceTextureStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

14 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SurfaceTextureSymbols](../objects/SurfaceTextureSymbols.md).AddByDefinition, [SurfaceTextureSymbols](../objects/SurfaceTextureSymbols.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Layer](../objects/Layer.md), [Leader](../objects/Leader.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [SurfaceTextureStyle](../objects/SurfaceTextureStyle.md), [SurfaceTextureSymbolDefinition](../objects/SurfaceTextureSymbolDefinition.md)

