# DWGBlockReferencesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.BlockReferences`

```csharp
interface DWGBlockReferencesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGBlockReference Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).BlockReferences, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).BlockReferences

**Referenced types:** [DWGBlockReference](../objects/DWGBlockReference.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

