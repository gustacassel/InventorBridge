# RotateTranslateiMateDefinitionProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [RotateRotateiMateDefinition](../objects/RotateRotateiMateDefinition.md) → [iMateDefinition](../objects/iMateDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iMateDefinitions.Item[…] → (RotateRotateiMateDefinition) → (RotateTranslateiMateDefinitionProxy)`

```csharp
interface RotateTranslateiMateDefinitionProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    object Entity { get; }
    bool Exported { get; set; }
    bool ForwardDirection { get; }
    bool HasReferenceComponent { get; }
    string Identifier { get; }
    bool IsConsumed { get; }
    object MatchList { get; set; }
    string Name { get; set; }
    iMateDefinition NativeObject { get; }
    Parameter Ratio { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ReferenceComponent](../objects/ReferenceComponent.md), [iMateDefinition](../objects/iMateDefinition.md)

