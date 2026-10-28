# iMateResultsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iMateResults.Item[…].Results`

```csharp
interface iMateResultsEnumerator
{
    // Properties
    int Count { get; }
    iMateResult Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iMateResult](../objects/iMateResult.md).Results, [iMateResultProxy](../objects/iMateResultProxy.md).Results

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iMateResult](../objects/iMateResult.md)

