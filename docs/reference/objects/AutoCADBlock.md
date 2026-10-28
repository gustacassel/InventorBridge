# AutoCADBlock

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.AutoCADBlocks.Item[…]`

```csharp
interface AutoCADBlock
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Color Color { get; set; }
    AutoCADBlockDefinition Definition { get; set; }
    Layer Layer { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    string Name { get; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    double Rotation { get; set; }
    double Scale { get; set; }
    bool Static { get; set; }
    Matrix2d Transformation { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetPromptTextValues(out object PromptTags, out object Values);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void SetPromptTextValues(object PromptTags, object Values);
}
```

**Returned by:** [AutoCADBlocks](../objects/AutoCADBlocks.md).Add, [AutoCADBlocks](../objects/AutoCADBlocks.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [AutoCADBlockDefinition](../objects/AutoCADBlockDefinition.md), [Color](../objects/Color.md), [Layer](../objects/Layer.md), [LineTypeEnum](../enums/LineTypeEnum.md), [Matrix2d](../objects/Matrix2d.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md)

