# DraftAnalysis

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.AnalysisManager.DraftAnalyses.Item[…]`

```csharp
interface DraftAnalysis
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    int DisplayQuality { get; set; }
    double EndAngle { get; set; }
    ObjectCollection Faces { get; set; }
    bool GradientDisplay { get; set; }
    string Name { get; set; }
    AnalysisManager Parent { get; }
    object PullDirection { get; set; }
    bool PullDirectionReversed { get; set; }
    double StartAngle { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Activate();
    DraftAnalysis Copy();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [DraftAnalyses](../objects/DraftAnalyses.md).Add, [DraftAnalyses](../objects/DraftAnalyses.md).Item, [DraftAnalysis](../objects/DraftAnalysis.md).Copy

**Referenced types:** [AnalysisManager](../objects/AnalysisManager.md), [AttributeSets](../objects/AttributeSets.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

