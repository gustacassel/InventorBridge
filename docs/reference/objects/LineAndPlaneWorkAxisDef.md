# LineAndPlaneWorkAxisDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface LineAndPlaneWorkAxisDef
{
    // Properties
    object Application { get; }
    object Line { get; }
    WorkAxis Parent { get; }
    object Plane { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Line, out object Plane);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkAxis](../objects/WorkAxis.md)

