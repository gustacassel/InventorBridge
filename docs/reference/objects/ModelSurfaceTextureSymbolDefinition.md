# ModelSurfaceTextureSymbolDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelSurfaceTextureSymbols.Item[…].Definition`

```csharp
interface ModelSurfaceTextureSymbolDefinition
{
    // Properties
    string AdditionalProductionMethod { get; set; }
    string AdditionalRoughness { get; set; }
    string AdditionalSamplingLength { get; set; }
    bool AllAroundSymbol { get; set; }
    ModelLeaderNodesEnumerator AllLeafNodes { get; }
    ModelLeaderNodesEnumerator AllNodes { get; }
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    FaceCollection Faces { get; set; }
    bool HasRootNode { get; }
    GeometryIntent Intent { get; set; }
    bool IsForceTailShown { get; set; }
    bool IsMajority { get; set; }
    LayDirectionTypeEnum LayDirection { get; set; }
    ModelLeader Leader { get; }
    string MachiningAllowance { get; set; }
    string ManufacturingProcess { get; set; } // since 2025
    string MaximumRoughness { get; set; }
    string MinimumRoughness { get; set; }
    string NumberOfFeatureElements { get; set; } // since 2025
    ModelSurfaceTextureSymbol Parent { get; }
    Point Position { get; set; }
    string ProductionMethod { get; set; }
    ProfileDirectionTypeEnum ProfileDirection { get; set; } // since 2025
    ModelLeaderNode RootNode { get; }
    string SamplingLength { get; set; }
    SurfaceTextureStandardReferenceTypeEnum StandardReference { get; } // since 2025
    string SurfaceProfileLowerTolerance { get; set; } // since 2025
    string SurfaceProfileUpperTolerance { get; set; } // since 2025
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    string SurfaceWaviness { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddLeader(ObjectCollection Points);
    ModelSurfaceTextureSymbolDefinition Copy();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelGeneralNotes](../objects/ModelGeneralNotes.md).CreateEmbeddedSurfaceTextureSymbolDefinition, [ModelSurfaceTextureSymbol](../objects/ModelSurfaceTextureSymbol.md).Definition, [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md).Copy, [ModelSurfaceTextureSymbolProxy](../objects/ModelSurfaceTextureSymbolProxy.md).Definition, [ModelSurfaceTextureSymbols](../objects/ModelSurfaceTextureSymbols.md).CreateDefinition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [FaceCollection](../objects/FaceCollection.md), [GeometryIntent](../objects/GeometryIntent.md), [LayDirectionTypeEnum](../enums/LayDirectionTypeEnum.md), [ModelLeader](../objects/ModelLeader.md), [ModelLeaderNode](../objects/ModelLeaderNode.md), [ModelLeaderNodesEnumerator](../objects/ModelLeaderNodesEnumerator.md), [ModelSurfaceTextureSymbol](../objects/ModelSurfaceTextureSymbol.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [ProfileDirectionTypeEnum](../enums/ProfileDirectionTypeEnum.md), [SurfaceTextureStandardReferenceTypeEnum](../enums/SurfaceTextureStandardReferenceTypeEnum.md), [SurfaceTextureTypeEnum](../enums/SurfaceTextureTypeEnum.md)

