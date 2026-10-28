# MarkDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MarkFeatures.Item[…].Definition`

```csharp
interface MarkDefinition
{
    // Properties
    object Application { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
    int MarkGeometrySetCount { get; }
    MarkFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MarkGeometrySet AddGeometrySet(ObjectCollection Geometries, MarkStyle pStyle);
    MarkDefinition Copy();
    void GetMethod(out MarkMethodTypeEnum Method, out object pFaces = Missing, out object chain = Missing);
    MarkGeometrySet MarkGeometrySetItem(int Index);
    void SetMethod(MarkMethodTypeEnum Method, object Faces = Missing, object chain = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [MarkDefinition](../objects/MarkDefinition.md).Copy, [MarkFeature](../objects/MarkFeature.md).Definition, [MarkFeatureProxy](../objects/MarkFeatureProxy.md).Definition, [MarkFeatures](../objects/MarkFeatures.md).CreateMarkDefinition

**Referenced types:** [MarkFeature](../objects/MarkFeature.md), [MarkGeometrySet](../objects/MarkGeometrySet.md), [MarkMethodTypeEnum](../enums/MarkMethodTypeEnum.md), [MarkStyle](../objects/MarkStyle.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md)

