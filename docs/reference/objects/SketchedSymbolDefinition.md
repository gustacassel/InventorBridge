# SketchedSymbolDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [TitleBlockDefinition](../objects/TitleBlockDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SketchedSymbolDefinitions.Item[…]`

```csharp
interface SketchedSymbolDefinition
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool IsReferenced { get; }
    string Name { get; set; }
    DrawingDocument Parent { get; }
    DrawingSketch Sketch { get; }
    IPictureDisp Thumbnail { get; } // since 2025
    ObjectTypeEnum Type { get; }
    // Methods
    SketchedSymbolDefinition CopyTo(DrawingDocument TargetDocument, bool ReplaceExisting = false);
    void Delete();
    void Edit(out DrawingSketch Result);
    void ExitEdit(bool SaveChanges = true, object SaveAsName = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToLibrary(object TargetSketchedSymbolDefinitionLibrary, object RetainResourceFolderStructure = Missing, object DestinationFolder = Missing, object ReplaceExisting = Missing);
}
```

**Returned by:** [SketchedSymbol](../objects/SketchedSymbol.md).Definition, [SketchedSymbolDefinition](../objects/SketchedSymbolDefinition.md).CopyTo, [SketchedSymbolDefinitions](../objects/SketchedSymbolDefinitions.md).Add, [SketchedSymbolDefinitions](../objects/SketchedSymbolDefinitions.md).AddFromLibrary, [SketchedSymbolDefinitions](../objects/SketchedSymbolDefinitions.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DrawingDocument](../objects/DrawingDocument.md), [DrawingSketch](../objects/DrawingSketch.md), [IPictureDisp](../objects/IPictureDisp.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

