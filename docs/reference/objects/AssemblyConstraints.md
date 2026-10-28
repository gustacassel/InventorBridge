# AssemblyConstraints

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints`

```csharp
interface AssemblyConstraints
{
    // Properties
    object Application { get; }
    int Count { get; }
    AssemblyConstraint Item[object Index] { get; }
    AssemblyComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AngleConstraint AddAngleConstraint(object EntityOne, object EntityTwo, object Angle, AngleConstraintSolutionTypeEnum SolutionType = AngleConstraintSolutionTypeEnum.kDirectedSolution, object ReferenceVectorEntity = Missing, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    FlushConstraint AddFlushConstraint(object EntityOne, object EntityTwo, object Offset, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    InsertConstraint AddInsertConstraint(object EntityOne, object EntityTwo, bool AxesOpposed, object Distance, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    InsertConstraint AddInsertConstraint2(object EntityOne, object EntityTwo, bool AxesOpposed, object Distance, object LockRotation = Missing, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    MateConstraint AddMateConstraint(object EntityOne, object EntityTwo, object Offset, InferredTypeEnum EntityOneInferredType = InferredTypeEnum.kNoInference, InferredTypeEnum EntityTwoInferredType = InferredTypeEnum.kNoInference, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    MateConstraint AddMateConstraint2(object EntityOne, object EntityTwo, object Offset, InferredTypeEnum EntityOneInferredType = InferredTypeEnum.kNoInference, InferredTypeEnum EntityTwoInferredType = InferredTypeEnum.kNoInference, MateConstraintSolutionTypeEnum SolutionType = MateConstraintSolutionTypeEnum.kOpposedSolutionType, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    RotateRotateConstraint AddRotateRotateConstraint(object EntityOne, object EntityTwo, object Ratio, bool ForwardDirection, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    RotateTranslateConstraint AddRotateTranslateConstraint(object EntityOne, object EntityTwo, object Ratio, bool ForwardDirection, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    AssemblySymmetryConstraint AddSymmetryConstraint(object EntityOne, object EntityTwo, object SymmetryPlane, InferredTypeEnum EntityOneInferredType = InferredTypeEnum.kNoInference, InferredTypeEnum EntityTwoInferredType = InferredTypeEnum.kNoInference, bool NormalsOpposed = true);
    TangentConstraint AddTangentConstraint(object EntityOne, object EntityTwo, bool InsideTangency, object Offset, object BiasPointOne = Missing, object BiasPointTwo = Missing);
    TransitionalConstraint AddTransitionalConstraint(Face FaceOne, Face FaceTwo, object BiasPointOne = Missing, object BiasPointTwo = Missing);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).Constraints, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).Constraints

**Referenced types:** [AngleConstraint](../objects/AngleConstraint.md), [AngleConstraintSolutionTypeEnum](../enums/AngleConstraintSolutionTypeEnum.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblyConstraint](../objects/AssemblyConstraint.md), [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md), [Face](../objects/Face.md), [FlushConstraint](../objects/FlushConstraint.md), [InferredTypeEnum](../enums/InferredTypeEnum.md), [InsertConstraint](../objects/InsertConstraint.md), [MateConstraint](../objects/MateConstraint.md), [MateConstraintSolutionTypeEnum](../enums/MateConstraintSolutionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RotateRotateConstraint](../objects/RotateRotateConstraint.md), [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md), [TangentConstraint](../objects/TangentConstraint.md), [TransitionalConstraint](../objects/TransitionalConstraint.md)

