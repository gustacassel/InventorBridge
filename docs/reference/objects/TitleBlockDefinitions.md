# TitleBlockDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).TitleBlockDefinitions`

```csharp
interface TitleBlockDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    TitleBlockDefinition Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    TitleBlockDefinition Add(string Name);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).TitleBlockDefinitions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TitleBlockDefinition](../objects/TitleBlockDefinition.md)

