# LayoutConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints.Item[…].LayoutConstraint`

```csharp
interface LayoutConstraint
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
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

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).LayoutConstraint, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).LayoutConstraint, [AssemblyConstraint](../objects/AssemblyConstraint.md).LayoutConstraint, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).LayoutConstraint, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).LayoutConstraint, [FlushConstraint](../objects/FlushConstraint.md).LayoutConstraint, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).LayoutConstraint, [InsertConstraint](../objects/InsertConstraint.md).LayoutConstraint, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).LayoutConstraint, [LayoutConstraintProxy](../objects/LayoutConstraintProxy.md).NativeObject, [MateConstraint](../objects/MateConstraint.md).LayoutConstraint, [MateConstraintProxy](../objects/MateConstraintProxy.md).LayoutConstraint, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).LayoutConstraint, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).LayoutConstraint, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).LayoutConstraint, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).LayoutConstraint, [TangentConstraint](../objects/TangentConstraint.md).LayoutConstraint, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).LayoutConstraint, [TransitionalConstraint](../objects/TransitionalConstraint.md).LayoutConstraint, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).LayoutConstraint, [TranslateTranslateConstraint](../objects/TranslateTranslateConstraint.md).LayoutConstraint, [TranslateTranslateConstraintProxy](../objects/TranslateTranslateConstraintProxy.md).LayoutConstraint

**Referenced types:** [AngleConstraint](../objects/AngleConstraint.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AttributeSets](../objects/AttributeSets.md), [FlushConstraint](../objects/FlushConstraint.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

