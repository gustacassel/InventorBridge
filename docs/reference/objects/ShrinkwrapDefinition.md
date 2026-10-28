# ShrinkwrapDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.ShrinkwrapComponents.Item[…].Definition`

```csharp
interface ShrinkwrapDefinition
{
    // Properties
    string ActiveDesignViewRepresentation { get; set; }
    string ActiveModelState { get; set; }
    string ActivePositionalRepresentation { get; set; }
    ObjectCollection AdditionalExcludedOccurrences { get; set; }
    ObjectCollection AdditionalIncludedOccurrences { get; set; }
    object Application { get; }
    bool BreakLink { get; set; }
    bool CreateIndependentBodiesOnFailedBoolean { get; set; }
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    EnvelopesReplaceStyleEnum EnvelopesReplaceStyle { get; set; }
    string FullFileName { get; }
    bool IsAssociativeDesignView { get; set; }
    bool LinkFaceColorFromSource { get; set; }
    ShrinkwrapComponent Parent { get; }
    ObjectCollection PreservedFeatures { get; set; }
    bool RemoveAllInternalVoids { get; set; }
    double RemoveChamfersDistanceRange { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveChamfersStyle { get; set; }
    double RemoveEmbossMaxHeightRange { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveEmbossesStyle { get; set; }
    double RemoveFilletsRadiusRange { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveFilletsStyle { get; set; }
    double RemoveHolesDiameterRange { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveHolesStyle { get; set; }
    bool RemoveInternalParts { get; set; }
    bool RemovePartsBySize { get; set; }
    double RemovePartsSize { get; set; }
    double RemovePocketsMaxDepthRange { get; set; }
    ShrinkwrapRemoveStyleEnum RemovePocketsStyle { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveTunnelsStyle { get; set; }
    bool RenameComponent { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    ShrinkwrapDefinition Copy();
}
```

6 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ShrinkwrapComponent](../objects/ShrinkwrapComponent.md).Definition, [ShrinkwrapComponentProxy](../objects/ShrinkwrapComponentProxy.md).Definition, [ShrinkwrapComponents](../objects/ShrinkwrapComponents.md).CreateDefinition, [ShrinkwrapDefinition](../objects/ShrinkwrapDefinition.md).Copy

**Referenced types:** [DerivedComponentStyleEnum](../enums/DerivedComponentStyleEnum.md), [EnvelopesReplaceStyleEnum](../enums/EnvelopesReplaceStyleEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ShrinkwrapComponent](../objects/ShrinkwrapComponent.md), [ShrinkwrapRemoveStyleEnum](../enums/ShrinkwrapRemoveStyleEnum.md)

