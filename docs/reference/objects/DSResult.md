# DSResult

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSJoints.Item[…].Definition.DegreesOfFreedom.Item[…].Results.Item[…]`

```csharp
interface DSResult
{
    // Properties
    object Application { get; }
    string Name { get; }
    DSDegreeOfFreedom Parent { get; }
    DSResultTypeEnum ResultType { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    double GetCurrentResultValue();
    void GetResultValues(ref double[] ResultValues);
}
```

**Returned by:** [DSResults](../objects/DSResults.md).Item, [DSResults](../objects/DSResults.md).ItemByResultType

**Referenced types:** [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md), [DSResultTypeEnum](../enums/DSResultTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

