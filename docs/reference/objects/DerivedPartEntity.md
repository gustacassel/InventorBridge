# DerivedPartEntity

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFuturePartComponents.Item[…].Definition.Solids.Item[…]`

```csharp
interface DerivedPartEntity
{
    // Properties
    object Application { get; }
    DerivedComponentOptionEnum DeriveStatus { get; set; }
    object ReferencedEntity { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedPartEntities](../objects/DerivedPartEntities.md).Item

**Referenced types:** [DerivedComponentOptionEnum](../enums/DerivedComponentOptionEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

