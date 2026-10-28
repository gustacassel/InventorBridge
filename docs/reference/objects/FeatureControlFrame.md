# FeatureControlFrame

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.FeatureControlFrames.Item[…]`

```csharp
interface FeatureControlFrame
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    string DatumIdentifier { get; set; }
    FeatureControlFrameRows FeatureControlFrameRows { get; set; }
    Layer Layer { get; set; }
    Leader Leader { get; }
    bool MergeSymbolOverridden { get; set; }
    string Notes { get; set; }
    bool OverrideMergeSymbol { get; set; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    FeatureControlFrameProfileTypeEnum ProfileType { get; set; }
    double Rotation { get; set; }
    FeatureControlFrameStyle Style { get; set; }
    string TopNotes { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AuxiliaryFeatureIndicator](../objects/AuxiliaryFeatureIndicator.md).Parent, [FeatureControlFrameRow](../objects/FeatureControlFrameRow.md).Parent, [FeatureControlFrames](../objects/FeatureControlFrames.md).Add, [FeatureControlFrames](../objects/FeatureControlFrames.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [FeatureControlFrameProfileTypeEnum](../enums/FeatureControlFrameProfileTypeEnum.md), [FeatureControlFrameRows](../objects/FeatureControlFrameRows.md), [FeatureControlFrameStyle](../objects/FeatureControlFrameStyle.md), [Layer](../objects/Layer.md), [Leader](../objects/Leader.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md)

