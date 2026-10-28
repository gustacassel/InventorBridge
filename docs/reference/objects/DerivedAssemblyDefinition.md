# DerivedAssemblyDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedAssemblyComponents.Item[…].Definition`

```csharp
interface DerivedAssemblyDefinition
{
    // Properties
    string ActiveDesignViewRepresentation { get; set; }
    string ActiveModelState { get; set; }
    string ActivePositionalRepresentation { get; set; }
    object Application { get; }
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    DerivedComponentOptionEnum IncludeAllTopLevelParameters { get; set; }
    DerivedComponentOptionEnum IncludeAllTopLevelSketches { get; set; }
    DerivedComponentOptionEnum IncludeAllTopLevelWorkFeatures { get; set; }
    DerivedComponentOptionEnum IncludeAllTopLeveliMateDefinitions { get; set; }
    DerivedComponentOptionEnum InclusionOption { get; set; }
    bool IndependentSolidsOnFailedBoolean { get; set; }
    bool IsAssociativeDesignView { get; set; }
    bool LinkFaceColorFromSource { get; set; }
    bool LinkSketchFormattingFromSource { get; set; }
    DerivedPartMirrorPlaneEnum MirrorPlane { get; set; }
    DerivedAssemblyOccurrences Occurrences { get; }
    bool ReducedMemoryMode { get; set; }
    bool RemoveInternalVoids { get; set; }
    double ScaleFactor { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseOrientedMinimumBoundingBox { get; set; }
    // Methods
    void GetHolePatchingOptions(out DerivedHolePatchEnum HolePatchType, out double MinimumPerimeter, out double MaximumPerimeter, out EdgeCollection Reserved);
    void GetRemoveBySizeOptions(out bool Enable, out int SizeRatioPercentage);
    void GetRemoveByVisibilityOptions(out DerivedGeometryRemovalEnum GeometryToRemove, out int VisibilityPercentage, out bool IgnoreSurfaceFeatures);
    void IncludeAllParameters();
    void IncludeAllSketches();
    void IncludeAllWorkFeatures();
    void SetHolePatchingOptions(DerivedHolePatchEnum HolePatchType, double MinimumPerimeter = 0, double MaximumPerimeter = 0, object Reserved = Missing);
    void SetRemoveBySizeOptions(bool Enable, int SizeRatioPercentage = 1);
    void SetRemoveByVisibilityOptions(DerivedGeometryRemovalEnum GeometryToRemove, int VisibilityPercentage = 0, bool IgnoreSurfaceFeatures = true);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedAssemblyComponent](../objects/DerivedAssemblyComponent.md).Definition, [DerivedAssemblyComponentProxy](../objects/DerivedAssemblyComponentProxy.md).Definition, [DerivedAssemblyComponents](../objects/DerivedAssemblyComponents.md).CreateDefinition

**Referenced types:** [DerivedAssemblyOccurrences](../objects/DerivedAssemblyOccurrences.md), [DerivedComponentOptionEnum](../enums/DerivedComponentOptionEnum.md), [DerivedComponentStyleEnum](../enums/DerivedComponentStyleEnum.md), [DerivedGeometryRemovalEnum](../enums/DerivedGeometryRemovalEnum.md), [DerivedHolePatchEnum](../enums/DerivedHolePatchEnum.md), [DerivedPartMirrorPlaneEnum](../enums/DerivedPartMirrorPlaneEnum.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

