# EdgeLoopDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).EdgeDefinitions.Item[…].FaceOne.EdgeLoopDefinitions`

```csharp
interface EdgeLoopDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    EdgeLoopDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    EdgeLoopDefinition Add();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FaceDefinition](../objects/FaceDefinition.md).EdgeLoopDefinitions

**Referenced types:** [EdgeLoopDefinition](../objects/EdgeLoopDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

