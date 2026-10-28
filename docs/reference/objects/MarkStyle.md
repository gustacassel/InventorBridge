# MarkStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).MarkStyles.Item[…]`

```csharp
interface MarkStyle
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Color BackLayerColor { get; set; }
    LineTypeEnum BackLayerLineType { get; set; }
    double BackLayerLineWeight { get; set; }
    string BackLayerName { get; set; }
    Color FrontLayerColor { get; set; }
    LineTypeEnum FrontLayerLineType { get; set; }
    double FrontLayerLineWeight { get; set; }
    string FrontLayerName { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    MarkTypeEnum MarkDepthType { get; set; }
    MarkTextTypeEnum MarkTextType { get; set; }
    string Name { get; set; }
    object Parent { get; }
    string StrokesFontName { get; set; }
    StyleLocationEnum StyleLocation { get; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    MarkStyle ConvertToLocal();
    MarkStyle Copy(string NewName);
    void Delete();
    void GetBackCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetFrontCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    string[] GetStrokeFontList();
    void SaveToGlobal();
    void SetBackCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void SetFrontCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void UpdateFromGlobal();
}
```

**Returned by:** [MarkGeometrySet](../objects/MarkGeometrySet.md).Style, [MarkStyle](../objects/MarkStyle.md).ConvertToLocal, [MarkStyle](../objects/MarkStyle.md).Copy, [MarkStylesEnumerator](../objects/MarkStylesEnumerator.md).Item, [PartDocument](../objects/PartDocument.md).ActiveMarkStyle

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Color](../objects/Color.md), [LineTypeEnum](../enums/LineTypeEnum.md), [MarkTextTypeEnum](../enums/MarkTextTypeEnum.md), [MarkTypeEnum](../enums/MarkTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [StyleLocationEnum](../enums/StyleLocationEnum.md)

