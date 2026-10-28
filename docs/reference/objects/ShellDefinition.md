# ShellDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ShellFeatures.Item[…].Definition`

```csharp
interface ShellDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; } // since 2026
    object Application { get; }
    bool ApproximationOptimized { get; set; }
    double ApproximationTolerance { get; set; }
    FeatureApproximationTypeEnum ApproximationType { get; set; }
    ShellDirectionEnum Direction { get; set; }
    int FaceSetCount { get; }
    ShellThicknessFaceSet FaceSetItem[int Index] { get; }
    FaceCollection InputFaces { get; set; }
    ShellMethodEnum Method { get; set; } // since 2026
    ShellFeature Parent { get; }
    Parameter Thickness { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ShellThicknessFaceSet AddThicknessFaceSet(FaceCollection Faces, object Thickness);
    ShellDefinition Copy();
}
```

**Returned by:** [ShellDefinition](../objects/ShellDefinition.md).Copy, [ShellFeature](../objects/ShellFeature.md).Definition, [ShellFeatureProxy](../objects/ShellFeatureProxy.md).Definition, [ShellFeatures](../objects/ShellFeatures.md).CreateDefinition

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [FeatureApproximationTypeEnum](../enums/FeatureApproximationTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ShellDirectionEnum](../enums/ShellDirectionEnum.md), [ShellFeature](../objects/ShellFeature.md), [ShellMethodEnum](../enums/ShellMethodEnum.md), [ShellThicknessFaceSet](../objects/ShellThicknessFaceSet.md)

