# iMateResults

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iMateResults`

```csharp
interface iMateResults
{
    // Properties
    object Application { get; }
    int Count { get; }
    iMateResult Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    iMateResult AddByTwoiMates(iMateDefinition iMateDefinitionOne, iMateDefinition iMateDefinitionTwo);
    iMateResult AddByiMateAndEntity(iMateDefinition iMateDefinition, object Entity, object EntityBiasPoint = Missing, object AngleEntityReversed = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).iMateResults, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).iMateResults

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iMateDefinition](../objects/iMateDefinition.md), [iMateResult](../objects/iMateResult.md)

