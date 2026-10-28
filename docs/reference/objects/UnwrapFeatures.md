# UnwrapFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.UnwrapFeatures`

```csharp
interface UnwrapFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    UnwrapFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    UnwrapFeature Add(UnwrapDefinition Definition);
    UnwrapDefinition CreateDefinition(FaceCollection Faces, object pOrigin = Missing, UnwrapResultAlignmentEnum Align = UnwrapResultAlignmentEnum.kOriginAlignment, object LinearResult = Missing, object RigidResult = Missing, bool AutomaticFaceChain = true, bool MergeResultBody = true);
    UnwrapDefinition CreateDefinitionWithOptions(FaceCollection Faces, object pOrigin = Missing, UnwrapResultAlignmentEnum Align = UnwrapResultAlignmentEnum.kOriginAlignment, object LinearResult = Missing, object RigidResult = Missing, bool AutomaticFaceChain = true, bool MergeResultBody = true, object MoreOptions = Missing); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).UnwrapFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).UnwrapFeatures

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UnwrapDefinition](../objects/UnwrapDefinition.md), [UnwrapFeature](../objects/UnwrapFeature.md), [UnwrapResultAlignmentEnum](../enums/UnwrapResultAlignmentEnum.md)

