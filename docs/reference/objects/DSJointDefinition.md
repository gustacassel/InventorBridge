# DSJointDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSJoints.Item[…].Definition`

```csharp
interface DSJointDefinition
{
    // Properties
    object Application { get; }
    DSDegreesOfFreedom DegreesOfFreedom { get; }
    Color ForceGlyphColor { get; set; }
    double ForceGlyphScale { get; set; }
    bool IsDOFsLocked { get; set; }
    bool IsForceDisplayed { get; set; }
    bool IsLoadDisplayed { get; set; }
    bool IsSuppressed { get; set; }
    Color LoadGlyphColor { get; set; }
    double LoadGlyphScale { get; set; }
    DSJoint Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DSJointDefinition Copy();
}
```

**Returned by:** [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).Parent, [DSJoint](../objects/DSJoint.md).Definition, [DSJointDefinition](../objects/DSJointDefinition.md).Copy

**Referenced types:** [Color](../objects/Color.md), [DSDegreesOfFreedom](../objects/DSDegreesOfFreedom.md), [DSJoint](../objects/DSJoint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

