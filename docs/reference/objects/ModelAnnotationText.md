# ModelAnnotationText

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelLeaderNotes.Item[…].Definition.Text`

```csharp
interface ModelAnnotationText
{
    // Properties
    object Application { get; }
    Color Color { get; set; }
    string Font { get; set; }
    string FormattedText { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    ModelAnnotation Parent { get; }
    Point Position { get; set; }
    double Size { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    string Text { get; }
    ObjectTypeEnum Type { get; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double WidthScale { get; set; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md).Text, [DiameterModelDimensionDefinition](../objects/DiameterModelDimensionDefinition.md).Text, [LinearModelDimensionDefinition](../objects/LinearModelDimensionDefinition.md).Text, [ModelDimensionDefinition](../objects/ModelDimensionDefinition.md).Text, [ModelGeneralNoteDefinition](../objects/ModelGeneralNoteDefinition.md).Text, [ModelHoleThreadNoteDefinition](../objects/ModelHoleThreadNoteDefinition.md).Text, [ModelLeaderNoteDefinition](../objects/ModelLeaderNoteDefinition.md).Text, [RadiusModelDimensionDefinition](../objects/RadiusModelDimensionDefinition.md).Text

**Referenced types:** [Color](../objects/Color.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [ModelAnnotation](../objects/ModelAnnotation.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [TextLineSpacingTypeEnum](../enums/TextLineSpacingTypeEnum.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

