# AnalysisManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.AnalysisManager`

```csharp
interface AnalysisManager
{
    // Properties
    object ActiveAnalysis { get; }
    AnalysisTypeEnum ActiveAnalysisType { get; }
    object Application { get; }
    DraftAnalyses DraftAnalyses { get; }
    bool IsAnalysisVisible { get; set; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DraftAnalysis](../objects/DraftAnalysis.md).Parent, [PartComponentDefinition](../objects/PartComponentDefinition.md).AnalysisManager, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).AnalysisManager

**Referenced types:** [AnalysisTypeEnum](../enums/AnalysisTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [DraftAnalyses](../objects/DraftAnalyses.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

