# Layer

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.Layers.Item[…]`

```csharp
interface Layer
{
    // Properties
    object Application { get; }
    bool AutomaticColor { get; set; }
    Color Color { get; set; }
    string Comments { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    string Name { get; set; }
    object Parent { get; }
    bool Plot { get; set; }
    bool ScaleByLineWeight { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    bool Visible { get; set; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void UpdateFromGlobal();
}
```

11 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularGeneralDimension](../objects/AngularGeneralDimension.md).Layer, [AutoCADBlock](../objects/AutoCADBlock.md).Layer, [Balloon](../objects/Balloon.md).Layer, [BaselineDimensionSet](../objects/BaselineDimensionSet.md).Layer, [BendNote](../objects/BendNote.md).Layer, [BreakOperation](../objects/BreakOperation.md).Layer, [Centerline](../objects/Centerline.md).Layer, [Centermark](../objects/Centermark.md).Layer, [ChainDimensionSet](../objects/ChainDimensionSet.md).Layer, [ChamferNote](../objects/ChamferNote.md).Layer, [CustomTable](../objects/CustomTable.md).Layer, [DetailDrawingView](../objects/DetailDrawingView.md).BoundaryLayer, [DiameterGeneralDimension](../objects/DiameterGeneralDimension.md).Layer, [DrawingCurveSegment](../objects/DrawingCurveSegment.md).Layer, [DrawingDimension](../objects/DrawingDimension.md).Layer, [DrawingNote](../objects/DrawingNote.md).Layer, [DrawingViewHatchRegion](../objects/DrawingViewHatchRegion.md).Layer, [DrawingViewLabel](../objects/DrawingViewLabel.md).Layer, [DrawingWeldingSymbol](../objects/DrawingWeldingSymbol.md).Layer, [EdgeSymbolDefinition](../objects/EdgeSymbolDefinition.md).Layer, [FeatureControlFrame](../objects/FeatureControlFrame.md).Layer, [GeneralDimension](../objects/GeneralDimension.md).Layer, [GeneralNote](../objects/GeneralNote.md).Layer, [HoleTable](../objects/HoleTable.md).Layer, [HoleTag](../objects/HoleTag.md).Layer, [HoleThreadNote](../objects/HoleThreadNote.md).Layer, [LayersEnumerator](../objects/LayersEnumerator.md).Item, [LeaderNote](../objects/LeaderNote.md).Layer, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).Layer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).AngularDimensionLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).AuxiliaryViewLineLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BalloonLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BaselineDimensionLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BendNoteLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BendTableLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BendTagLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BorderGeometryLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BorderTextLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).CenterOfGravityLayer, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).CenterlineLayer and 83 more (see `members.tsv`)

**Referenced types:** [Color](../objects/Color.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md)

