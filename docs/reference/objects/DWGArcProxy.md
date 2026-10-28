# DWGArcProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGArcProxy
{
    // Properties
    object Application { get; }
    Point Center { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    string HandleID { get; }
    DWGArc NativeObject { get; }
    UnitVector Normal { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGArc](../objects/DWGArc.md), [DWGEntity](../objects/DWGEntity.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

