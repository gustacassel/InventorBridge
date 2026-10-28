# ComponentOccurrences

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Occurrences`

```csharp
interface ComponentOccurrences
{
    // Properties
    ComponentOccurrencesEnumerator AllLeafOccurrences[object LeafDefinition = Missing] { get; }
    ComponentOccurrencesEnumerator AllReferencedOccurrences[object Object] { get; }
    int Count { get; }
    ComponentOccurrence Item[int Index] { get; }
    ComponentOccurrence ItemByName[string Name] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ComponentOccurrence Add(string FullDocumentName, Matrix Position);
    ComponentOccurrence AddByComponentDefinition(ComponentDefinition CompDef, Matrix Position);
    ComponentOccurrence AddCustomiPartMember(string FactoryFileName, Matrix Position, string FullFileName, object Row = Missing, object CustomInput = Missing);
    ComponentOccurrencesEnumerator AddUsingiMates(string FullDocumentName, bool PlaceAllMatching = false, object Options = Missing);
    ComponentOccurrence AddVirtual(string Name, Matrix Position);
    ComponentOccurrence AddWithOptions(string FullDocumentName, Matrix Position, NameValueMap Options);
    ComponentOccurrence AddiAssemblyMember(string FactoryDocumentName, Matrix Position, object Row = Missing, object Options = Missing);
    ComponentOccurrence AddiPartMember(string FactoryFileName, Matrix Position, object Row = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).Occurrences, [ComponentDefinition](../objects/ComponentDefinition.md).Occurrences, [FlatPattern](../objects/FlatPattern.md).Occurrences, [PartComponentDefinition](../objects/PartComponentDefinition.md).Occurrences, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).Occurrences, [VirtualComponentDefinition](../objects/VirtualComponentDefinition.md).Occurrences, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).Occurrences, [WeldsComponentDefinition](../objects/WeldsComponentDefinition.md).Occurrences

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [Matrix](../objects/Matrix.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

