# DesignViewRepresentations

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.RepresentationsManager.DesignViewRepresentations`

```csharp
interface DesignViewRepresentations
{
    // Properties
    object Application { get; }
    int Count { get; }
    DesignViewRepresentation Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DesignViewRepresentation Add(string Name = "", bool Reserved = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RepresentationsManager](../objects/RepresentationsManager.md).DesignViewRepresentations

**Referenced types:** [DesignViewRepresentation](../objects/DesignViewRepresentation.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

