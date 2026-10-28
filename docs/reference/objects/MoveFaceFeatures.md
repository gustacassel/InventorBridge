# MoveFaceFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MoveFaceFeatures`

```csharp
interface MoveFaceFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    MoveFaceFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MoveFaceFeature Add(MoveFaceDefinition Definition);
    MoveFaceDefinition CreateDefinition(FaceCollection Faces);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).MoveFaceFeatures, [PartFeatures](../objects/PartFeatures.md).MoveFaceFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).MoveFaceFeatures

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [MoveFaceDefinition](../objects/MoveFaceDefinition.md), [MoveFaceFeature](../objects/MoveFaceFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

