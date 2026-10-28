# TitleBlock

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.TitleBlock`

```csharp
interface TitleBlock
{
    // Properties
    object Application { get; }
    TitleBlockDefinition Definition { get; }
    TitleBlockLocationEnum Location { get; }
    string Name { get; set; }
    Sheet Parent { get; }
    Point2d Position { get; }
    Box2d RangeBox { get; }
    Matrix2d Transformation { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    string GetResultText(TextBox DefinitionText);
    void SetPromptResultText(TextBox DefinitionText, string NewValue);
}
```

**Returned by:** [Sheet](../objects/Sheet.md).AddTitleBlock, [Sheet](../objects/Sheet.md).TitleBlock

**Referenced types:** [Box2d](../objects/Box2d.md), [Matrix2d](../objects/Matrix2d.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [TextBox](../objects/TextBox.md), [TitleBlockDefinition](../objects/TitleBlockDefinition.md), [TitleBlockLocationEnum](../enums/TitleBlockLocationEnum.md)

