# UnwrapDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.UnwrapFeatures.Item[…].Definition`

```csharp
interface UnwrapDefinition
{
    // Properties
    object Application { get; }
    bool AutomaticFaceChain { get; set; }
    FaceCollection InputFaces { get; set; }
    EdgeCollection LinearResult { get; set; }
    bool MergeResultBody { get; set; }
    Vertex Origin { get; set; }
    UnwrapFeature Parent { get; }
    UnwrapResultAlignmentEnum ResultAlignment { get; set; }
    EdgeCollection RigidResult { get; set; }
    EdgeCollection SeamEdges { get; set; } // since 2025
    ObjectTypeEnum Type { get; }
    // Methods
    UnwrapDefinition Copy();
}
```

**Returned by:** [UnwrapDefinition](../objects/UnwrapDefinition.md).Copy, [UnwrapFeature](../objects/UnwrapFeature.md).Definition, [UnwrapFeatureProxy](../objects/UnwrapFeatureProxy.md).Definition, [UnwrapFeatures](../objects/UnwrapFeatures.md).CreateDefinition, [UnwrapFeatures](../objects/UnwrapFeatures.md).CreateDefinitionWithOptions

**Referenced types:** [EdgeCollection](../objects/EdgeCollection.md), [FaceCollection](../objects/FaceCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UnwrapFeature](../objects/UnwrapFeature.md), [UnwrapResultAlignmentEnum](../enums/UnwrapResultAlignmentEnum.md), [Vertex](../objects/Vertex.md)

