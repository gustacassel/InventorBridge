# SketchedSymbol

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.SketchedSymbols.Item[…]`

```csharp
interface SketchedSymbol
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Callout { get; }
    Color Color { get; set; }
    SketchedSymbolDefinition Definition { get; }
    Layer Layer { get; set; }
    Leader Leader { get; }
    bool LeaderClipping { get; set; }
    LeaderStyle LeaderStyle { get; set; }
    bool LeaderVisible { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    string Name { get; set; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    double Rotation { get; set; }
    double Scale { get; set; }
    bool Static { get; set; }
    bool SymbolClipping { get; set; }
    Matrix2d Transformation { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    string GetResultText(TextBox DefinitionText);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void SetPromptResultText(TextBox DefinitionText, string NewValue);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchedSymbols](../objects/SketchedSymbols.md).Add, [SketchedSymbols](../objects/SketchedSymbols.md).AddWithLeader, [SketchedSymbols](../objects/SketchedSymbols.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Color](../objects/Color.md), [Layer](../objects/Layer.md), [Leader](../objects/Leader.md), [LeaderStyle](../objects/LeaderStyle.md), [LineTypeEnum](../enums/LineTypeEnum.md), [Matrix2d](../objects/Matrix2d.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [SketchedSymbolDefinition](../objects/SketchedSymbolDefinition.md), [TextBox](../objects/TextBox.md)

