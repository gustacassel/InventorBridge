# TransitionSymbolStyle

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.TransitionSymbolStyles.Item[…]`

```csharp
interface TransitionSymbolStyle
{
    // Properties
    object Application { get; } // since 2025
    string Comments { get; set; } // since 2025
    bool InUse { get; } // since 2025
    string InternalName { get; } // since 2025
    LeaderStyle LeaderStyleForEdgeSelected { get; set; } // since 2025
    LeaderStyle LeaderStyleForFaceSelected { get; set; } // since 2025
    string Name { get; set; } // since 2025
    object Parent { get; } // since 2025
    StyleLocationEnum StyleLocation { get; } // since 2025
    StyleTypeEnum StyleType { get; } // since 2025
    TextStyle TextStyle { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    bool UpToDate { get; } // since 2025
    // Methods
    Style ConvertToLocal(); // since 2025
    Style Copy(string Name); // since 2025
    void Delete(); // since 2025
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0); // since 2025
    void SaveToGlobal(); // since 2025
    void UpdateFromGlobal(); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).TransitionSymbolStyle, [TransitionSymbolDefinition](../objects/TransitionSymbolDefinition.md).Style, [TransitionSymbolStylesEnumerator](../objects/TransitionSymbolStylesEnumerator.md).Item

**Referenced types:** [LeaderStyle](../objects/LeaderStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TextStyle](../objects/TextStyle.md)

