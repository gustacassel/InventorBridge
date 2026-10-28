# Style

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.Styles.Item[…]`

```csharp
interface Style
{
    // Properties
    object Application { get; }
    string Comments { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    string Name { get; set; }
    object Parent { get; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void UpdateFromGlobal();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BalloonStyle](../objects/BalloonStyle.md).ConvertToLocal, [BalloonStyle](../objects/BalloonStyle.md).Copy, [CentermarkStyle](../objects/CentermarkStyle.md).ConvertToLocal, [CentermarkStyle](../objects/CentermarkStyle.md).Copy, [DimensionStyle](../objects/DimensionStyle.md).ConvertToLocal, [DimensionStyle](../objects/DimensionStyle.md).Copy, [DrawingStandardStyle](../objects/DrawingStandardStyle.md).ConvertToLocal, [DrawingStandardStyle](../objects/DrawingStandardStyle.md).Copy, [EdgeSymbolStyle](../objects/EdgeSymbolStyle.md).ConvertToLocal, [EdgeSymbolStyle](../objects/EdgeSymbolStyle.md).Copy, [FeatureControlFrameStyle](../objects/FeatureControlFrameStyle.md).ConvertToLocal, [FeatureControlFrameStyle](../objects/FeatureControlFrameStyle.md).Copy, [HoleTableStyle](../objects/HoleTableStyle.md).ConvertToLocal, [HoleTableStyle](../objects/HoleTableStyle.md).Copy, [Layer](../objects/Layer.md).ConvertToLocal, [Layer](../objects/Layer.md).Copy, [LeaderStyle](../objects/LeaderStyle.md).ConvertToLocal, [LeaderStyle](../objects/LeaderStyle.md).Copy, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).ConvertToLocal, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).Copy, [PartsListStyle](../objects/PartsListStyle.md).ConvertToLocal, [PartsListStyle](../objects/PartsListStyle.md).Copy, [RevisionTableStyle](../objects/RevisionTableStyle.md).ConvertToLocal, [RevisionTableStyle](../objects/RevisionTableStyle.md).Copy, [SheetMetalStyle](../objects/SheetMetalStyle.md).ConvertToLocal, [SheetMetalStyle](../objects/SheetMetalStyle.md).Copy, [Style](../objects/Style.md).ConvertToLocal, [Style](../objects/Style.md).Copy, [Styles](../objects/Styles.md).Item, [SurfaceTextureStyle](../objects/SurfaceTextureStyle.md).ConvertToLocal, [SurfaceTextureStyle](../objects/SurfaceTextureStyle.md).Copy, [TableStyle](../objects/TableStyle.md).ConvertToLocal, [TableStyle](../objects/TableStyle.md).Copy, [TextStyle](../objects/TextStyle.md).ConvertToLocal, [TextStyle](../objects/TextStyle.md).Copy, [TransitionSymbolStyle](../objects/TransitionSymbolStyle.md).ConvertToLocal, [TransitionSymbolStyle](../objects/TransitionSymbolStyle.md).Copy, [UnfoldMethod](../objects/UnfoldMethod.md).ConvertToLocal, [UnfoldMethod](../objects/UnfoldMethod.md).Copy, [ViewAnnotationStyle](../objects/ViewAnnotationStyle.md).ConvertToLocal and 3 more (see `members.tsv`)

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md)

