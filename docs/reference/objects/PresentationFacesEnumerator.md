# PresentationFacesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.SurfaceBodies.Item[…].Faces`

```csharp
interface PresentationFacesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    PresentationFace Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationBody](../objects/PresentationBody.md).Faces, [PresentationEdge](../objects/PresentationEdge.md).Faces, [PresentationVertex](../objects/PresentationVertex.md).Faces

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationFace](../objects/PresentationFace.md)

