# WorkSurfaces

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkSurfaces`

```csharp
interface WorkSurfaces
{
    // Properties
    object Application { get; }
    int Count { get; }
    WorkSurface Item[object Index] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartComponentDefinition](../objects/PartComponentDefinition.md).WorkSurfaces, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).WorkSurfaces

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkSurface](../objects/WorkSurface.md)

