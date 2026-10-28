# AngleConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssemblyConstraint](../objects/AssemblyConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints.Item[…] → (AngleConstraint)`

```csharp
interface AngleConstraint
{
    // Properties
    ComponentOccurrence AffectedOccurrenceOne { get; }
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    Parameter Angle { get; }
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
    AssemblyComponentDefinition Parent { get; }
    object ReferenceVectorEntity { get; }
    bool ResultOfLayoutConstraint { get; }
    bool ResultOfiMate { get; }
    AngleConstraintSolutionTypeEnum SolutionType { get; }
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

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).ConvertToAngleConstraint, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ConvertToAngleConstraint, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).NativeObject, [AssemblyConstraint](../objects/AssemblyConstraint.md).ConvertToAngleConstraint, [AssemblyConstraints](../objects/AssemblyConstraints.md).AddAngleConstraint, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).ConvertToAngleConstraint, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).ConvertToAngleConstraint, [FlushConstraint](../objects/FlushConstraint.md).ConvertToAngleConstraint, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).ConvertToAngleConstraint, [InsertConstraint](../objects/InsertConstraint.md).ConvertToAngleConstraint, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).ConvertToAngleConstraint, [LayoutConstraint](../objects/LayoutConstraint.md).ZAngleConstraint, [LayoutConstraintProxy](../objects/LayoutConstraintProxy.md).ZAngleConstraint, [MateConstraint](../objects/MateConstraint.md).ConvertToAngleConstraint, [MateConstraintProxy](../objects/MateConstraintProxy.md).ConvertToAngleConstraint, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).ConvertToAngleConstraint, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).ConvertToAngleConstraint, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).ConvertToAngleConstraint, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).ConvertToAngleConstraint, [TangentConstraint](../objects/TangentConstraint.md).ConvertToAngleConstraint, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).ConvertToAngleConstraint, [TransitionalConstraint](../objects/TransitionalConstraint.md).ConvertToAngleConstraint, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).ConvertToAngleConstraint, [TranslateTranslateConstraint](../objects/TranslateTranslateConstraint.md).ConvertToAngleConstraint, [TranslateTranslateConstraintProxy](../objects/TranslateTranslateConstraintProxy.md).ConvertToAngleConstraint

**Referenced types:** [AngleConstraintSolutionTypeEnum](../enums/AngleConstraintSolutionTypeEnum.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintLimits](../objects/ConstraintLimits.md), [DriveSettings](../objects/DriveSettings.md), [Face](../objects/Face.md), [FlushConstraint](../objects/FlushConstraint.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [InferredTypeEnum](../enums/InferredTypeEnum.md), [InsertConstraint](../objects/InsertConstraint.md), [LayoutConstraint](../objects/LayoutConstraint.md), [MateConstraint](../objects/MateConstraint.md), [MateConstraintSolutionTypeEnum](../enums/MateConstraintSolutionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [RotateRotateConstraint](../objects/RotateRotateConstraint.md), [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md), [TangentConstraint](../objects/TangentConstraint.md), [TransitionalConstraint](../objects/TransitionalConstraint.md), [iMateResult](../objects/iMateResult.md)

