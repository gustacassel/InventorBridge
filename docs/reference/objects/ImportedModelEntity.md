# ImportedModelEntity

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ImportedModelEntity
{
    // Properties
    object Application { get; }
    ImportedModelEntityTypeEnum EntityType { get; }
    ImportedModelEntityStatusEnum ImportedStatus { get; set; }
    string Name { get; }
    ImportedComponentDefinition Parent { get; }
    ImportedModelEntity ParentEntity { get; }
    ImportedModelEntities SubEntities { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [ImportedModelEntities](../objects/ImportedModelEntities.md).Item, [ImportedModelEntity](../objects/ImportedModelEntity.md).ParentEntity

**Referenced types:** [ImportedComponentDefinition](../objects/ImportedComponentDefinition.md), [ImportedModelEntities](../objects/ImportedModelEntities.md), [ImportedModelEntityStatusEnum](../enums/ImportedModelEntityStatusEnum.md), [ImportedModelEntityTypeEnum](../enums/ImportedModelEntityTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

