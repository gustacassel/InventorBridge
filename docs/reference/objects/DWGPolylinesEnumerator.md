# DWGPolylinesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines`

```csharp
interface DWGPolylinesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGPolyline Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).Polylines, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).Polylines

**Referenced types:** [DWGPolyline](../objects/DWGPolyline.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

