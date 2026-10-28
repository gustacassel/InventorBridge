# HeadsUpDisplayOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.SketchOptions.HeadsUpDisplayOptions`

```csharp
interface HeadsUpDisplayOptions
{
    // Properties
    object Application { get; }
    bool DimensionInputEnabled { get; set; }
    bool DimensionInputInCartesianCoordinates { get; set; }
    bool Enabled { get; set; }
    SketchOptions Parent { get; }
    bool PointerInputEnabled { get; set; }
    bool PointerInputInCartesianCoordinates { get; set; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchOptions](../objects/SketchOptions.md).HeadsUpDisplayOptions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchOptions](../objects/SketchOptions.md)

