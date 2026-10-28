# DefaultBorder

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.AddDefaultBorder(…)`

```csharp
interface DefaultBorder
{
    // Properties
    object Application { get; }
    double BottomMargin { get; }
    bool Centermarks { get; }
    BorderDefinition Definition { get; }
    bool DelimitZonesByLines { get; }
    int HorizontalZoneCount { get; }
    BorderLabelModeEnum HorizontalZoneLabelMode { get; }
    bool LabelFromBottomRight { get; }
    double LeftMargin { get; }
    string Name { get; set; }
    Sheet Parent { get; }
    Box2d RangeBox { get; }
    double RightMargin { get; }
    double TopMargin { get; }
    ObjectTypeEnum Type { get; }
    int VerticalZoneCount { get; }
    BorderLabelModeEnum VerticalZoneLabelMode { get; }
    // Methods
    void Delete();
    string GetResultText(TextBox DefinitionText);
    void SetPromptResultText(TextBox DefinitionText, string NewValue);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).AddDefaultBorder

**Referenced types:** [BorderDefinition](../objects/BorderDefinition.md), [BorderLabelModeEnum](../enums/BorderLabelModeEnum.md), [Box2d](../objects/Box2d.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md), [TextBox](../objects/TextBox.md)

