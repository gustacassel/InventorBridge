# PropertySet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.PropertySets.Item[…]`

```csharp
interface PropertySet
{
    // Properties
    int Count { get; }
    bool Dirty { get; }
    string DisplayName { get; set; }
    string InternalName { get; }
    Property Item[object Index] { get; }
    Property ItemByPropId[int PropId] { get; }
    string Name { get; }
    PropertySets Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Property Add(object PropValue, object Name = Missing, object PropId = Missing);
    void Delete();
    void GetPropertyInfo(out int[] Ids, out string[] Names, out object[] Values);
    void SetPropertyValues(ref string[] PropertyNames, ref object[] PropertyValues);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Property](../objects/Property.md).Parent, [PropertySets](../objects/PropertySets.md).Add, [PropertySets](../objects/PropertySets.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Property](../objects/Property.md), [PropertySets](../objects/PropertySets.md)

