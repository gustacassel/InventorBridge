# AssemblyJoints

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Joints`

```csharp
interface AssemblyJoints
{
    // Properties
    object Application { get; }
    int Count { get; }
    AssemblyJoint Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AssemblyJoint Add(AssemblyJointDefinition AssemblyJointDef);
    AssemblyJointDefinition CreateAssemblyJointDefinition(AssemblyJointTypeEnum JointType, GeometryIntent OriginOne, GeometryIntent OriginTwo);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).Joints, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).Joints

**Referenced types:** [AssemblyJoint](../objects/AssemblyJoint.md), [AssemblyJointDefinition](../objects/AssemblyJointDefinition.md), [AssemblyJointTypeEnum](../enums/AssemblyJointTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

