# DSLoad

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSLoads.Item[…]`

```csharp
interface DSLoad
{
    // Properties
    object Application { get; }
    DSLoadDefinition Definition { get; set; }
    bool IsSuppressed { get; set; }
    DSLoadTypeEnum LoadType { get; }
    string Name { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DSLoadDefinition](../objects/DSLoadDefinition.md).Parent, [DSLoads](../objects/DSLoads.md).Item

**Referenced types:** [DSLoadDefinition](../objects/DSLoadDefinition.md), [DSLoadTypeEnum](../enums/DSLoadTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

