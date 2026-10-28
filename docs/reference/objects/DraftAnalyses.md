# DraftAnalyses

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.AnalysisManager.DraftAnalyses`

```csharp
interface DraftAnalyses
{
    // Properties
    object Application { get; }
    int Count { get; }
    DraftAnalysis Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DraftAnalysis Add(double StartAngle, double EndAngle, object PullDirection, bool Reversed = false, object Faces = Missing, bool GradientDisplay = false, int DisplayQuality = 0, string Name = "");
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AnalysisManager](../objects/AnalysisManager.md).DraftAnalyses

**Referenced types:** [DraftAnalysis](../objects/DraftAnalysis.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

