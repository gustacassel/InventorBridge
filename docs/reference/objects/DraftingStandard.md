# DraftingStandard

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DraftingStandard
{
    // Properties
    DraftingStandardEnum BaseStandard { get; }
    bool BuiltIn { get; }
    string Name { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ActiveStandard

**Referenced types:** [DraftingStandardEnum](../enums/DraftingStandardEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

