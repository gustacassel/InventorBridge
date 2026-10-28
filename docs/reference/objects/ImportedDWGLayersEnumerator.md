# ImportedDWGLayersEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).Layers`

```csharp
interface ImportedDWGLayersEnumerator
{
    // Properties
    int Count { get; }
    ImportedDWGLayer Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ImportedDWGComponent](../objects/ImportedDWGComponent.md).Layers, [ImportedDWGComponentProxy](../objects/ImportedDWGComponentProxy.md).Layers

**Referenced types:** [ImportedDWGLayer](../objects/ImportedDWGLayer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

