# PrintManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.PrintManager`

```csharp
interface PrintManager
{
    // Properties
    object Application { get; }
    PrintColorModeEnum ColorMode { get; set; }
    int NumberOfCopies { get; set; }
    PrintOrientationEnum Orientation { get; set; }
    double PaperHeight { get; set; }
    PaperSizeEnum PaperSize { get; set; }
    int PaperSource { get; set; }
    double PaperWidth { get; set; }
    string Printer { get; set; }
    int PrinterDeviceContext { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void PrintToFile(string FileName);
    void SetCurrentView(ClientView CurrentView);
    void SubmitPrint();
}
```

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).PrintManager, [Document](../objects/Document.md).PrintManager, [DrawingDocument](../objects/DrawingDocument.md).PrintManager, [PartDocument](../objects/PartDocument.md).PrintManager, [PresentationDocument](../objects/PresentationDocument.md).PrintManager

**Referenced types:** [ClientView](../objects/ClientView.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PaperSizeEnum](../enums/PaperSizeEnum.md), [PrintColorModeEnum](../enums/PrintColorModeEnum.md), [PrintOrientationEnum](../enums/PrintOrientationEnum.md)

