# UnfoldMethods

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).UnfoldMethods`

```csharp
interface UnfoldMethods
{
    // Properties
    object Application { get; }
    int Count { get; }
    UnfoldMethod Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    UnfoldMethod AddBendTableFromFile(string Name, string FileName);
    UnfoldMethod AddEquationUnfoldMethod(string Name);
    UnfoldMethod AddLinearUnfoldMethod(string Name, string Value);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).UnfoldMethods

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UnfoldMethod](../objects/UnfoldMethod.md)

