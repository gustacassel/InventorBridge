# DrawingPrintManager

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PrintManager](../objects/PrintManager.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.PrintManager → (DrawingPrintManager)`

```csharp
interface DrawingPrintManager
{
    // Properties
    bool AllColorsAsBlack { get; set; }
    object Application { get; }
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
    bool TilingEnabled { get; set; }
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

