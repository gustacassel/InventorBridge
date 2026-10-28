# RevolveFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RevolveFeatures`

```csharp
interface RevolveFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    RevolveFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RevolveFeature AddByAngle(Profile Profile, object AxisEntity, object Angle, PartFeatureExtentDirectionEnum ExtentDirection, PartFeatureOperationEnum Operation);
    RevolveFeature AddByFromToExtent(Profile Profile, object AxisEntity, object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace, PartFeatureExtentDirectionEnum ExtentDirection, bool MinimumSolution, PartFeatureOperationEnum Operation);
    RevolveFeature AddByToFaceExtent(Profile Profile, object AxisEntity, object ToFace, bool ExtendToFace, PartFeatureExtentDirectionEnum ExtentDirection, bool MinimumSolution, PartFeatureOperationEnum Operation);
    RevolveFeature AddByToNextExtent(Profile Profile, object AxisEntity, PartFeatureExtentDirectionEnum ExtentDirection, SurfaceBody Terminator, PartFeatureOperationEnum Operation);
    RevolveFeature AddFull(Profile Profile, object AxisEntity, PartFeatureOperationEnum Operation);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).RevolveFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).RevolveFeatures, [PartFeatures](../objects/PartFeatures.md).RevolveFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).RevolveFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Profile](../objects/Profile.md), [RevolveFeature](../objects/RevolveFeature.md), [SurfaceBody](../objects/SurfaceBody.md)

