# CurveAndEntityWorkPointDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface CurveAndEntityWorkPointDef
{
    // Properties
    object Application { get; }
    object CurveEntity { get; }
    object Entity { get; }
    WorkPoint Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object CurveEntity, out object Entity);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkPoint](../objects/WorkPoint.md)

