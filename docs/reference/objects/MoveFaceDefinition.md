# MoveFaceDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MoveFaceFeatures.Item[…].Definition`

```csharp
interface MoveFaceDefinition
{
    // Properties
    object Application { get; }
    bool AutomaticBlending { get; set; }
    FaceCollection Faces { get; set; }
    MoveFaceTypeEnum MoveFaceType { get; }
    object MoveFaceTypeDefinition { get; }
    MoveFaceFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MoveFaceDefinition Copy();
    void SetDirectionAndDistanceMoveType(object Distance, object Direction, bool DirectionReversed = false);
    void SetFreeMoveType(Matrix Transformation);
    void SetPlanarMoveType(object PointOne, object PointTwo, object Plane = Missing);
}
```

**Returned by:** [DirectionAndDistanceMoveDefinition](../objects/DirectionAndDistanceMoveDefinition.md).Parent, [FreeMoveDefinition](../objects/FreeMoveDefinition.md).Parent, [MoveFaceDefinition](../objects/MoveFaceDefinition.md).Copy, [MoveFaceFeature](../objects/MoveFaceFeature.md).Definition, [MoveFaceFeatureProxy](../objects/MoveFaceFeatureProxy.md).Definition, [MoveFaceFeatures](../objects/MoveFaceFeatures.md).CreateDefinition, [PlanarMoveDefinition](../objects/PlanarMoveDefinition.md).Parent

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [Matrix](../objects/Matrix.md), [MoveFaceFeature](../objects/MoveFaceFeature.md), [MoveFaceTypeEnum](../enums/MoveFaceTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

