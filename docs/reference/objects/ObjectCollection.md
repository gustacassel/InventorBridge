# ObjectCollection

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ColorSchemes.Item[…].DisplaySeparateColors`

```csharp
interface ObjectCollection
{
    // Properties
    int Count { get; }
    object Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(object Object);
    void Clear();
    void Remove(int Index);
    void RemoveByObject(object Object);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ArcLengthDimConstraint](../objects/ArcLengthDimConstraint.md).AnchorPoints, [ArcLengthDimConstraintProxy](../objects/ArcLengthDimConstraintProxy.md).AnchorPoints, [AttributeManager](../objects/AttributeManager.md).FindObjects, [AttributeManager](../objects/AttributeManager.md).FindObjectsByPattern, [BIMCableTrayConnectorDefinition](../objects/BIMCableTrayConnectorDefinition.md).Geometry, [BIMComponentDescription](../objects/BIMComponentDescription.md).ModelProperties, [BIMConduitConnectorDefinition](../objects/BIMConduitConnectorDefinition.md).Geometry, [BIMConnectorDefinition](../objects/BIMConnectorDefinition.md).Geometry, [BIMDuctConnectorDefinition](../objects/BIMDuctConnectorDefinition.md).Geometry, [BIMElectricalConnectorDefinition](../objects/BIMElectricalConnectorDefinition.md).Geometry, [BIMPipeConnectorDefinition](../objects/BIMPipeConnectorDefinition.md).Geometry, [BossSet](../objects/BossSet.md).Centers, [BoundaryPatchDefinition](../objects/BoundaryPatchDefinition.md).GuideRails, [CircularOccurrencePattern](../objects/CircularOccurrencePattern.md).ParentComponents, [CircularOccurrencePatternProxy](../objects/CircularOccurrencePatternProxy.md).ParentComponents, [CircularPatternFeatureDefinition](../objects/CircularPatternFeatureDefinition.md).AffectedBodies, [CircularPatternFeatureDefinition](../objects/CircularPatternFeatureDefinition.md).AffectedOccurrences, [CircularPatternFeatureDefinition](../objects/CircularPatternFeatureDefinition.md).ParentFeatures, [ClientFeature](../objects/ClientFeature.md).HiddenParameters, [ClientFeatureDefinition](../objects/ClientFeatureDefinition.md).FeatureInputs, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).HiddenParameters, [ColorScheme](../objects/ColorScheme.md).DisplaySeparateColors, [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).AffectedBodies, [DerivedParameter](../objects/DerivedParameter.md).Dependents, [DerivedParameter](../objects/DerivedParameter.md).DrivenBy, [DerivedParameterTable](../objects/DerivedParameterTable.md).LinkedParameters, [DiameterDimConstraint](../objects/DiameterDimConstraint.md).AnchorPoints, [DiameterDimConstraintProxy](../objects/DiameterDimConstraintProxy.md).AnchorPoints, [DimensionConstraint](../objects/DimensionConstraint.md).AnchorPoints, [DimensionConstraint3D](../objects/DimensionConstraint3D.md).AnchorPoints, [DraftAnalysis](../objects/DraftAnalysis.md).Faces, [DrawingStandardStyle](../objects/DrawingStandardStyle.md).GetAvailableStyles, [DrawingViewHatchArea](../objects/DrawingViewHatchArea.md).BoundaryGeometries, [DrawingViewHatchRegion](../objects/DrawingViewHatchRegion.md).BoundaryGeometries, [EllipseRadiusDimConstraint](../objects/EllipseRadiusDimConstraint.md).AnchorPoints, [EllipseRadiusDimConstraintProxy](../objects/EllipseRadiusDimConstraintProxy.md).AnchorPoints, [ExtrudeDefinition](../objects/ExtrudeDefinition.md).AffectedBodies, [ExtrudeDefinition](../objects/ExtrudeDefinition.md).AffectedOccurrences, [Face](../objects/Face.md).ThreadInfos, [FaceFeatureDefinition](../objects/FaceFeatureDefinition.md).AffectedBodies and 122 more (see `members.tsv`)

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

