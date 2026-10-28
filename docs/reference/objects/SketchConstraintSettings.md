# SketchConstraintSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.SketchOptions.SketchConstraintSettings`

```csharp
interface SketchConstraintSettings
{
    // Properties
    object Application { get; }
    ConstraintInferencePriorityEnum ConstraintInferencePriority { get; set; }
    bool CreateDimensionsOnValueInput { get; set; }
    bool DisplayCoincidentConstraintsInSketch { get; set; }
    bool DisplayConstraintsOnCreation { get; set; }
    bool EditDimensionsWhenCreated { get; set; }
    bool EnableInferConstraints { get; set; }
    bool EnablePersistConstraints { get; set; }
    bool EnableRelaxMode { get; set; }
    SketchGeometricConstraintTypeEnum GeometricConstraintsToRemoveInRelaxMode { get; set; }
    bool KeepDimensionsWithEquationInRelaxMode { get; set; }
    OverConstrainedDimensionBehaviorEnum OverConstrainedDimensionBehavior { get; set; }
    SketchOptions Parent { get; }
    SketchConstraintInferenceTypeEnum SelectionForGeometricConstraintsInference { get; set; }
    bool ShowConstraintsForSelectedObjects { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [SketchOptions](../objects/SketchOptions.md).SketchConstraintSettings

**Referenced types:** [ConstraintInferencePriorityEnum](../enums/ConstraintInferencePriorityEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OverConstrainedDimensionBehaviorEnum](../enums/OverConstrainedDimensionBehaviorEnum.md), [SketchConstraintInferenceTypeEnum](../enums/SketchConstraintInferenceTypeEnum.md), [SketchGeometricConstraintTypeEnum](../enums/SketchGeometricConstraintTypeEnum.md), [SketchOptions](../objects/SketchOptions.md)

