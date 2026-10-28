# RotateRotateConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssemblyConstraint](../objects/AssemblyConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints.Item[…] → (RotateRotateConstraint)`

```csharp
interface RotateRotateConstraint
{
    // Properties
    ComponentOccurrence AffectedOccurrenceOne { get; }
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    DriveSettings DriveSettings { get; }
    object EntityOne { get; }
    object EntityTwo { get; }
    bool ForwardDirection { get; }
    object GeometryOne { get; }
    object GeometryTwo { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsDefaultName { get; }
    LayoutConstraint LayoutConstraint { get; }
    string Name { get; set; }
    ComponentOccurrence OccurrenceOne { get; }
    ComponentOccurrence OccurrenceTwo { get; }
    AssemblyComponentDefinition Parent { get; }
    Parameter Ratio { get; }
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

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).ConvertToRotateRotateConstraint, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ConvertToRotateRotateConstraint, [AssemblyConstraint](../objects/AssemblyConstraint.md).ConvertToRotateRotateConstraint, [AssemblyConstraints](../objects/AssemblyConstraints.md).AddRotateRotateConstraint, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).ConvertToRotateRotateConstraint, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).ConvertToRotateRotateConstraint, [FlushConstraint](../objects/FlushConstraint.md).ConvertToRotateRotateConstraint, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).ConvertToRotateRotateConstraint, [InsertConstraint](../objects/InsertConstraint.md).ConvertToRotateRotateConstraint, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).ConvertToRotateRotateConstraint, [MateConstraint](../objects/MateConstraint.md).ConvertToRotateRotateConstraint, [MateConstraintProxy](../objects/MateConstraintProxy.md).ConvertToRotateRotateConstraint, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).ConvertToRotateRotateConstraint, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).ConvertToRotateRotateConstraint, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).NativeObject, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).ConvertToRotateRotateConstraint, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).ConvertToRotateRotateConstraint, [TangentConstraint](../objects/TangentConstraint.md).ConvertToRotateRotateConstraint, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).ConvertToRotateRotateConstraint, [TransitionalConstraint](../objects/TransitionalConstraint.md).ConvertToRotateRotateConstraint, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).ConvertToRotateRotateConstraint, [TranslateTranslateConstraint](../objects/TranslateTranslateConstraint.md).ConvertToRotateRotateConstraint, [TranslateTranslateConstraintProxy](../objects/TranslateTranslateConstraintProxy.md).ConvertToRotateRotateConstraint

**Referenced types:** [AngleConstraint](../objects/AngleConstraint.md), [AngleConstraintSolutionTypeEnum](../enums/AngleConstraintSolutionTypeEnum.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DriveSettings](../objects/DriveSettings.md), [Face](../objects/Face.md), [FlushConstraint](../objects/FlushConstraint.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [InferredTypeEnum](../enums/InferredTypeEnum.md), [InsertConstraint](../objects/InsertConstraint.md), [LayoutConstraint](../objects/LayoutConstraint.md), [MateConstraint](../objects/MateConstraint.md), [MateConstraintSolutionTypeEnum](../enums/MateConstraintSolutionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md), [TangentConstraint](../objects/TangentConstraint.md), [TransitionalConstraint](../objects/TransitionalConstraint.md), [iMateResult](../objects/iMateResult.md)

