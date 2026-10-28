# DWGAcadSupportedProxyProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGAcadSupportedProxyProxy
{
    // Properties
    object Application { get; }
    string HandleID { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    DWGEntitySegmentsEnumerator Segments { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [DWGEntitySegmentsEnumerator](../objects/DWGEntitySegmentsEnumerator.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

