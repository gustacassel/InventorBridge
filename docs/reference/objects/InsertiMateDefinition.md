# InsertiMateDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [iMateDefinition](../objects/iMateDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iMateDefinitions.Item[…] → (InsertiMateDefinition)`

```csharp
interface InsertiMateDefinition
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool AxesOpposed { get; }
    ConstraintLimits ConstraintLimits { get; }
    Parameter Distance { get; }
    object Entity { get; }
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

**Returned by:** [iMateDefinitions](../objects/iMateDefinitions.md).AddInsertiMateDefinition

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ConstraintLimits](../objects/ConstraintLimits.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ReferenceComponent](../objects/ReferenceComponent.md), [iMateDefinition](../objects/iMateDefinition.md)

