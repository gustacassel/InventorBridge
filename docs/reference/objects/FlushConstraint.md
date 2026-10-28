# FlushConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssemblyConstraint](../objects/AssemblyConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints.Item[…] → (FlushConstraint)`

```csharp
interface FlushConstraint
{
    // Properties
    ComponentOccurrence AffectedOccurrenceOne { get; }
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintLimits ConstraintLimits { get; }
    DriveSettings DriveSettings { get; }
    object EntityOne { get; }
    object EntityTwo { get; }
    object GeometryOne { get; }
    object GeometryTwo { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsDefaultName { get; }
    LayoutConstraint LayoutConstraint { get; }
    string Name { get; set; }
    ComponentOccurrence OccurrenceOne { get; }
    ComponentOccurrence OccurrenceTwo { get; }
    Parameter Offset { get; }
    AssemblyComponentDefinition Parent { get; }
    bool ResultOfLayoutConstraint { get; }
    bool ResultOfiMate { get; }
    bool Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    iMateResult iMateResult { get; }
    // Methods
    AngleConstraint ConvertToAngleConstraint(object EntityOne, object EntityTwo, object Angle, AngleConstraintSolutionTypeEnum SolutionType = AngleConstraintSolutionTypeEnum.kDirectedSolution, object ReferenceVectorEntity = Missing, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    CustomConstraint ConvertToCustomConstraint(object EntityOne, object EntityTwo, string ClientId);
    FlushConstraint ConvertToFlushConstraint(object EntityOne, object EntityTwo, object Offset, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    InsertConstraint ConvertToInsertConstraint(object EntityOne, object EntityTwo, bool AxesOpposed, object Distance, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    InsertConstraint ConvertToInsertConstraint2(object EntityOne, object EntityTwo, bool AxesOpposed, object Distance, object LockRotation = Missing, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    MateConstraint ConvertToMateConstraint(object EntityOne, object EntityTwo, object Offset, InferredTypeEnum EntityOneInferredType = InferredTypeEnum.kNoInference, InferredTypeEnum EntityTwoInferredType = InferredTypeEnum.kNoInference, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    MateConstraint ConvertToMateConstraint2(object EntityOne, object EntityTwo, object Offset, InferredTypeEnum EntityOneInferredType = InferredTypeEnum.kNoInference, InferredTypeEnum EntityTwoInferredType = InferredTypeEnum.kNoInference, MateConstraintSolutionTypeEnum SolutionType = MateConstraintSolutionTypeEnum.kOpposedSolutionType, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    RotateRotateConstraint ConvertToRotateRotateConstraint(object EntityOne, object EntityTwo, object Ratio, bool ForwardDirection, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    RotateTranslateConstraint ConvertToRotateTranslateConstraint(object EntityOne, object EntityTwo, object Ratio, bool ForwardDirection, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    AssemblySymmetryConstraint ConvertToSymmetryConstraint(object EntityOne, object EntityTwo, object SymmetryPlane, InferredTypeEnum EntityOneInferredType = InferredTypeEnum.kNoInference, InferredTypeEnum EntityTwoInferredType = InferredTypeEnum.kNoInference, bool NormalsOpposed = true);
    TangentConstraint ConvertToTangentConstraint(object EntityOne, object EntityTwo, bool InsideTangency, object Offset, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    TransitionalConstraint ConvertToTransitionalConstraint(Face FaceOne, Face FaceTwo, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).ConvertToFlushConstraint, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ConvertToFlushConstraint, [AssemblyConstraint](../objects/AssemblyConstraint.md).ConvertToFlushConstraint, [AssemblyConstraints](../objects/AssemblyConstraints.md).AddFlushConstraint, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).ConvertToFlushConstraint, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).ConvertToFlushConstraint, [FlushConstraint](../objects/FlushConstraint.md).ConvertToFlushConstraint, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).ConvertToFlushConstraint, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).NativeObject, [InsertConstraint](../objects/InsertConstraint.md).ConvertToFlushConstraint, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).ConvertToFlushConstraint, [LayoutConstraint](../objects/LayoutConstraint.md).XYFlushConstraint, [LayoutConstraint](../objects/LayoutConstraint.md).XZFlushConstraint, [LayoutConstraint](../objects/LayoutConstraint.md).YZFlushConstraint, [LayoutConstraintProxy](../objects/LayoutConstraintProxy.md).XYFlushConstraint, [LayoutConstraintProxy](../objects/LayoutConstraintProxy.md).XZFlushConstraint, [LayoutConstraintProxy](../objects/LayoutConstraintProxy.md).YZFlushConstraint, [MateConstraint](../objects/MateConstraint.md).ConvertToFlushConstraint, [MateConstraintProxy](../objects/MateConstraintProxy.md).ConvertToFlushConstraint, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).ConvertToFlushConstraint, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).ConvertToFlushConstraint, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).ConvertToFlushConstraint, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).ConvertToFlushConstraint, [TangentConstraint](../objects/TangentConstraint.md).ConvertToFlushConstraint, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).ConvertToFlushConstraint, [TransitionalConstraint](../objects/TransitionalConstraint.md).ConvertToFlushConstraint, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).ConvertToFlushConstraint, [TranslateTranslateConstraint](../objects/TranslateTranslateConstraint.md).ConvertToFlushConstraint, [TranslateTranslateConstraintProxy](../objects/TranslateTranslateConstraintProxy.md).ConvertToFlushConstraint

**Referenced types:** [AngleConstraint](../objects/AngleConstraint.md), [AngleConstraintSolutionTypeEnum](../enums/AngleConstraintSolutionTypeEnum.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintLimits](../objects/ConstraintLimits.md), [DriveSettings](../objects/DriveSettings.md), [Face](../objects/Face.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [InferredTypeEnum](../enums/InferredTypeEnum.md), [InsertConstraint](../objects/InsertConstraint.md), [LayoutConstraint](../objects/LayoutConstraint.md), [MateConstraint](../objects/MateConstraint.md), [MateConstraintSolutionTypeEnum](../enums/MateConstraintSolutionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [RotateRotateConstraint](../objects/RotateRotateConstraint.md), [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md), [TangentConstraint](../objects/TangentConstraint.md), [TransitionalConstraint](../objects/TransitionalConstraint.md), [iMateResult](../objects/iMateResult.md)

