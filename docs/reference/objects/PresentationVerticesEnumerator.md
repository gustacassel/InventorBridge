# PresentationVerticesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.SurfaceBodies.Item[…].Vertices`

```csharp
interface PresentationVerticesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    PresentationVertex Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationBody](../objects/PresentationBody.md).Vertices, [PresentationFace](../objects/PresentationFace.md).Vertices

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationVertex](../objects/PresentationVertex.md)

