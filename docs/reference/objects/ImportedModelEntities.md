# ImportedModelEntities

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ImportedModelEntities
{
    // Properties
    object Application { get; }
    int Count { get; }
    ImportedModelEntity Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ImportedGenericComponentDefinition](../objects/ImportedGenericComponentDefinition.md).ImportedModelEntities, [ImportedModelEntity](../objects/ImportedModelEntity.md).SubEntities

**Referenced types:** [ImportedModelEntity](../objects/ImportedModelEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

