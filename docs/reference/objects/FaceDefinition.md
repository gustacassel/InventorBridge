# FaceDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).EdgeDefinitions.Item[…].FaceOne`

```csharp
interface FaceDefinition
{
    // Properties
    object Application { get; }
    int AssociativeID { get; set; }
    EdgeLoopDefinitions EdgeLoopDefinitions { get; }
    bool IsParamReversed { get; set; }
    object SurfaceGeometry { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [EdgeDefinition](../objects/EdgeDefinition.md).FaceOne, [EdgeDefinition](../objects/EdgeDefinition.md).FaceTwo, [FaceDefinitions](../objects/FaceDefinitions.md).Add, [FaceDefinitions](../objects/FaceDefinitions.md).Item

**Referenced types:** [EdgeLoopDefinitions](../objects/EdgeLoopDefinitions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

