# iAssemblyMember

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iAssemblyMember`

```csharp
interface iAssemblyMember
{
    // Properties
    object Application { get; }
    HealthStatusEnum HealthStatus { get; }
    AssemblyComponentDefinition Parent { get; }
    iAssemblyFactory ParentFactory { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    iAssemblyTableRow Row { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLinkToFactory();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).iAssemblyMember, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).iAssemblyMember

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iAssemblyFactory](../objects/iAssemblyFactory.md), [iAssemblyTableRow](../objects/iAssemblyTableRow.md)

