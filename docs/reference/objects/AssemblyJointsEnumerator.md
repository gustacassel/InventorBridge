# AssemblyJointsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Occurrences.Item[…].Joints`

```csharp
interface AssemblyJointsEnumerator
{
    // Properties
    int Count { get; }
    AssemblyJoint Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ComponentOccurrence](../objects/ComponentOccurrence.md).Joints, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).Joints

**Referenced types:** [AssemblyJoint](../objects/AssemblyJoint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

