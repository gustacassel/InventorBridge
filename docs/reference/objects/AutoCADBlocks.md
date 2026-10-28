# AutoCADBlocks

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.AutoCADBlocks`

```csharp
interface AutoCADBlocks
{
    // Properties
    object Application { get; }
    int Count { get; }
    AutoCADBlock Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AutoCADBlock Add(AutoCADBlockDefinition Definition, Point2d Position, double Rotation = 0, double Scale = 1, object PromptStrings = Missing, bool Static = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).AutoCADBlocks

**Referenced types:** [AutoCADBlock](../objects/AutoCADBlock.md), [AutoCADBlockDefinition](../objects/AutoCADBlockDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

