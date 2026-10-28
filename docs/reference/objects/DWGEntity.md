# DWGEntity

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Entities.Item[…]`

```csharp
interface DWGEntity
{
    // Properties
    object Application { get; }
    string HandleID { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DWGACMStandardPart](../objects/DWGACMStandardPart.md).ParentEntity, [DWGACMStandardPartProxy](../objects/DWGACMStandardPartProxy.md).ParentEntity, [DWGAcadSupportedProxy](../objects/DWGAcadSupportedProxy.md).ParentEntity, [DWGAcadSupportedProxyProxy](../objects/DWGAcadSupportedProxyProxy.md).ParentEntity, [DWGArc](../objects/DWGArc.md).ParentEntity, [DWGArcProxy](../objects/DWGArcProxy.md).ParentEntity, [DWGBlockReference](../objects/DWGBlockReference.md).ParentEntity, [DWGBlockReferenceProxy](../objects/DWGBlockReferenceProxy.md).ParentEntity, [DWGEllipticalArc](../objects/DWGEllipticalArc.md).ParentEntity, [DWGEllipticalArcProxy](../objects/DWGEllipticalArcProxy.md).ParentEntity, [DWGEntitiesEnumerator](../objects/DWGEntitiesEnumerator.md).Item, [DWGEntity](../objects/DWGEntity.md).ParentEntity, [DWGEntityArcSegment](../objects/DWGEntityArcSegment.md).Parent, [DWGEntityEllipticalArcSegment](../objects/DWGEntityEllipticalArcSegment.md).Parent, [DWGEntityLineSegment](../objects/DWGEntityLineSegment.md).Parent, [DWGEntityProxy](../objects/DWGEntityProxy.md).NativeObject, [DWGEntityProxy](../objects/DWGEntityProxy.md).ParentEntity, [DWGEntitySegment](../objects/DWGEntitySegment.md).Parent, [DWGEntitySegmentProxy](../objects/DWGEntitySegmentProxy.md).ParentEntity, [DWGEntitySplineSegment](../objects/DWGEntitySplineSegment.md).Parent, [DWGLine](../objects/DWGLine.md).ParentEntity, [DWGLineProxy](../objects/DWGLineProxy.md).ParentEntity, [DWGPoint](../objects/DWGPoint.md).ParentEntity, [DWGPointProxy](../objects/DWGPointProxy.md).ParentEntity, [DWGPolyline](../objects/DWGPolyline.md).ParentEntity, [DWGPolyline2D](../objects/DWGPolyline2D.md).ParentEntity, [DWGPolyline2DProxy](../objects/DWGPolyline2DProxy.md).ParentEntity, [DWGPolyline3D](../objects/DWGPolyline3D.md).ParentEntity, [DWGPolyline3DProxy](../objects/DWGPolyline3DProxy.md).ParentEntity, [DWGPolylineProxy](../objects/DWGPolylineProxy.md).ParentEntity, [DWGSpline](../objects/DWGSpline.md).ParentEntity, [DWGSplineProxy](../objects/DWGSplineProxy.md).ParentEntity

**Referenced types:** [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

