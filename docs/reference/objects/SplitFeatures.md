# SplitFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SplitFeatures`

```csharp
interface SplitFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    SplitFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SplitFeature SplitBody(object SplitTool, SurfaceBody Body);
    SplitFeature SplitFaces(object SplitTool, bool SplitAll = true, object FacesOrBody = Missing);
    SplitFeature TrimSolid(object SplitTool, SurfaceBody Body, bool RemovePositiveSide = true);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).SplitFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).SplitFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SplitFeature](../objects/SplitFeature.md), [SurfaceBody](../objects/SurfaceBody.md)

