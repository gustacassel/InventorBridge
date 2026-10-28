# iPartMember

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ReferenceComponent](../objects/ReferenceComponent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iPartMember`

```csharp
interface iPartMember
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool CustomMember { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    bool LinkedToFile { get; }
    string Name { get; }
    ComponentDefinition Parent { get; }
    iPartFactory ParentFactory { get; }
    ReferenceFeature PrimaryBody { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    iPartTableRow Row { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLinkToFactory();
    void BreakLinkToFile();
    void ChangeRow(object NewRow, object CustomInput = Missing);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEndOfPart(bool Before);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartComponentDefinition](../objects/PartComponentDefinition.md).iPartMember, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).iPartMember, [iPartFactory](../objects/iPartFactory.md).CreateCustomMember, [iPartFactory](../objects/iPartFactory.md).CreateMember

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceFeature](../objects/ReferenceFeature.md), [iPartFactory](../objects/iPartFactory.md), [iPartTableRow](../objects/iPartTableRow.md)

