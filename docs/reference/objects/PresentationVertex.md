# PresentationVertex

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.SurfaceBodies.Item[…].Vertices.Item[…]`

```csharp
interface PresentationVertex
{
    // Properties
    object Application { get; }
    PresentationEdgesEnumerator Edges { get; }
    PresentationFacesEnumerator Faces { get; }
    PresentationBody Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [PresentationEdge](../objects/PresentationEdge.md).StartVertex, [PresentationEdge](../objects/PresentationEdge.md).StopVertex, [PresentationVerticesEnumerator](../objects/PresentationVerticesEnumerator.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationBody](../objects/PresentationBody.md), [PresentationEdgesEnumerator](../objects/PresentationEdgesEnumerator.md), [PresentationFacesEnumerator](../objects/PresentationFacesEnumerator.md)

