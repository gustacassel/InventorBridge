# SketchBlockProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchBlock](../objects/SketchBlock.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchBlocks.Item[…] → (SketchBlockProxy)`

```csharp
interface SketchBlockProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    SketchBlocksEnumerator ChildBlocks { get; }
    Color Color { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    SketchBlock ContainingSketchBlock { get; }
    SketchBlockDefinition Definition { get; }
    bool Exported { get; set; }
    bool Flexible { get; set; }
    bool HasReferenceComponent { get; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    string Name { get; set; }
    SketchBlock NativeObject { get; }
    Sketch Parent { get; }
    Point2d Position { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    SketchBlock ReferencedEntity { get; }
    SketchBlocksEnumerator SketchBlockPath { get; }
    Matrix2d Transformation { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void Edit();
    void ExitEdit(ExitTypeEnum ExitTo);
    void Explode();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    object GetObject(object ObjectInDefinition);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Color](../objects/Color.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ExitTypeEnum](../enums/ExitTypeEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [Matrix2d](../objects/Matrix2d.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlockDefinition](../objects/SketchBlockDefinition.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md)

