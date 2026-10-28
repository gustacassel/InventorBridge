# RevisionCloudDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionClouds.Item[…].Definition`

```csharp
interface RevisionCloudDefinition
{
    // Properties
    object Application { get; }
    RevisionCloudControlPoints ControlPoints { get; }
    bool Inverted { get; set; }
    Layer Layer { get; set; }
    double MaximumArcRadius { get; set; } // since 2025
    double MinimumArcRadius { get; set; } // since 2025
    RevisionCloud Parent { get; }
    bool SetValuesAsDefault { get; set; } // since 2025
    ObjectTypeEnum Type { get; }
    // Methods
    RevisionCloudDefinition Copy();
}
```

**Returned by:** [RevisionCloud](../objects/RevisionCloud.md).Definition, [RevisionCloudControlPoint](../objects/RevisionCloudControlPoint.md).Parent, [RevisionCloudDefinition](../objects/RevisionCloudDefinition.md).Copy, [RevisionClouds](../objects/RevisionClouds.md).CreateRevisionCloudDefinition

**Referenced types:** [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevisionCloud](../objects/RevisionCloud.md), [RevisionCloudControlPoints](../objects/RevisionCloudControlPoints.md)

