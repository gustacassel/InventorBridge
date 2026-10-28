# ApprenticeDrawingPrintManager

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ApprenticePrintManager](../objects/ApprenticePrintManager.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

```csharp
interface ApprenticeDrawingPrintManager
{
    // Properties
    bool AllColorsAsBlack { get; set; }
    PrintColorModeEnum ColorMode { get; set; }
    int NumberOfCopies { get; set; }
    PrintOrientationEnum Orientation { get; set; }
    double PaperHeight { get; set; }
    PaperSizeEnum PaperSize { get; set; }
    int PaperSource { get; set; }
    double PaperWidth { get; set; }
    bool PrintExcludedSheets { get; set; }
    PrintRangeEnum PrintRange { get; set; }
    string Printer { get; set; }
    int PrinterDeviceContext { get; set; }
    bool RemoveLineWeights { get; set; }
    bool Rotate90Degrees { get; set; }
    double Scale { get; set; }
    PrintScaleModeEnum ScaleMode { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetSheetRange(out int FromSheet, out int ToSheet);
    void PrintToFile(string FileName);
    void SetCurrentView(ClientView CurrentView);
    void SetSheetRange(int FromSheet, int ToSheet);
    void SubmitPrint();
}
```

**Referenced types:** [ClientView](../objects/ClientView.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PaperSizeEnum](../enums/PaperSizeEnum.md), [PrintColorModeEnum](../enums/PrintColorModeEnum.md), [PrintOrientationEnum](../enums/PrintOrientationEnum.md), [PrintRangeEnum](../enums/PrintRangeEnum.md), [PrintScaleModeEnum](../enums/PrintScaleModeEnum.md)

