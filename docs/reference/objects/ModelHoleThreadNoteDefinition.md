# ModelHoleThreadNoteDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ModelDimensionDefinition](../objects/ModelDimensionDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelHoleThreadNotes.Item[…].Definition`

```csharp
interface ModelHoleThreadNoteDefinition
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    string FormattedHoleThreadNote { get; set; }
    GeometryIntent Intent { get; set; }
    bool IsHoleNote { get; set; }
    bool IsTapDrill { get; set; }
    Point LandingPosition { get; set; }
    ModelAnnotation Parent { get; }
    bool RightHandedThread { get; set; } // since 2025
    ModelAnnotationText Text { get; }
    Point TextPosition { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseCustomThreadDesignation { get; set; }
    bool UseDefaultFormat { get; set; }
    bool UseModelUnits { get; set; }
    bool UseParameterTolerance { get; set; }
    // Methods
    ModelHoleThreadNoteDefinition Copy();
    Tolerance GetHolePropertyTolerance(HolePropertyEnum HolePropEnum);
    int GetHolePropertyTolerancePrecision(HolePropertyEnum HolePropEnum);
    bool GetHolePropertyToleranceStatus(HolePropertyEnum HolePropEnum);
    bool IsValidAnnotationPlane(object pPlane);
    void SetHolePropertyTolerancePrecision(HolePropertyEnum HolePropEnum, int Value);
    void SetHolePropertyToleranceStatus(HolePropertyEnum HolePropEnum, bool Value);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelHoleThreadNote](../objects/ModelHoleThreadNote.md).Definition, [ModelHoleThreadNoteDefinition](../objects/ModelHoleThreadNoteDefinition.md).Copy, [ModelHoleThreadNoteProxy](../objects/ModelHoleThreadNoteProxy.md).Definition, [ModelHoleThreadNotes](../objects/ModelHoleThreadNotes.md).CreateDefinition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [HolePropertyEnum](../enums/HolePropertyEnum.md), [ModelAnnotation](../objects/ModelAnnotation.md), [ModelAnnotationText](../objects/ModelAnnotationText.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Tolerance](../objects/Tolerance.md)

