# Parameter

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.Item[…]`

```csharp
interface Parameter
{
    // Properties
    AttributeSets AttributeSets { get; }
    string Comment { get; set; }
    CustomPropertyFormat CustomPropertyFormat { get; }
    ObjectCollection Dependents { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    ParameterDisplayFormatEnum DisplayFormat { get; set; }
    ObjectCollection DrivenBy { get; }
    bool ExposedAsProperty { get; set; }
    string Expression { get; set; }
    ExpressionList ExpressionList { get; }
    HealthStatusEnum HealthStatus { get; }
    bool InUse { get; }
    bool IsKey { get; set; }
    double ModelValue { get; }
    ModelValueTypeEnum ModelValueType { get; set; }
    string Name { get; set; }
    ParameterTypeEnum ParameterType { get; }
    object Parent { get; }
    int Precision { get; set; }
    Tolerance Tolerance { get; }
    ObjectTypeEnum Type { get; }
    string Units { get; set; }
    object Value { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).Angle, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).Angle, [AngleExtent](../objects/AngleExtent.md).Angle, [AngleiMateDefinition](../objects/AngleiMateDefinition.md).Angle, [AngleiMateDefinitionProxy](../objects/AngleiMateDefinitionProxy.md).Angle, [ArcLengthDimConstraint](../objects/ArcLengthDimConstraint.md).Parameter, [ArcLengthDimConstraintProxy](../objects/ArcLengthDimConstraintProxy.md).Parameter, [BendConstraint](../objects/BendConstraint.md).Radius, [BendConstraintProxy](../objects/BendConstraintProxy.md).Radius, [BendPartFeature](../objects/BendPartFeature.md).InputOne, [BendPartFeature](../objects/BendPartFeature.md).InputTwo, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).InputOne, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).InputTwo, [CenteredWidthExtent](../objects/CenteredWidthExtent.md).Width, [ChamferDefinition](../objects/ChamferDefinition.md).Angle, [ChamferDefinition](../objects/ChamferDefinition.md).Distance, [ChamferDefinition](../objects/ChamferDefinition.md).DistanceOne, [ChamferDefinition](../objects/ChamferDefinition.md).DistanceTwo, [CircularOccurrencePattern](../objects/CircularOccurrencePattern.md).AngleOffset, [CircularOccurrencePattern](../objects/CircularOccurrencePattern.md).ElementCount, [CircularOccurrencePatternProxy](../objects/CircularOccurrencePatternProxy.md).AngleOffset, [CircularOccurrencePatternProxy](../objects/CircularOccurrencePatternProxy.md).ElementCount, [CoilFeature](../objects/CoilFeature.md).EndFlatAngle, [CoilFeature](../objects/CoilFeature.md).EndTransitionAngle, [CoilFeature](../objects/CoilFeature.md).StartFlatAngle, [CoilFeature](../objects/CoilFeature.md).StartTransitionAngle, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).EndFlatAngle, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).EndTransitionAngle, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).StartFlatAngle, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).StartTransitionAngle, [ConstraintLimits](../objects/ConstraintLimits.md).Maximum, [ConstraintLimits](../objects/ConstraintLimits.md).Minimum, [CustomParameterGroup](../objects/CustomParameterGroup.md).Item, [CustomPropertyFormat](../objects/CustomPropertyFormat.md).Parent, [CutAcrossBendsExtent](../objects/CutAcrossBendsExtent.md).Distance, [DerivedParameter](../objects/DerivedParameter.md).ReferencedEntity, [DiameterDimConstraint](../objects/DiameterDimConstraint.md).Parameter, [DiameterDimConstraintProxy](../objects/DiameterDimConstraintProxy.md).Parameter, [DimensionConstraint](../objects/DimensionConstraint.md).Parameter, [DimensionConstraint3D](../objects/DimensionConstraint3D.md).Parameter and 177 more (see `members.tsv`)

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [CustomPropertyFormat](../objects/CustomPropertyFormat.md), [ExpressionList](../objects/ExpressionList.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelValueTypeEnum](../enums/ModelValueTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ParameterDisplayFormatEnum](../enums/ParameterDisplayFormatEnum.md), [ParameterTypeEnum](../enums/ParameterTypeEnum.md), [Tolerance](../objects/Tolerance.md)

