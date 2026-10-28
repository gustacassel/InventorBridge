# AutoCADBlockDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).AutoCADBlockDefinitions`

```csharp
interface AutoCADBlockDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    AutoCADBlockDefinition Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AutoCADBlockDefinitionsEnumerator AddFromFile(string DWGFullFileName, object DefinitionNames = Missing, bool ReplaceExisting = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).AutoCADBlockDefinitions

**Referenced types:** [AutoCADBlockDefinition](../objects/AutoCADBlockDefinition.md), [AutoCADBlockDefinitionsEnumerator](../objects/AutoCADBlockDefinitionsEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

