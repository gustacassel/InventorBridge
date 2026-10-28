# ClientGraphicsCollection

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection`

```csharp
interface ClientGraphicsCollection
{
    // Properties
    object Application { get; }
    int Count { get; }
    ClientGraphics Item[object Index] { get; }
    bool NonTransacting { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ClientGraphics Add(string ClientId);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).ClientGraphicsCollection, [AssemblyDocument](../objects/AssemblyDocument.md).NonTransactingClientGraphicsCollection, [ClientFeatureDefinition](../objects/ClientFeatureDefinition.md).ClientGraphicsCollection, [ClientGraphics](../objects/ClientGraphics.md).Parent, [ComponentDefinition](../objects/ComponentDefinition.md).ClientGraphicsCollection, [DetailDrawingView](../objects/DetailDrawingView.md).ClientGraphicsCollection, [Document](../objects/Document.md).NonTransactingClientGraphicsCollection, [DrawingDocument](../objects/DrawingDocument.md).NonTransactingClientGraphicsCollection, [DrawingView](../objects/DrawingView.md).ClientGraphicsCollection, [FlatPattern](../objects/FlatPattern.md).ClientGraphicsCollection, [PartComponentDefinition](../objects/PartComponentDefinition.md).ClientGraphicsCollection, [PartDocument](../objects/PartDocument.md).NonTransactingClientGraphicsCollection, [PresentationDocument](../objects/PresentationDocument.md).NonTransactingClientGraphicsCollection, [PresentationScene](../objects/PresentationScene.md).ClientGraphicsCollection, [SectionDrawingView](../objects/SectionDrawingView.md).ClientGraphicsCollection, [Sheet](../objects/Sheet.md).ClientGraphicsCollection, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).ClientGraphicsCollection, [VirtualComponentDefinition](../objects/VirtualComponentDefinition.md).ClientGraphicsCollection, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).ClientGraphicsCollection, [WeldsComponentDefinition](../objects/WeldsComponentDefinition.md).ClientGraphicsCollection

**Referenced types:** [ClientGraphics](../objects/ClientGraphics.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

