# AnnotationPlaneDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.AnnotationPlanes.Item[…].Definition`

```csharp
interface AnnotationPlaneDefinition
{
    // Properties
    object Application { get; }
    Point Origin { get; }
    AnnotationPlane Parent { get; }
    object PlanarEntity { get; }
    Plane Plane { get; }
    Matrix Transformation { get; }
    ObjectTypeEnum Type { get; }
    Line XAxis { get; }
    object XAxisEntity { get; set; }
    double XAxisRotation { get; set; }
    // Methods
    Point AnnotationPlaneToModel(Point2d AnnotationPlaneCoordinate);
    AnnotationPlaneDefinition Copy();
    Point2d ModelToAnnotationPlane(Point ModelCoordinate);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md).AnnotationPlaneDefinition, [AnnotationPlane](../objects/AnnotationPlane.md).Definition, [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md).Copy, [AnnotationPlaneDefinitionsEnumerator](../objects/AnnotationPlaneDefinitionsEnumerator.md).Item, [AnnotationPlaneProxy](../objects/AnnotationPlaneProxy.md).Definition, [DiameterModelDimensionDefinition](../objects/DiameterModelDimensionDefinition.md).AnnotationPlaneDefinition, [LinearModelDimensionDefinition](../objects/LinearModelDimensionDefinition.md).AnnotationPlaneDefinition, [ModelAnnotations](../objects/ModelAnnotations.md).CreateAnnotationPlaneDefinitionUsingPlane, [ModelDatumIdentifierDefinition](../objects/ModelDatumIdentifierDefinition.md).AnnotationPlaneDefinition, [ModelDimensionDefinition](../objects/ModelDimensionDefinition.md).AnnotationPlaneDefinition, [ModelFeatureControlFrameDefinition](../objects/ModelFeatureControlFrameDefinition.md).AnnotationPlaneDefinition, [ModelGeneralNoteDefinition](../objects/ModelGeneralNoteDefinition.md).AnnotationPlaneDefinition, [ModelHoleThreadNoteDefinition](../objects/ModelHoleThreadNoteDefinition.md).AnnotationPlaneDefinition, [ModelLeaderNoteDefinition](../objects/ModelLeaderNoteDefinition.md).AnnotationPlaneDefinition, [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md).AnnotationPlaneDefinition, [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md).AnnotationPlaneDefinition, [RadiusModelDimensionDefinition](../objects/RadiusModelDimensionDefinition.md).AnnotationPlaneDefinition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [Line](../objects/Line.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Plane](../objects/Plane.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md)

