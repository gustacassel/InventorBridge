# AutoCADBlockDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).AutoCADBlockDefinitions.Item[…]`

```csharp
interface AutoCADBlockDefinition
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool IsReferenced { get; }
    string Name { get; }
    DrawingDocument Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AutoCADBlockDefinition CopyTo(DrawingDocument TargetDocument, bool ReplaceExisting = false);
    void Delete();
    void GetPromptTags(out object Tags, out object Prompts = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [AutoCADBlock](../objects/AutoCADBlock.md).Definition, [AutoCADBlockDefinition](../objects/AutoCADBlockDefinition.md).CopyTo, [AutoCADBlockDefinitions](../objects/AutoCADBlockDefinitions.md).Item, [AutoCADBlockDefinitionsEnumerator](../objects/AutoCADBlockDefinitionsEnumerator.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DrawingDocument](../objects/DrawingDocument.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

