# AutoCADBlockDefinitionsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SheetFormats.Item[…].ReferencedAutoCADBlockDefinitions`

```csharp
interface AutoCADBlockDefinitionsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    AutoCADBlockDefinition Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AutoCADBlockDefinitions](../objects/AutoCADBlockDefinitions.md).AddFromFile, [SheetFormat](../objects/SheetFormat.md).ReferencedAutoCADBlockDefinitions

**Referenced types:** [AutoCADBlockDefinition](../objects/AutoCADBlockDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

