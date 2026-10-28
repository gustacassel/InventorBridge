# NormalToSurfaceWorkAxisDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface NormalToSurfaceWorkAxisDef
{
    // Properties
    object Application { get; }
    WorkAxis Parent { get; }
    object Point { get; }
    object SurfaceEntity { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Point, out object SurfaceEntity);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkAxis](../objects/WorkAxis.md)

