# ModelHoleThreadNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelHoleThreadNotes`

```csharp
interface ModelHoleThreadNotes
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelHoleThreadNote Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelHoleThreadNote Add(ModelHoleThreadNoteDefinition Definition);
    HoleClearanceInfo CreateClearanceInfo(string FastenerStandard, string FastenerType, string FastenerSize, object FastenerFitType = 84072099);
    ModelHoleThreadNoteDefinition CreateDefinition(GeometryIntent Intent, AnnotationPlaneDefinition AnnotationPlaneDefinition, Point LandingPosition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelHoleThreadNotes

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [GeometryIntent](../objects/GeometryIntent.md), [HoleClearanceInfo](../objects/HoleClearanceInfo.md), [ModelHoleThreadNote](../objects/ModelHoleThreadNote.md), [ModelHoleThreadNoteDefinition](../objects/ModelHoleThreadNoteDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

