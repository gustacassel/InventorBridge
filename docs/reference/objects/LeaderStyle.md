# LeaderStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.LeaderStyles.Item[…]`

```csharp
interface LeaderStyle
{
    // Properties
    double AllAroundSymbolDiameter { get; set; }
    object Application { get; }
    double ArrowheadHeight { get; set; }
    double ArrowheadSize { get; set; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    Color Color { get; set; }
    string Comments { get; set; }
    double ExtensionLineOffset { get; set; }
    double ExtensionLineOvershoot { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    string Name { get; set; }
    object Parent { get; }
    bool ScaleToTextHeight { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
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

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BalloonStyle](../objects/BalloonStyle.md).AlternateLeaderStyle, [BalloonStyle](../objects/BalloonStyle.md).LeaderStyle, [DimensionStyle](../objects/DimensionStyle.md).LeaderStyle, [EdgeSymbolStyle](../objects/EdgeSymbolStyle.md).LeaderStyle, [FeatureControlFrameStyle](../objects/FeatureControlFrameStyle.md).LeaderStyle, [LeaderStylesEnumerator](../objects/LeaderStylesEnumerator.md).Item, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).OriginIndicatorStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).SketchedSymbolLeaderStyle, [OriginIndicator](../objects/OriginIndicator.md).LeaderStyle, [RevisionTableStyle](../objects/RevisionTableStyle.md).RevisionTagLeaderStyle, [SketchedSymbol](../objects/SketchedSymbol.md).LeaderStyle, [SurfaceTextureStyle](../objects/SurfaceTextureStyle.md).LeaderStyle, [TransitionSymbolStyle](../objects/TransitionSymbolStyle.md).LeaderStyleForEdgeSelected, [TransitionSymbolStyle](../objects/TransitionSymbolStyle.md).LeaderStyleForFaceSelected, [WeldSymbolStyle](../objects/WeldSymbolStyle.md).LeaderStyle

**Referenced types:** [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [Color](../objects/Color.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md)

