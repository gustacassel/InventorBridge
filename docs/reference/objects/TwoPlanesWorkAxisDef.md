# TwoPlanesWorkAxisDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface TwoPlanesWorkAxisDef
{
    // Properties
    object Application { get; }
    WorkAxis Parent { get; }
    object Plane1 { get; }
    object Plane2 { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Plane1, out object Plane2);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkAxis](../objects/WorkAxis.md)

