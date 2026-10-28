# AssemblyJoint

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Joints.Item[…]`

```csharp
interface AssemblyJoint
{
    // Properties
    ComponentOccurrence AffectedOccurrenceOne { get; }
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    AssemblyJointDefinition Definition { get; set; }
    DriveSettings DriveSettings { get; }
    HealthStatusEnum HealthStatus { get; }
    bool Locked { get; set; }
    string Name { get; set; }
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

**Returned by:** [AssemblyJointDefinition](../objects/AssemblyJointDefinition.md).Parent, [AssemblyJointProxy](../objects/AssemblyJointProxy.md).NativeObject, [AssemblyJoints](../objects/AssemblyJoints.md).Add, [AssemblyJoints](../objects/AssemblyJoints.md).Item, [AssemblyJointsEnumerator](../objects/AssemblyJointsEnumerator.md).Item

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblyJointDefinition](../objects/AssemblyJointDefinition.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DriveSettings](../objects/DriveSettings.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

