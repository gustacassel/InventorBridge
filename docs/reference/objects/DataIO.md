# DataIO

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.AttributeSets.DataIO`

```csharp
interface DataIO
{
    // Methods
    void GetInputFormats(out string[] Formats, out StorageTypeEnum[] StorageTypes);
    void GetOutputFormats(out string[] Formats, out StorageTypeEnum[] StorageTypes);
    void ReadDataFromFile(string Format, string FileName);
    void ReadDataFromStream(string Format, object Stream);
    void WriteDataToFile(string Format, string FileName);
    void WriteDataToStream(string Format, out object Stream);
}
```

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).DataIO, [AttributeSet](../objects/AttributeSet.md).DataIO, [AttributeSets](../objects/AttributeSets.md).DataIO, [ComponentDefinition](../objects/ComponentDefinition.md).DataIO, [DetailDrawingView](../objects/DetailDrawingView.md).DataIO, [DrawingSketch](../objects/DrawingSketch.md).DataIO, [DrawingView](../objects/DrawingView.md).DataIO, [FlatPattern](../objects/FlatPattern.md).DataIO, [PartComponentDefinition](../objects/PartComponentDefinition.md).DataIO, [PlanarSketch](../objects/PlanarSketch.md).DataIO, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).DataIO, [SectionDrawingView](../objects/SectionDrawingView.md).DataIO, [Sheet](../objects/Sheet.md).DataIO, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).DataIO, [Sketch](../objects/Sketch.md).DataIO, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).DataIO, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).DataIO, [SurfaceBody](../objects/SurfaceBody.md).DataIO, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).DataIO, [VirtualComponentDefinition](../objects/VirtualComponentDefinition.md).DataIO, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).DataIO, [WeldsComponentDefinition](../objects/WeldsComponentDefinition.md).DataIO

**Referenced types:** [StorageTypeEnum](../enums/StorageTypeEnum.md)

