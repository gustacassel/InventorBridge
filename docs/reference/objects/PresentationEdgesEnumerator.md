# PresentationEdgesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.SurfaceBodies.Item[…].Edges`

```csharp
interface PresentationEdgesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    PresentationEdge Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationBody](../objects/PresentationBody.md).Edges, [PresentationFace](../objects/PresentationFace.md).Edges, [PresentationVertex](../objects/PresentationVertex.md).Edges

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationEdge](../objects/PresentationEdge.md)

