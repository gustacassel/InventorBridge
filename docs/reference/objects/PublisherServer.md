# PublisherServer

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PublisherServer
{
    // Methods
    PresentationScene GetActivePresentationScene(PresentationDocument Document);
    PresentationScenes GetPresentationScenes(PresentationDocument Document);
    string GetStoryboardName(PresentationDocument Document, string publicationInternalName, int StoryboardId);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [PresentationDocument](../objects/PresentationDocument.md), [PresentationScene](../objects/PresentationScene.md), [PresentationScenes](../objects/PresentationScenes.md)

