# EdgeSymbolStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.EdgeSymbolStyles.Item[…]`

```csharp
interface EdgeSymbolStyle
{
    // Properties
    object Application { get; }
    string Comments { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    LeaderStyle LeaderStyle { get; set; }
    string Name { get; set; }
    object Parent { get; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    TextStyle TextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void UpdateFromGlobal();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [EdgeSymbolDefinition](../objects/EdgeSymbolDefinition.md).Style, [EdgeSymbolStylesEnumerator](../objects/EdgeSymbolStylesEnumerator.md).Item, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).EdgeSymbolStyle

**Referenced types:** [LeaderStyle](../objects/LeaderStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TextStyle](../objects/TextStyle.md)

