# Border

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Border`

```csharp
interface Border
{
    // Properties
    object Application { get; }
    BorderDefinition Definition { get; }
    string Name { get; set; }
    Sheet Parent { get; }
    Box2d RangeBox { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    string GetResultText(TextBox DefinitionText);
    void SetPromptResultText(TextBox DefinitionText, string NewValue);
}
```

**Returned by:** [Sheet](../objects/Sheet.md).AddBorder, [Sheet](../objects/Sheet.md).Border

**Referenced types:** [BorderDefinition](../objects/BorderDefinition.md), [Box2d](../objects/Box2d.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md), [TextBox](../objects/TextBox.md)

