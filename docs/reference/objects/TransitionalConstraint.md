# TransitionalConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssemblyConstraint](../objects/AssemblyConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints.Item[…] → (TransitionalConstraint)`

```csharp
interface TransitionalConstraint
{
    // Properties
    ComponentOccurrence AffectedOccurrenceOne { get; }
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
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

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).ConvertToTransitionalConstraint, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ConvertToTransitionalConstraint, [AssemblyConstraint](../objects/AssemblyConstraint.md).ConvertToTransitionalConstraint, [AssemblyConstraints](../objects/AssemblyConstraints.md).AddTransitionalConstraint, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).ConvertToTransitionalConstraint, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).ConvertToTransitionalConstraint, [FlushConstraint](../objects/FlushConstraint.md).ConvertToTransitionalConstraint, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).ConvertToTransitionalConstraint, [InsertConstraint](../objects/InsertConstraint.md).ConvertToTransitionalConstraint, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).ConvertToTransitionalConstraint, [MateConstraint](../objects/MateConstraint.md).ConvertToTransitionalConstraint, [MateConstraintProxy](../objects/MateConstraintProxy.md).ConvertToTransitionalConstraint, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).ConvertToTransitionalConstraint, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).ConvertToTransitionalConstraint, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).ConvertToTransitionalConstraint, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).ConvertToTransitionalConstraint, [TangentConstraint](../objects/TangentConstraint.md).ConvertToTransitionalConstraint, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).ConvertToTransitionalConstraint, [TransitionalConstraint](../objects/TransitionalConstraint.md).ConvertToTransitionalConstraint, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).ConvertToTransitionalConstraint, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).NativeObject, [TranslateTranslateConstraint](../objects/TranslateTranslateConstraint.md).ConvertToTransitionalConstraint, [TranslateTranslateConstraintProxy](../objects/TranslateTranslateConstraintProxy.md).ConvertToTransitionalConstraint

**Referenced types:** [AngleConstraint](../objects/AngleConstraint.md), [AngleConstraintSolutionTypeEnum](../enums/AngleConstraintSolutionTypeEnum.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DriveSettings](../objects/DriveSettings.md), [Face](../objects/Face.md), [FlushConstraint](../objects/FlushConstraint.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [InferredTypeEnum](../enums/InferredTypeEnum.md), [InsertConstraint](../objects/InsertConstraint.md), [LayoutConstraint](../objects/LayoutConstraint.md), [MateConstraint](../objects/MateConstraint.md), [MateConstraintSolutionTypeEnum](../enums/MateConstraintSolutionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RotateRotateConstraint](../objects/RotateRotateConstraint.md), [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md), [TangentConstraint](../objects/TangentConstraint.md), [iMateResult](../objects/iMateResult.md)

