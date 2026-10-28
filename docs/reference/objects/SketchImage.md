# SketchImage

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchImages.Item[…]`

```csharp
interface SketchImage
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    SketchEntitiesEnumerator BoundaryGeometry { get; }
    SketchBlock ContainingSketchBlock { get; }
    double Height { get; set; }
    IPictureDisp Image { get; }
    IPictureDisp ImageAlpha { get; }
    bool LinkedToFile { get; }
    string Name { get; set; }
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

**Returned by:** [DecalFeature](../objects/DecalFeature.md).Image, [DecalFeatureProxy](../objects/DecalFeatureProxy.md).Image, [SketchImageProxy](../objects/SketchImageProxy.md).NativeObject, [SketchImages](../objects/SketchImages.md).Add, [SketchImages](../objects/SketchImages.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [IPictureDisp](../objects/IPictureDisp.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [ReferencedOLEFileDescriptor](../objects/ReferencedOLEFileDescriptor.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md)

