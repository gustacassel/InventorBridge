# Tolerance

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.Item[…].Tolerance`

```csharp
interface Tolerance
{
    // Properties
    string HoleTolerance { get; }
    double Lower { get; }
    object Parent { get; }
    string ShaftTolerance { get; }
    ToleranceTypeEnum ToleranceType { get; }
    ObjectTypeEnum Type { get; }
    double Upper { get; }
    // Methods
    void SetToBasic();
    void SetToDefault();
    void SetToDeviation(object UpperTolerance, object LowerTolerance);
    void SetToFits(ToleranceTypeEnum FitsToleranceType, string HoleTolerance, string ShaftTolerance);
    void SetToLimits(ToleranceTypeEnum LimitsToleranceType, object UpperTolerance, object LowerTolerance);
    void SetToMax();
    void SetToMin();
    void SetToReference();
    void SetToSymmetric(object Tolerance);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularGeneralDimension](../objects/AngularGeneralDimension.md).Tolerance, [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md).Tolerance, [DerivedParameter](../objects/DerivedParameter.md).Tolerance, [DiameterGeneralDimension](../objects/DiameterGeneralDimension.md).Tolerance, [DiameterModelDimensionDefinition](../objects/DiameterModelDimensionDefinition.md).Tolerance, [DimensionStyle](../objects/DimensionStyle.md).Tolerance, [DrawingDimension](../objects/DrawingDimension.md).Tolerance, [FinishParameter](../objects/FinishParameter.md).Tolerance, [GeneralDimension](../objects/GeneralDimension.md).Tolerance, [HoleThreadNote](../objects/HoleThreadNote.md).Tolerance, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).Tolerance, [LinearModelDimensionDefinition](../objects/LinearModelDimensionDefinition.md).Tolerance, [MiniToolbarValueEditor](../objects/MiniToolbarValueEditor.md).Tolerance, [ModelDimensionDefinition](../objects/ModelDimensionDefinition.md).Tolerance, [ModelHoleThreadNoteDefinition](../objects/ModelHoleThreadNoteDefinition.md).GetHolePropertyTolerance, [ModelParameter](../objects/ModelParameter.md).Tolerance, [OrdinateDimension](../objects/OrdinateDimension.md).Tolerance, [Parameter](../objects/Parameter.md).Tolerance, [RadiusGeneralDimension](../objects/RadiusGeneralDimension.md).Tolerance, [RadiusModelDimensionDefinition](../objects/RadiusModelDimensionDefinition.md).Tolerance, [ReferenceParameter](../objects/ReferenceParameter.md).Tolerance, [TableParameter](../objects/TableParameter.md).Tolerance, [UserParameter](../objects/UserParameter.md).Tolerance

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ToleranceTypeEnum](../enums/ToleranceTypeEnum.md)

