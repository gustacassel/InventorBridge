# MoveDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MoveFeatures.Item[…].Definition`

```csharp
interface MoveDefinition
{
    // Properties
    object Application { get; }
    MoveOperation MoveOperation[int Index] { get; }
    int MoveOperationCount { get; }
    MoveFeature Parent { get; }
    ObjectCollection SurfaceBodies { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    FreeDragMoveOperation AddFreeDrag(object XOffset, object YOffset, object ZOffset);
    MoveAlongRayMoveOperation AddMoveAlongRay(object DirectionEntity, bool UseNaturalEntityDirection, object Offset);
    RotateAboutLineMoveOperation AddRotateAboutAxis(object AxisEntity, bool UseNaturalAxisDirection, object Angle);
    MoveDefinition Copy();
}
```

**Returned by:** [FreeDragMoveOperation](../objects/FreeDragMoveOperation.md).Parent, [MoveAlongRayMoveOperation](../objects/MoveAlongRayMoveOperation.md).Parent, [MoveDefinition](../objects/MoveDefinition.md).Copy, [MoveFeature](../objects/MoveFeature.md).Definition, [MoveFeatureProxy](../objects/MoveFeatureProxy.md).Definition, [MoveFeatures](../objects/MoveFeatures.md).CreateMoveDefinition, [MoveOperation](../objects/MoveOperation.md).Parent, [RotateAboutLineMoveOperation](../objects/RotateAboutLineMoveOperation.md).Parent

**Referenced types:** [FreeDragMoveOperation](../objects/FreeDragMoveOperation.md), [MoveAlongRayMoveOperation](../objects/MoveAlongRayMoveOperation.md), [MoveFeature](../objects/MoveFeature.md), [MoveOperation](../objects/MoveOperation.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RotateAboutLineMoveOperation](../objects/RotateAboutLineMoveOperation.md)

