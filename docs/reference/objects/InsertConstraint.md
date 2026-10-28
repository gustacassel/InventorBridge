# InsertConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssemblyConstraint](../objects/AssemblyConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints.Item[…] → (InsertConstraint)`

```csharp
interface InsertConstraint
{
    // Properties
    ComponentOccurrence AffectedOccurrenceOne { get; }
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool AxesOpposed { get; }
    ConstraintLimits ConstraintLimits { get; }
    Parameter Distance { get; }
    DriveSettings DriveSettings { get; }
    object EntityOne { get; }
    object EntityTwo { get; }
    object GeometryOne { get; }
    object GeometryTwo { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsDefaultName { get; }
    LayoutConstraint LayoutConstraint { get; }
    bool LockRotation { get; set; }
    string Name { get; set; }
    ComponentOccurrence OccurrenceOne { get; }
    ComponentOccurrence OccurrenceTwo { get; }
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

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).ConvertToInsertConstraint, [AngleConstraint](../objects/AngleConstraint.md).ConvertToInsertConstraint2, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ConvertToInsertConstraint, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ConvertToInsertConstraint2, [AssemblyConstraint](../objects/AssemblyConstraint.md).ConvertToInsertConstraint, [AssemblyConstraint](../objects/AssemblyConstraint.md).ConvertToInsertConstraint2, [AssemblyConstraints](../objects/AssemblyConstraints.md).AddInsertConstraint, [AssemblyConstraints](../objects/AssemblyConstraints.md).AddInsertConstraint2, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).ConvertToInsertConstraint, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).ConvertToInsertConstraint2, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).ConvertToInsertConstraint, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).ConvertToInsertConstraint2, [FlushConstraint](../objects/FlushConstraint.md).ConvertToInsertConstraint, [FlushConstraint](../objects/FlushConstraint.md).ConvertToInsertConstraint2, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).ConvertToInsertConstraint, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).ConvertToInsertConstraint2, [InsertConstraint](../objects/InsertConstraint.md).ConvertToInsertConstraint, [InsertConstraint](../objects/InsertConstraint.md).ConvertToInsertConstraint2, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).ConvertToInsertConstraint, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).ConvertToInsertConstraint2, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).NativeObject, [MateConstraint](../objects/MateConstraint.md).ConvertToInsertConstraint, [MateConstraint](../objects/MateConstraint.md).ConvertToInsertConstraint2, [MateConstraintProxy](../objects/MateConstraintProxy.md).ConvertToInsertConstraint, [MateConstraintProxy](../objects/MateConstraintProxy.md).ConvertToInsertConstraint2, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).ConvertToInsertConstraint, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).ConvertToInsertConstraint2, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).ConvertToInsertConstraint, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).ConvertToInsertConstraint2, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).ConvertToInsertConstraint, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).ConvertToInsertConstraint2, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).ConvertToInsertConstraint, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).ConvertToInsertConstraint2, [TangentConstraint](../objects/TangentConstraint.md).ConvertToInsertConstraint, [TangentConstraint](../objects/TangentConstraint.md).ConvertToInsertConstraint2, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).ConvertToInsertConstraint, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).ConvertToInsertConstraint2, [TransitionalConstraint](../objects/TransitionalConstraint.md).ConvertToInsertConstraint, [TransitionalConstraint](../objects/TransitionalConstraint.md).ConvertToInsertConstraint2, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).ConvertToInsertConstraint and 5 more (see `members.tsv`)

**Referenced types:** [AngleConstraint](../objects/AngleConstraint.md), [AngleConstraintSolutionTypeEnum](../enums/AngleConstraintSolutionTypeEnum.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintLimits](../objects/ConstraintLimits.md), [DriveSettings](../objects/DriveSettings.md), [Face](../objects/Face.md), [FlushConstraint](../objects/FlushConstraint.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [InferredTypeEnum](../enums/InferredTypeEnum.md), [LayoutConstraint](../objects/LayoutConstraint.md), [MateConstraint](../objects/MateConstraint.md), [MateConstraintSolutionTypeEnum](../enums/MateConstraintSolutionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [RotateRotateConstraint](../objects/RotateRotateConstraint.md), [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md), [TangentConstraint](../objects/TangentConstraint.md), [TransitionalConstraint](../objects/TransitionalConstraint.md), [iMateResult](../objects/iMateResult.md)

