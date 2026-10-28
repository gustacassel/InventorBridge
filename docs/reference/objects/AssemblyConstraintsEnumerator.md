# AssemblyConstraintsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Occurrences.Item[…].Constraints`

```csharp
interface AssemblyConstraintsEnumerator
{
    // Properties
    int Count { get; }
    AssemblyConstraint Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyWorkAxisDef](../objects/AssemblyWorkAxisDef.md).Constraints, [AssemblyWorkPlaneDef](../objects/AssemblyWorkPlaneDef.md).Constraints, [AssemblyWorkPointDef](../objects/AssemblyWorkPointDef.md).Constraints, [ComponentOccurrence](../objects/ComponentOccurrence.md).Constraints, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).Constraints, [iMateResult](../objects/iMateResult.md).Constraints, [iMateResultProxy](../objects/iMateResultProxy.md).Constraints

**Referenced types:** [AssemblyConstraint](../objects/AssemblyConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

