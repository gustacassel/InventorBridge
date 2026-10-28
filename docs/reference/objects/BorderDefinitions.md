# BorderDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).BorderDefinitions`

```csharp
interface BorderDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    BorderDefinition Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BorderDefinition Add(string Name);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).BorderDefinitions

**Referenced types:** [BorderDefinition](../objects/BorderDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

