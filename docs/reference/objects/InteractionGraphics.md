# InteractionGraphics

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…).InteractionGraphics`

```csharp
interface InteractionGraphics
{
    // Properties
    GraphicsDataSets GraphicsDataSets { get; }
    ClientGraphics OverlayClientGraphics { get; }
    ClientGraphics PreviewClientGraphics { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void UpdateOverlayGraphics(View TheView);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [InteractionEvents](../objects/InteractionEvents.md).InteractionGraphics

**Referenced types:** [ClientGraphics](../objects/ClientGraphics.md), [GraphicsDataSets](../objects/GraphicsDataSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [View](../objects/View.md)

