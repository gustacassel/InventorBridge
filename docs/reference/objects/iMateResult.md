# iMateResult

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iMateResults.Item[…]`

```csharp
interface iMateResult
{
    // Properties
    AttributeSets AttributeSets { get; }
    AssemblyConstraintsEnumerator Constraints { get; }
    bool IsComposite { get; }
    string Name { get; set; }
    iMateResult ParentComposite { get; }
    iMateResultsEnumerator Results { get; }
    bool Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetInputs(out iMateDefinition iMateDefinition, out object Entity);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetInputs(iMateDefinition iMateDefinition, object Entity, object EntityBiasPoint = Missing, AngleConstraintSolutionTypeEnum SolutionType = AngleConstraintSolutionTypeEnum.kDirectedSolution);
}
```

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).iMateResult, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).iMateResult, [AssemblyConstraint](../objects/AssemblyConstraint.md).iMateResult, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).iMateResult, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).iMateResult, [FlushConstraint](../objects/FlushConstraint.md).iMateResult, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).iMateResult, [InsertConstraint](../objects/InsertConstraint.md).iMateResult, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).iMateResult, [MateConstraint](../objects/MateConstraint.md).iMateResult, [MateConstraintProxy](../objects/MateConstraintProxy.md).iMateResult, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).iMateResult, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).iMateResult, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).iMateResult, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).iMateResult, [TangentConstraint](../objects/TangentConstraint.md).iMateResult, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).iMateResult, [TransitionalConstraint](../objects/TransitionalConstraint.md).iMateResult, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).iMateResult, [TranslateTranslateConstraint](../objects/TranslateTranslateConstraint.md).iMateResult, [TranslateTranslateConstraintProxy](../objects/TranslateTranslateConstraintProxy.md).iMateResult, [iMateResult](../objects/iMateResult.md).ParentComposite, [iMateResultProxy](../objects/iMateResultProxy.md).NativeObject, [iMateResultProxy](../objects/iMateResultProxy.md).ParentComposite, [iMateResults](../objects/iMateResults.md).AddByTwoiMates, [iMateResults](../objects/iMateResults.md).AddByiMateAndEntity, [iMateResults](../objects/iMateResults.md).Item, [iMateResultsEnumerator](../objects/iMateResultsEnumerator.md).Item

**Referenced types:** [AngleConstraintSolutionTypeEnum](../enums/AngleConstraintSolutionTypeEnum.md), [AssemblyConstraintsEnumerator](../objects/AssemblyConstraintsEnumerator.md), [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iMateDefinition](../objects/iMateDefinition.md), [iMateResultsEnumerator](../objects/iMateResultsEnumerator.md)

