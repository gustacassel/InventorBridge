# iMateResultProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [iMateResult](../objects/iMateResult.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iMateResults.Item[…] → (iMateResultProxy)`

```csharp
interface iMateResultProxy
{
    // Properties
    AttributeSets AttributeSets { get; }
    AssemblyConstraintsEnumerator Constraints { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool IsComposite { get; }
    string Name { get; set; }
    iMateResult NativeObject { get; }
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

**Referenced types:** [AngleConstraintSolutionTypeEnum](../enums/AngleConstraintSolutionTypeEnum.md), [AssemblyConstraintsEnumerator](../objects/AssemblyConstraintsEnumerator.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iMateDefinition](../objects/iMateDefinition.md), [iMateResult](../objects/iMateResult.md), [iMateResultsEnumerator](../objects/iMateResultsEnumerator.md)

