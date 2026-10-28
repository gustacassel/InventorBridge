# SketchSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).SketchSettings`

```csharp
interface SketchSettings
{
    // Properties
    object Application { get; }
    bool DisplayLineWeights { get; set; }
    LineWeightTypeEnum LineWeightType { get; set; }
    int MinorLinesPerMajorGridLine { get; set; }
    Document Parent { get; }
    int SnapsPerMinorGrid { get; set; }
    ObjectTypeEnum Type { get; }
    double UpperLimitForFirstRangeOfLineWeights { get; set; }
    double UpperLimitForSecondRangeOfLineWeights { get; set; }
    double UpperLimitForThirdRangeOfLineWeights { get; set; }
    string XSnapSpacing { get; set; }
    string YSnapSpacing { get; set; }
}
```

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).SketchSettings, [DrawingDocument](../objects/DrawingDocument.md).SketchSettings, [PartDocument](../objects/PartDocument.md).SketchSettings

**Referenced types:** [Document](../objects/Document.md), [LineWeightTypeEnum](../enums/LineWeightTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

