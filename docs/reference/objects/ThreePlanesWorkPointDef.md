# ThreePlanesWorkPointDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ThreePlanesWorkPointDef
{
    // Properties
    object Application { get; }
    WorkPoint Parent { get; }
    object Plane1 { get; }
    object Plane2 { get; }
    object Plane3 { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Plane1, out object Plane2, out object Plane3);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkPoint](../objects/WorkPoint.md)

