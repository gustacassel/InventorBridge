# DWGBlockDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition`

```csharp
interface DWGBlockDefinition
{
    // Properties
    DWGAcadSupportedProxiesEnumerator AcadSupportedProxies { get; }
    object Application { get; }
    DWGArcsEnumerator Arcs { get; }
    DWGBlockReferencesEnumerator BlockReferences { get; }
    DWGEllipticalArcsEnumerator EllipticalArcs { get; }
    DWGEntitiesEnumerator Entities { get; }
    bool IsModelSpaceDefinition { get; }
    DWGLinesEnumerator Lines { get; }
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

**Returned by:** [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).NativeObject, [DWGBlockReference](../objects/DWGBlockReference.md).Definition, [DWGBlockReferenceProxy](../objects/DWGBlockReferenceProxy.md).Definition, [ImportedDWGComponent](../objects/ImportedDWGComponent.md).ModelSpaceDefinition, [ImportedDWGComponentProxy](../objects/ImportedDWGComponentProxy.md).ModelSpaceDefinition

**Referenced types:** [DWGAcadSupportedProxiesEnumerator](../objects/DWGAcadSupportedProxiesEnumerator.md), [DWGArcsEnumerator](../objects/DWGArcsEnumerator.md), [DWGBlockReferencesEnumerator](../objects/DWGBlockReferencesEnumerator.md), [DWGEllipticalArcsEnumerator](../objects/DWGEllipticalArcsEnumerator.md), [DWGEntitiesEnumerator](../objects/DWGEntitiesEnumerator.md), [DWGLinesEnumerator](../objects/DWGLinesEnumerator.md), [DWGPointsEnumerator](../objects/DWGPointsEnumerator.md), [DWGPolylines2DEnumerator](../objects/DWGPolylines2DEnumerator.md), [DWGPolylines3DEnumerator](../objects/DWGPolylines3DEnumerator.md), [DWGPolylinesEnumerator](../objects/DWGPolylinesEnumerator.md), [DWGSplinesEnumerator](../objects/DWGSplinesEnumerator.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

