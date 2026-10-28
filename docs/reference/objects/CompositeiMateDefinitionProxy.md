# CompositeiMateDefinitionProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [CompositeiMateDefinition](../objects/CompositeiMateDefinition.md) → [iMateDefinition](../objects/iMateDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iMateDefinitions.Item[…] → (CompositeiMateDefinition) → (CompositeiMateDefinitionProxy)`

```csharp
interface CompositeiMateDefinitionProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    int Count { get; }
    bool Exported { get; set; }
    bool HasReferenceComponent { get; }
    string Identifier { get; }
    bool IsConsumed { get; }
    iMateDefinition Item[int Index] { get; }
    object MatchList { get; set; }
    string Name { get; set; }
    iMateDefinition NativeObject { get; }
    ReferenceComponent ReferenceComponent { get; }
    iMateDefinition ReferencedEntity { get; }
    int SequenceIndex { get; set; }
    bool Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void RemoveItems(ObjectCollection iMates);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [iMateDefinition](../objects/iMateDefinition.md)

