# DWGAcadSupportedProxiesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.AcadSupportedProxies`

```csharp
interface DWGAcadSupportedProxiesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGAcadSupportedProxy Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).AcadSupportedProxies, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).AcadSupportedProxies

**Referenced types:** [DWGAcadSupportedProxy](../objects/DWGAcadSupportedProxy.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

