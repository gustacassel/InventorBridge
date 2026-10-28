# ObjectDefaultsStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.ObjectDefaultsStyles.Item[…]`

```csharp
interface ObjectDefaultsStyle
{
    // Properties
    Layer AngularDimensionLayer { get; set; }
    DimensionStyle AngularDimensionStyle { get; set; }
    object Application { get; }
    Layer AuxiliaryViewLineLayer { get; set; } // since 2025
    ViewAnnotationStyle AuxiliaryViewLineStyle { get; set; } // since 2025
    Layer BalloonLayer { get; set; }
    BalloonStyle BalloonStyle { get; set; }
    Layer BaselineDimensionLayer { get; set; }
    DimensionStyle BaselineDimensionStyle { get; set; }
    Layer BendNoteLayer { get; set; }
    DimensionStyle BendNoteStyle { get; set; }
    Layer BendTableLayer { get; set; }
    TableStyle BendTableStyle { get; set; }
    Layer BendTagLayer { get; set; }
    DimensionStyle BendTagStyle { get; set; }
    Layer BorderGeometryLayer { get; set; }
    Layer BorderTextLayer { get; set; }
    TextStyle BorderTextStyle { get; set; }
    Layer CenterOfGravityLayer { get; set; }
    CentermarkStyle CenterOfGravityStyle { get; set; }
    Layer CenterlineLayer { get; set; }
    CentermarkStyle CenterlineStyle { get; set; }
    Layer CentermarkLayer { get; set; }
    CentermarkStyle CentermarkStyle { get; set; }
    Layer ChainDimensionLayer { get; set; }
    DimensionStyle ChainDimensionStyle { get; set; }
    Layer ChamferNoteLayer { get; set; }
    DimensionStyle ChamferNoteStyle { get; set; }
    string Comments { get; set; }
    Layer ConfigurationTableLayer { get; set; }
    TableStyle ConfigurationTableStyle { get; set; }
    Layer CropCutLineLayer { get; set; } // since 2025
    ViewAnnotationStyle CropCutLineStyle { get; set; } // since 2025
    Layer DetailCutLineLayer { get; set; } // since 2025
    Layer DetailViewCalloutLayer { get; set; } // since 2025
    ViewAnnotationStyle DetailViewCalloutStyle { get; set; } // since 2025
    Layer DiameterDimensionLayer { get; set; }
    DimensionStyle DiameterDimensionStyle { get; set; }
    Layer EdgeSymbolLayer { get; set; }
    EdgeSymbolStyle EdgeSymbolStyle { get; set; }
    Layer FeatureControlFrameLayer { get; set; }
    FeatureControlFrameStyle FeatureControlFrameStyle { get; set; }
    Layer GeneralNoteLayer { get; set; }
    TextStyle GeneralNoteStyle { get; set; }
    Layer HoleNoteLayer { get; set; }
    DimensionStyle HoleNoteStyle { get; set; }
    Layer HoleTableLayer { get; set; }
    HoleTableStyle HoleTableStyle { get; set; }
    Layer HoleTagLayer { get; set; }
    DimensionStyle HoleTagStyle { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    Layer LeaderTextLayer { get; set; }
    DimensionStyle LeaderTextStyle { get; set; }
    Layer LinearDimensionLayer { get; set; }
    DimensionStyle LinearDimensionStyle { get; set; }
    string Name { get; set; }
    Layer OrdinateDimensionLayer { get; set; }
    Layer OrdinateDimensionSetLayer { get; set; }
    DimensionStyle OrdinateDimensionStyle { get; set; }
    DimensionStyle OrdinateSetDimensionStyle { get; set; }
    Layer OriginIndicatorLayer { get; set; }
    LeaderStyle OriginIndicatorStyle { get; set; }
    object Parent { get; }
    Layer PartsListLayer { get; set; }
    PartsListStyle PartsListStyle { get; set; }
    Layer PunchNoteLayer { get; set; }
    DimensionStyle PunchNoteStyle { get; set; }
    Layer RadialDimensionLayer { get; set; }
    DimensionStyle RadialDimensionStyle { get; set; }
    Layer RevisionTableLayer { get; set; }
    RevisionTableStyle RevisionTableStyle { get; set; }
    Layer RevisionTagLayer { get; set; }
    RevisionTableStyle RevisionTagStyle { get; set; }
    Layer SectionBreakLineLayer { get; set; } // since 2025
    Layer SectionViewLineLayer { get; set; } // since 2025
    ViewAnnotationStyle SectionViewLineStyle { get; set; } // since 2025
    Layer SheetMetalPunchLayer { get; set; }
    CentermarkStyle SheetMetalPunchStyle { get; set; }
    Layer Sketch3DGeometryLayer { get; set; }
    Layer SketchGeometryLayer { get; set; }
    Layer SketchTextLayer { get; set; }
    TextStyle SketchTextStyle { get; set; }
    Layer SketchedSymbolGeometryLayer { get; set; }
    Layer SketchedSymbolLeaderLayer { get; set; }
    LeaderStyle SketchedSymbolLeaderStyle { get; set; }
    Layer SketchedSymbolTextLayer { get; set; }
    TextStyle SketchedSymbolTextStyle { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    Layer SurfaceTextureLayer { get; set; }
    SurfaceTextureStyle SurfaceTextureStyle { get; set; }
    Layer TableLayer { get; set; }
    TableStyle TableStyle { get; set; }
    Layer ThreadNoteLayer { get; set; }
    DimensionStyle ThreadNoteStyle { get; set; }
    Layer TitleBlockGeometryLayer { get; set; }
    Layer TitleBlockTextLayer { get; set; }
    TextStyle TitleBlockTextStyle { get; set; }
    Layer TransitionSymbolLayer { get; set; } // since 2025
    TransitionSymbolStyle TransitionSymbolStyle { get; set; } // since 2025
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    Layer ViewLabelLayer { get; set; }
    TextStyle ViewLabelStyle { get; set; }
    Layer WeldSymbolLayer { get; set; }
    WeldSymbolStyle WeldSymbolStyle { get; set; }
    Layer WorkAxisLayer { get; set; }
    CentermarkStyle WorkAxisStyle { get; set; }
    Layer WorkPlaneLayer { get; set; }
    CentermarkStyle WorkPlaneStyle { get; set; }
    Layer WorkPointLayer { get; set; }
    CentermarkStyle WorkPointStyle { get; set; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void UpdateFromGlobal();
}
```

11 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStandardStyle](../objects/DrawingStandardStyle.md).ActiveObjectDefaults, [ObjectDefaultsStylesEnumerator](../objects/ObjectDefaultsStylesEnumerator.md).Item

**Referenced types:** [BalloonStyle](../objects/BalloonStyle.md), [CentermarkStyle](../objects/CentermarkStyle.md), [DimensionStyle](../objects/DimensionStyle.md), [EdgeSymbolStyle](../objects/EdgeSymbolStyle.md), [FeatureControlFrameStyle](../objects/FeatureControlFrameStyle.md), [HoleTableStyle](../objects/HoleTableStyle.md), [Layer](../objects/Layer.md), [LeaderStyle](../objects/LeaderStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListStyle](../objects/PartsListStyle.md), [RevisionTableStyle](../objects/RevisionTableStyle.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [SurfaceTextureStyle](../objects/SurfaceTextureStyle.md), [TableStyle](../objects/TableStyle.md), [TextStyle](../objects/TextStyle.md), [TransitionSymbolStyle](../objects/TransitionSymbolStyle.md), [ViewAnnotationStyle](../objects/ViewAnnotationStyle.md), [WeldSymbolStyle](../objects/WeldSymbolStyle.md)

