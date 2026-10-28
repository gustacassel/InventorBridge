# DWGACMStandardPart

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGACMStandardPart
{
    // Properties
    object Application { get; }
    string HandleID { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DWGACMStandardPartsEnumerator](../objects/DWGACMStandardPartsEnumerator.md).Item

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

