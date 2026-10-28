# EdgeSymbol

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.EdgeSymbols.Item[…]`

```csharp
interface EdgeSymbol
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    EdgeSymbolDefinition Definition { get; set; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    EdgeSymbol CopyTo(Sheet TargetSheet, object NewName = Missing, object Position = Missing);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [EdgeSymbol](../objects/EdgeSymbol.md).CopyTo, [EdgeSymbolDefinition](../objects/EdgeSymbolDefinition.md).Parent, [EdgeSymbols](../objects/EdgeSymbols.md).Add, [EdgeSymbols](../objects/EdgeSymbols.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [EdgeSymbolDefinition](../objects/EdgeSymbolDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md)

