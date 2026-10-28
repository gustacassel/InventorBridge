# GeometryIntent

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Centerlines.Item[…].PatternCenter`

```csharp
interface GeometryIntent
{
    // Properties
    object Application { get; }
    object Geometry { get; }
    object Intent { get; }
    IntentTypeEnum IntentType { get; }
    object Parent { get; }
    Point Point { get; }
    Point2d PointOnSheet { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [AngularGeneralDimension](../objects/AngularGeneralDimension.md).IntentOne, [AngularGeneralDimension](../objects/AngularGeneralDimension.md).IntentThree, [AngularGeneralDimension](../objects/AngularGeneralDimension.md).IntentTwo, [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md).IntentOne, [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md).IntentThree, [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md).IntentTwo, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).CreateGeometryIntent, [AssemblyJointDefinition](../objects/AssemblyJointDefinition.md).OriginOne, [AssemblyJointDefinition](../objects/AssemblyJointDefinition.md).OriginTwo, [BaselineDimensionSet](../objects/BaselineDimensionSet.md).Origin, [Centerline](../objects/Centerline.md).PatternCenter, [DetailDrawingView](../objects/DetailDrawingView.md).AttachPoint, [DiameterGeneralDimension](../objects/DiameterGeneralDimension.md).Intent, [DiameterModelDimensionDefinition](../objects/DiameterModelDimensionDefinition.md).Intent, [FlatPattern](../objects/FlatPattern.md).CreateGeometryIntent, [HoleThreadNote](../objects/HoleThreadNote.md).Intent, [LeaderNode](../objects/LeaderNode.md).AttachedEntity, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).IntentOne, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).IntentThree, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).IntentTwo, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).VirtualArcPosition, [LinearModelDimensionDefinition](../objects/LinearModelDimensionDefinition.md).IntentOne, [LinearModelDimensionDefinition](../objects/LinearModelDimensionDefinition.md).IntentTwo, [ModelDatumIdentifierDefinition](../objects/ModelDatumIdentifierDefinition.md).Intent, [ModelFeatureControlFrameDefinition](../objects/ModelFeatureControlFrameDefinition.md).Intent, [ModelGeneralNoteDefinition](../objects/ModelGeneralNoteDefinition.md).Intent, [ModelHoleThreadNoteDefinition](../objects/ModelHoleThreadNoteDefinition.md).Intent, [ModelLeaderNode](../objects/ModelLeaderNode.md).Intent, [ModelLeaderNoteDefinition](../objects/ModelLeaderNoteDefinition.md).Intent, [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md).Intent, [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md).Intent, [OrdinateDimension](../objects/OrdinateDimension.md).Intent, [OriginIndicator](../objects/OriginIndicator.md).Intent, [PartComponentDefinition](../objects/PartComponentDefinition.md).CreateGeometryIntent, [PunchNote](../objects/PunchNote.md).PunchEdge, [RadiusGeneralDimension](../objects/RadiusGeneralDimension.md).Intent, [RadiusModelDimensionDefinition](../objects/RadiusModelDimensionDefinition.md).Intent, [Sheet](../objects/Sheet.md).CreateGeometryIntent, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).CreateGeometryIntent, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).CreateGeometryIntent

**Referenced types:** [IntentTypeEnum](../enums/IntentTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md)

