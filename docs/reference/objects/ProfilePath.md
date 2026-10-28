# ProfilePath

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].Profiles.Item[…].Item[…]`

```csharp
interface ProfilePath
{
    // Properties
    bool AddsMaterial { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; }
    int Count { get; }
    ProfileEntity Item[int Index] { get; }
    Profile Parent { get; }
    TextBox TextBox { get; }
    bool TextBoxPath { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Profile](../objects/Profile.md).Item, [ProfileEntity](../objects/ProfileEntity.md).Parent, [ProfileEntityProxy](../objects/ProfileEntityProxy.md).Parent, [ProfilePathProxy](../objects/ProfilePathProxy.md).NativeObject, [ProfileProxy](../objects/ProfileProxy.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md), [ProfileEntity](../objects/ProfileEntity.md), [TextBox](../objects/TextBox.md)

