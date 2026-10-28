# ProfilePathProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ProfilePath](../objects/ProfilePath.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].Profiles.Item[…].Item[…] → (ProfilePathProxy)`

```csharp
interface ProfilePathProxy
{
    // Properties
    bool AddsMaterial { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    int Count { get; }
    ProfileEntity Item[int Index] { get; }
    ProfilePath NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md), [ProfileEntity](../objects/ProfileEntity.md), [ProfilePath](../objects/ProfilePath.md), [TextBox](../objects/TextBox.md)

