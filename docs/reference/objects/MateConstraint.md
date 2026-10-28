# MateConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssemblyConstraint](../objects/AssemblyConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints.Item[…] → (MateConstraint)`

```csharp
interface MateConstraint
{
    // Properties
    ComponentOccurrence AffectedOccurrenceOne { get; }
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintLimits ConstraintLimits { get; }
    DriveSettings DriveSettings { get; }
    object EntityOne { get; }
    InferredTypeEnum EntityOneInferredType { get; }
    object EntityTwo { get; }
    InferredTypeEnum EntityTwoInferredType { get; }
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
    MateConstraintSolutionTypeEnum SolutionType { get; }
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

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).ConvertToMateConstraint, [AngleConstraint](../objects/AngleConstraint.md).ConvertToMateConstraint2, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ConvertToMateConstraint, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ConvertToMateConstraint2, [AssemblyConstraint](../objects/AssemblyConstraint.md).ConvertToMateConstraint, [AssemblyConstraint](../objects/AssemblyConstraint.md).ConvertToMateConstraint2, [AssemblyConstraints](../objects/AssemblyConstraints.md).AddMateConstraint, [AssemblyConstraints](../objects/AssemblyConstraints.md).AddMateConstraint2, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).ConvertToMateConstraint, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).ConvertToMateConstraint2, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).ConvertToMateConstraint, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).ConvertToMateConstraint2, [FlushConstraint](../objects/FlushConstraint.md).ConvertToMateConstraint, [FlushConstraint](../objects/FlushConstraint.md).ConvertToMateConstraint2, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).ConvertToMateConstraint, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).ConvertToMateConstraint2, [InsertConstraint](../objects/InsertConstraint.md).ConvertToMateConstraint, [InsertConstraint](../objects/InsertConstraint.md).ConvertToMateConstraint2, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).ConvertToMateConstraint, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).ConvertToMateConstraint2, [MateConstraint](../objects/MateConstraint.md).ConvertToMateConstraint, [MateConstraint](../objects/MateConstraint.md).ConvertToMateConstraint2, [MateConstraintProxy](../objects/MateConstraintProxy.md).ConvertToMateConstraint, [MateConstraintProxy](../objects/MateConstraintProxy.md).ConvertToMateConstraint2, [MateConstraintProxy](../objects/MateConstraintProxy.md).NativeObject, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).ConvertToMateConstraint, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).ConvertToMateConstraint2, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).ConvertToMateConstraint, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).ConvertToMateConstraint2, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).ConvertToMateConstraint, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).ConvertToMateConstraint2, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).ConvertToMateConstraint, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).ConvertToMateConstraint2, [TangentConstraint](../objects/TangentConstraint.md).ConvertToMateConstraint, [TangentConstraint](../objects/TangentConstraint.md).ConvertToMateConstraint2, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).ConvertToMateConstraint, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).ConvertToMateConstraint2, [TransitionalConstraint](../objects/TransitionalConstraint.md).ConvertToMateConstraint, [TransitionalConstraint](../objects/TransitionalConstraint.md).ConvertToMateConstraint2, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).ConvertToMateConstraint and 5 more (see `members.tsv`)

**Referenced types:** [AngleConstraint](../objects/AngleConstraint.md), [AngleConstraintSolutionTypeEnum](../enums/AngleConstraintSolutionTypeEnum.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintLimits](../objects/ConstraintLimits.md), [DriveSettings](../objects/DriveSettings.md), [Face](../objects/Face.md), [FlushConstraint](../objects/FlushConstraint.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [InferredTypeEnum](../enums/InferredTypeEnum.md), [InsertConstraint](../objects/InsertConstraint.md), [LayoutConstraint](../objects/LayoutConstraint.md), [MateConstraintSolutionTypeEnum](../enums/MateConstraintSolutionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [RotateRotateConstraint](../objects/RotateRotateConstraint.md), [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md), [TangentConstraint](../objects/TangentConstraint.md), [TransitionalConstraint](../objects/TransitionalConstraint.md), [iMateResult](../objects/iMateResult.md)

