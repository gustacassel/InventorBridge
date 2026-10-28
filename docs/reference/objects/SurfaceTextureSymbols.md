# SurfaceTextureSymbols

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.SurfaceTextureSymbols`

```csharp
interface SurfaceTextureSymbols
{
    // Properties
    object Application { get; }
    int Count { get; }
    SurfaceTextureSymbol Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SurfaceTextureSymbol AddByDefinition(ObjectCollection LeaderPoints, SurfaceTextureSymbolDefinition SurfaceTextureSymbolDefinition);
    SurfaceTextureSymbolDefinition CreateDefinition(object SurfaceTextureStyle = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).SurfaceTextureSymbols

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceTextureSymbol](../objects/SurfaceTextureSymbol.md), [SurfaceTextureSymbolDefinition](../objects/SurfaceTextureSymbolDefinition.md)

