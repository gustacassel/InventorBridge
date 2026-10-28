# PresentationScenes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes`

```csharp
interface PresentationScenes
{
    // Properties
    object Application { get; }
    int Count { get; }
    PresentationScene Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationDocument](../objects/PresentationDocument.md).Scenes, [PublisherServer](../objects/PublisherServer.md).GetPresentationScenes

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationScene](../objects/PresentationScene.md)

