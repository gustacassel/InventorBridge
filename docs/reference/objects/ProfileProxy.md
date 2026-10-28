# ProfileProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Profile](../objects/Profile.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].Profiles.Item[…] → (ProfileProxy)`

```csharp
interface ProfileProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    int Count { get; }
    ProfilePath Item[int Index] { get; }
    bool MergeFaces { get; set; }
    Profile NativeObject { get; }
    Sketch Parent { get; }
    RegionProperties RegionProperties { get; }
    ObjectTypeEnum Type { get; }
    Wires Wires { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md), [ProfilePath](../objects/ProfilePath.md), [RegionProperties](../objects/RegionProperties.md), [Sketch](../objects/Sketch.md), [Wires](../objects/Wires.md)

