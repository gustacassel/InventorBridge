# SketchImageProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchImage](../objects/SketchImage.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchImages.Item[…] → (SketchImageProxy)`

```csharp
interface SketchImageProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    SketchEntitiesEnumerator BoundaryGeometry { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    SketchBlock ContainingSketchBlock { get; }
    double Height { get; set; }
    IPictureDisp Image { get; }
    IPictureDisp ImageAlpha { get; }
    bool LinkedToFile { get; }
    string Name { get; set; }
    SketchImage NativeObject { get; }
    object Parent { get; }
    Point2d Position { get; set; }
    ReferencedOLEFileDescriptor ReferencedFileDescriptor { get; }
    SketchBlocksEnumerator SketchBlockPath { get; }
    bool Transparent { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    double Width { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void MirrorHorizontal();
    void MirrorVertical();
    void RotateLeft();
    void RotateRight();
    void Update();
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [IPictureDisp](../objects/IPictureDisp.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [ReferencedOLEFileDescriptor](../objects/ReferencedOLEFileDescriptor.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchImage](../objects/SketchImage.md)

