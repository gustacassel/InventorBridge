# DWGPolylines3DEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines3D`

```csharp
interface DWGPolylines3DEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGPolyline3D Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).Polylines3D, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).Polylines3D

**Referenced types:** [DWGPolyline3D](../objects/DWGPolyline3D.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

