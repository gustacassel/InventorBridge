# AssemblyJointProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssemblyJoint](../objects/AssemblyJoint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Joints.Item[…] → (AssemblyJointProxy)`

```csharp
interface AssemblyJointProxy
{
    // Properties
    ComponentOccurrence AffectedOccurrenceOne { get; }
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    AssemblyJointDefinition Definition { get; set; }
    DriveSettings DriveSettings { get; }
    HealthStatusEnum HealthStatus { get; }
    bool Locked { get; set; }
    string Name { get; set; }
    AssemblyJoint NativeObject { get; }
    ComponentOccurrence OccurrenceOne { get; }
    ComponentOccurrence OccurrenceTwo { get; }
    AssemblyComponentDefinition Parent { get; }
    bool Protected { get; set; }
    bool Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblyJoint](../objects/AssemblyJoint.md), [AssemblyJointDefinition](../objects/AssemblyJointDefinition.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DriveSettings](../objects/DriveSettings.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

