# ImportedDWGComponentDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ImportedDWGComponentDefinition
{
    // Properties
    object Application { get; }
    object DWGReferenceOrigin { get; set; }
    Point2d DWGReferenceOriginInLocationPlane { get; set; }
    object DWGRotationInLocationPlane { get; set; }
    string FullFileName { get; }
    ImportDWGBodyStyleEnum ImportDWGBodyStyle { get; set; }
    object LocationOrigin { get; set; }
    object LocationPlane { get; set; }
    ImportedComponent Parent { get; }
    Matrix Transformation { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    ImportedDWGComponentDefinition Copy();
    void SetLocation(object LocationPlane, object LocationOrigin);
}
```

**Returned by:** [ImportedDWGComponentDefinition](../objects/ImportedDWGComponentDefinition.md).Copy

**Referenced types:** [ImportDWGBodyStyleEnum](../enums/ImportDWGBodyStyleEnum.md), [ImportedComponent](../objects/ImportedComponent.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

