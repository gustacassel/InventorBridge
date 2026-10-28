# ImportedDWGLayer

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).Layers.Item[…]`

```csharp
interface ImportedDWGLayer
{
    // Properties
    object Application { get; }
    string Name { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
}
```

**Returned by:** [ImportedDWGLayersEnumerator](../objects/ImportedDWGLayersEnumerator.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

