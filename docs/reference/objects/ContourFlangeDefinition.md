# ContourFlangeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (ContourFlangeFeature).Definition`

```csharp
interface ContourFlangeDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    object Application { get; }
    bool ApplyAutoMitering { get; set; }
    EdgeCollection BendEdges { get; set; } // since 2026
    BendExtensionTypeEnum BendExtensionType { get; set; } // since 2026
    BendOptions BendOptions { get; set; }
    object BendRadius { get; set; }
    int ContourFlangeEdgeSetCount { get; } // since 2026
    CornerOptions CornerOptions { get; set; }
    PartFeatureExtent DistanceWidthExtentTwo { get; }
    PartFeatureExtentDirectionEnum ExtentDirection { get; set; }
    bool IsDistanceWidthExtentAsymmetric { get; }
    bool IsUnfoldMethodOverridden { get; set; }
    object MiterGap { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    ContourFlangeFeature Parent { get; }
    Path Path { get; set; }
    SheetMetalStyle SheetMetalRule { get; set; }
    ObjectTypeEnum Type { get; }
    UnfoldMethod UnfoldMethod { get; set; }
    bool UseDefaultSheetMetalRule { get; set; }
    PartFeatureExtent WidthExtent { get; } // since 2026
    PartFeatureExtentEnum WidthExtentType { get; } // since 2026
    bool WidthExtentsFromSketchPlane { get; } // since 2026
    // Methods
    FlangeEdgeSet AddContourFlangeEdgeSet(EdgeCollection Edges); // since 2026
    FlangeEdgeSet ContourFlangeEdgeSetItem(int Index); // since 2026
    ContourFlangeDefinition Copy();
    void SetDistanceExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection);
    void SetDistanceWidthExtentTwo(object Distance);
    void SetFromToExtent(object FromEntity, object ToEntity); // since 2026
    void SetToExtent(object ToEntity); // since 2026
}
```

16 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).Copy, [ContourFlangeFeature](../objects/ContourFlangeFeature.md).Definition, [ContourFlangeFeatureProxy](../objects/ContourFlangeFeatureProxy.md).Definition, [ContourFlangeFeatures](../objects/ContourFlangeFeatures.md).CreateDefinition

**Referenced types:** [BendExtensionTypeEnum](../enums/BendExtensionTypeEnum.md), [BendOptions](../objects/BendOptions.md), [ContourFlangeFeature](../objects/ContourFlangeFeature.md), [CornerOptions](../objects/CornerOptions.md), [EdgeCollection](../objects/EdgeCollection.md), [FlangeEdgeSet](../objects/FlangeEdgeSet.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Path](../objects/Path.md), [SheetMetalStyle](../objects/SheetMetalStyle.md), [UnfoldMethod](../objects/UnfoldMethod.md)

