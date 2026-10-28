# DWGSplineProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGSplineProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Point EndPoint { get; }
    string HandleID { get; }
    DWGSpline NativeObject { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    Point StartPoint { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGEntity](../objects/DWGEntity.md), [DWGSpline](../objects/DWGSpline.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

