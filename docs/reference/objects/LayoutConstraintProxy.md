# LayoutConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [LayoutConstraint](../objects/LayoutConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints.Item[…].LayoutConstraint → (LayoutConstraintProxy)`

```csharp
interface LayoutConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
    LayoutConstraint NativeObject { get; }
    AssemblyComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    FlushConstraint XYFlushConstraint { get; }
    FlushConstraint XZFlushConstraint { get; }
    FlushConstraint YZFlushConstraint { get; }
    AngleConstraint ZAngleConstraint { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AngleConstraint](../objects/AngleConstraint.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [FlushConstraint](../objects/FlushConstraint.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [LayoutConstraint](../objects/LayoutConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

