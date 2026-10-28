# DrawingWeldingSymbol

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.WeldingSymbols.Item[…]`

```csharp
interface DrawingWeldingSymbol
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    DrawingWeldingSymbolDefinitions Definitions { get; set; }
    Layer Layer { get; set; }
    Leader Leader { get; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    bool Retrieved { get; }
    object RetrievedFrom { get; }
    WeldSymbolStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [DrawingWeldingSymbolDefinition](../objects/DrawingWeldingSymbolDefinition.md).Parent, [DrawingWeldingSymbols](../objects/DrawingWeldingSymbols.md).Add, [DrawingWeldingSymbols](../objects/DrawingWeldingSymbols.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DrawingWeldingSymbolDefinitions](../objects/DrawingWeldingSymbolDefinitions.md), [Layer](../objects/Layer.md), [Leader](../objects/Leader.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [WeldSymbolStyle](../objects/WeldSymbolStyle.md)

