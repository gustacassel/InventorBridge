# _AssemblySolverNode

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface _AssemblySolverNode
{
    // Properties
    object Application { get; }
    _AssemblySolver Parent { get; }
    bool SolvedAsRigid { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddDependency(_AssemblySolverNode Node);
    // Events
    event OnSolve(NameValueMap Context, EventTimingEnum BeforeOrAfter);
}
```

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

