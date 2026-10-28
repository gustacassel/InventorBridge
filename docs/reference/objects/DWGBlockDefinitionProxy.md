# DWGBlockDefinitionProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition → (DWGBlockDefinitionProxy)`

```csharp
interface DWGBlockDefinitionProxy
{
    // Properties
    DWGAcadSupportedProxiesEnumerator AcadSupportedProxies { get; }
    object Application { get; }
    DWGArcsEnumerator Arcs { get; }
    DWGBlockReferencesEnumerator BlockReferences { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    DWGEllipticalArcsEnumerator EllipticalArcs { get; }
    DWGEntitiesEnumerator Entities { get; }
    bool IsModelSpaceDefinition { get; }
    DWGLinesEnumerator Lines { get; }
    DWGBlockDefinition NativeObject { get; }
    ImportedDWGComponent Parent { get; }
    DWGPointsEnumerator Points { get; }
    DWGPolylinesEnumerator Polylines { get; }
    DWGPolylines2DEnumerator Polylines2D { get; }
    DWGPolylines3DEnumerator Polylines3D { get; }
    DWGSplinesEnumerator Splines { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGAcadSupportedProxiesEnumerator](../objects/DWGAcadSupportedProxiesEnumerator.md), [DWGArcsEnumerator](../objects/DWGArcsEnumerator.md), [DWGBlockDefinition](../objects/DWGBlockDefinition.md), [DWGBlockReferencesEnumerator](../objects/DWGBlockReferencesEnumerator.md), [DWGEllipticalArcsEnumerator](../objects/DWGEllipticalArcsEnumerator.md), [DWGEntitiesEnumerator](../objects/DWGEntitiesEnumerator.md), [DWGLinesEnumerator](../objects/DWGLinesEnumerator.md), [DWGPointsEnumerator](../objects/DWGPointsEnumerator.md), [DWGPolylines2DEnumerator](../objects/DWGPolylines2DEnumerator.md), [DWGPolylines3DEnumerator](../objects/DWGPolylines3DEnumerator.md), [DWGPolylinesEnumerator](../objects/DWGPolylinesEnumerator.md), [DWGSplinesEnumerator](../objects/DWGSplinesEnumerator.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

