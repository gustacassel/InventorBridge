# TransitionSymbol

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.TransitionSymbols.Item[…]`

```csharp
interface TransitionSymbol
{
    // Properties
    object Application { get; } // since 2025
    TransitionSymbolAttachmentTypeEnum AttachmentType { get; } // since 2025
    AttributeSets AttributeSets { get; } // since 2025
    TransitionSymbolDefinition Definition { get; set; } // since 2025
    Leader Leader { get; } // since 2025
    Sheet Parent { get; } // since 2025
    Point2d Position { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    TransitionSymbol CopyTo(Sheet TargetSheet, object NewName = Missing, object Position = Missing); // since 2025
    void Delete(); // since 2025
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0); // since 2025
}
```

**Returned by:** [TransitionSymbol](../objects/TransitionSymbol.md).CopyTo, [TransitionSymbolDefinition](../objects/TransitionSymbolDefinition.md).Parent, [TransitionSymbols](../objects/TransitionSymbols.md).Add, [TransitionSymbols](../objects/TransitionSymbols.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Leader](../objects/Leader.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [TransitionSymbolAttachmentTypeEnum](../enums/TransitionSymbolAttachmentTypeEnum.md), [TransitionSymbolDefinition](../objects/TransitionSymbolDefinition.md)

