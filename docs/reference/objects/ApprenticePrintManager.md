# ApprenticePrintManager

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ApprenticePrintManager
{
    // Properties
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

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).PrintManager, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).PrintManager

**Referenced types:** [ClientView](../objects/ClientView.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PaperSizeEnum](../enums/PaperSizeEnum.md), [PrintColorModeEnum](../enums/PrintColorModeEnum.md), [PrintOrientationEnum](../enums/PrintOrientationEnum.md)

