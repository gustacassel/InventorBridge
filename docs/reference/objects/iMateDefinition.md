# iMateDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iMateDefinitions.Item[…]`

```csharp
interface iMateDefinition
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Exported { get; set; }
    bool HasReferenceComponent { get; }
    string Identifier { get; }
    object MatchList { get; set; }
    string Name { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    iMateDefinition ReferencedEntity { get; }
    int SequenceIndex { get; set; }
    bool Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [AngleiMateDefinition](../objects/AngleiMateDefinition.md).ReferencedEntity, [AngleiMateDefinitionProxy](../objects/AngleiMateDefinitionProxy.md).NativeObject, [AngleiMateDefinitionProxy](../objects/AngleiMateDefinitionProxy.md).ReferencedEntity, [CompositeiMateDefinition](../objects/CompositeiMateDefinition.md).Item, [CompositeiMateDefinition](../objects/CompositeiMateDefinition.md).ReferencedEntity, [CompositeiMateDefinitionProxy](../objects/CompositeiMateDefinitionProxy.md).Item, [CompositeiMateDefinitionProxy](../objects/CompositeiMateDefinitionProxy.md).NativeObject, [CompositeiMateDefinitionProxy](../objects/CompositeiMateDefinitionProxy.md).ReferencedEntity, [FlushiMateDefinition](../objects/FlushiMateDefinition.md).ReferencedEntity, [FlushiMateDefinitionProxy](../objects/FlushiMateDefinitionProxy.md).NativeObject, [FlushiMateDefinitionProxy](../objects/FlushiMateDefinitionProxy.md).ReferencedEntity, [InsertiMateDefinition](../objects/InsertiMateDefinition.md).ReferencedEntity, [InsertiMateDefinitionProxy](../objects/InsertiMateDefinitionProxy.md).NativeObject, [InsertiMateDefinitionProxy](../objects/InsertiMateDefinitionProxy.md).ReferencedEntity, [MateiMateDefinition](../objects/MateiMateDefinition.md).ReferencedEntity, [MateiMateDefinitionProxy](../objects/MateiMateDefinitionProxy.md).NativeObject, [MateiMateDefinitionProxy](../objects/MateiMateDefinitionProxy.md).ReferencedEntity, [RotateRotateiMateDefinition](../objects/RotateRotateiMateDefinition.md).ReferencedEntity, [RotateRotateiMateDefinitionProxy](../objects/RotateRotateiMateDefinitionProxy.md).NativeObject, [RotateRotateiMateDefinitionProxy](../objects/RotateRotateiMateDefinitionProxy.md).ReferencedEntity, [RotateTranslateiMateDefinition](../objects/RotateTranslateiMateDefinition.md).ReferencedEntity, [RotateTranslateiMateDefinitionProxy](../objects/RotateTranslateiMateDefinitionProxy.md).NativeObject, [RotateTranslateiMateDefinitionProxy](../objects/RotateTranslateiMateDefinitionProxy.md).ReferencedEntity, [TangentiMateDefinition](../objects/TangentiMateDefinition.md).ReferencedEntity, [TangentiMateDefinitionProxy](../objects/TangentiMateDefinitionProxy.md).NativeObject, [TangentiMateDefinitionProxy](../objects/TangentiMateDefinitionProxy.md).ReferencedEntity, [iMateDefinition](../objects/iMateDefinition.md).ReferencedEntity, [iMateDefinitions](../objects/iMateDefinitions.md).Item, [iMateDefinitionsEnumerator](../objects/iMateDefinitionsEnumerator.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md)

