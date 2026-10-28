# ImportedComponentDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…].Definition`

```csharp
interface ImportedComponentDefinition
{
    // Properties
    object Application { get; }
    string FullFileName { get; }
    ImportedComponent Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [ImportedComponent](../objects/ImportedComponent.md).Definition, [ImportedComponents](../objects/ImportedComponents.md).CreateDataExchangeDefinition, [ImportedComponents](../objects/ImportedComponents.md).CreateDefinition, [ImportedDWGComponent](../objects/ImportedDWGComponent.md).Definition, [ImportedDWGComponentProxy](../objects/ImportedDWGComponentProxy.md).Definition, [ImportedDataExchangeComponent](../objects/ImportedDataExchangeComponent.md).Definition, [ImportedDataExchangeComponentProxy](../objects/ImportedDataExchangeComponentProxy.md).Definition, [ImportedGenericComponent](../objects/ImportedGenericComponent.md).Definition, [ImportedGenericComponentProxy](../objects/ImportedGenericComponentProxy.md).Definition, [ImportedModelEntity](../objects/ImportedModelEntity.md).Parent, [ImportedRVTComponent](../objects/ImportedRVTComponent.md).Definition, [ImportedRVTComponentProxy](../objects/ImportedRVTComponentProxy.md).Definition

**Referenced types:** [ImportedComponent](../objects/ImportedComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

