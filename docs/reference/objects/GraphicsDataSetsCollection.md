# GraphicsDataSetsCollection

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection`

```csharp
interface GraphicsDataSetsCollection
{
    // Properties
    object Application { get; }
    int Count { get; }
    GraphicsDataSets Item[object Index] { get; }
    bool NonTransacting { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    GraphicsDataSets Add(string ClientId);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).GraphicsDataSetsCollection, [AssemblyDocument](../objects/AssemblyDocument.md).NonTransactingGraphicsDataSetsCollection, [ClientFeatureDefinition](../objects/ClientFeatureDefinition.md).GraphicsDataSetsCollection, [DetailDrawingView](../objects/DetailDrawingView.md).GraphicsDataSetsCollection, [Document](../objects/Document.md).GraphicsDataSetsCollection, [Document](../objects/Document.md).NonTransactingGraphicsDataSetsCollection, [DrawingDocument](../objects/DrawingDocument.md).GraphicsDataSetsCollection, [DrawingDocument](../objects/DrawingDocument.md).NonTransactingGraphicsDataSetsCollection, [DrawingView](../objects/DrawingView.md).GraphicsDataSetsCollection, [FlatPattern](../objects/FlatPattern.md).GraphicsDataSetsCollection, [GraphicsDataSets](../objects/GraphicsDataSets.md).Parent, [MeshFeatureEntity](../objects/MeshFeatureEntity.md).GraphicsDataSetsCollection, [MeshFeatureEntityProxy](../objects/MeshFeatureEntityProxy.md).GraphicsDataSetsCollection, [PartDocument](../objects/PartDocument.md).GraphicsDataSetsCollection, [PartDocument](../objects/PartDocument.md).NonTransactingGraphicsDataSetsCollection, [PresentationDocument](../objects/PresentationDocument.md).GraphicsDataSetsCollection, [PresentationDocument](../objects/PresentationDocument.md).NonTransactingGraphicsDataSetsCollection, [PresentationScene](../objects/PresentationScene.md).GraphicsDataSetsCollection, [SectionDrawingView](../objects/SectionDrawingView.md).GraphicsDataSetsCollection, [Sheet](../objects/Sheet.md).GraphicsDataSetsCollection

**Referenced types:** [GraphicsDataSets](../objects/GraphicsDataSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

