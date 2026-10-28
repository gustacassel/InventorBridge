# DisabledCommandList

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).DisabledCommandList`

```csharp
interface DisabledCommandList
{
    // Properties
    Application Application { get; }
    int Count { get; }
    ControlDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(ControlDefinition Command);
    void Remove(int Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).DisabledCommandList, [DrawingDocument](../objects/DrawingDocument.md).DisabledCommandList, [Environment](../objects/Environment.md).DisabledCommandList, [PartDocument](../objects/PartDocument.md).DisabledCommandList, [PresentationDocument](../objects/PresentationDocument.md).DisabledCommandList

**Referenced types:** [Application](../objects/Application.md), [ControlDefinition](../objects/ControlDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

