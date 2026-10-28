# DocumentDescriptor

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ReferencedDocumentDescriptors.Item[…]`

```csharp
interface DocumentDescriptor
{
    // Properties
    object Application { get; }
    string DisplayName { get; }
    string FullDocumentName { get; }
    object Parent { get; }
    bool ReferenceDisabled { get; }
    bool ReferenceInternalNameDifferent { get; }
    bool ReferenceLocationDifferent { get; }
    bool ReferenceMissing { get; }
    bool ReferenceSuppressed { get; }
    object ReferencedDocument { get; }
    DocumentTypeEnum ReferencedDocumentType { get; }
    FileDescriptor ReferencedFileDescriptor { get; }
    ModelStateTypeEnum ReferencedModelState { get; }
    ObjectTypeEnum Type { get; }
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ComponentOccurrence](../objects/ComponentOccurrence.md).ReferencedDocumentDescriptor, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).ReferencedDocumentDescriptor, [DerivedAliasComponent](../objects/DerivedAliasComponent.md).ReferencedDocumentDescriptor, [DerivedAliasComponentProxy](../objects/DerivedAliasComponentProxy.md).ReferencedDocumentDescriptor, [DerivedAssemblyComponent](../objects/DerivedAssemblyComponent.md).ReferencedDocumentDescriptor, [DerivedAssemblyComponentProxy](../objects/DerivedAssemblyComponentProxy.md).ReferencedDocumentDescriptor, [DerivedFutureAssemblyComponent](../objects/DerivedFutureAssemblyComponent.md).ReferencedDocumentDescriptor, [DerivedFutureAssemblyComponentProxy](../objects/DerivedFutureAssemblyComponentProxy.md).ReferencedDocumentDescriptor, [DerivedFuturePartComponent](../objects/DerivedFuturePartComponent.md).ReferencedDocumentDescriptor, [DerivedFuturePartComponentProxy](../objects/DerivedFuturePartComponentProxy.md).ReferencedDocumentDescriptor, [DerivedParameterTable](../objects/DerivedParameterTable.md).ReferencedDocumentDescriptor, [DerivedPartComponent](../objects/DerivedPartComponent.md).ReferencedDocumentDescriptor, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).ReferencedDocumentDescriptor, [DetailDrawingView](../objects/DetailDrawingView.md).ReferencedDocumentDescriptor, [DocumentDescriptorsEnumerator](../objects/DocumentDescriptorsEnumerator.md).Item, [DrawingBOM](../objects/DrawingBOM.md).ReferencedDocumentDescriptor, [DrawingView](../objects/DrawingView.md).ReferencedDocumentDescriptor, [ImportedComponent](../objects/ImportedComponent.md).ReferencedDocumentDescriptor, [ImportedDWGComponent](../objects/ImportedDWGComponent.md).ReferencedDocumentDescriptor, [ImportedDWGComponentProxy](../objects/ImportedDWGComponentProxy.md).ReferencedDocumentDescriptor, [ImportedDataExchangeComponent](../objects/ImportedDataExchangeComponent.md).ReferencedDocumentDescriptor, [ImportedDataExchangeComponentProxy](../objects/ImportedDataExchangeComponentProxy.md).ReferencedDocumentDescriptor, [ImportedGenericComponent](../objects/ImportedGenericComponent.md).ReferencedDocumentDescriptor, [ImportedGenericComponentProxy](../objects/ImportedGenericComponentProxy.md).ReferencedDocumentDescriptor, [ImportedRVTComponent](../objects/ImportedRVTComponent.md).ReferencedDocumentDescriptor, [ImportedRVTComponentProxy](../objects/ImportedRVTComponentProxy.md).ReferencedDocumentDescriptor, [ModelState](../objects/ModelState.md).SubstituteDocumentDescriptor, [PartsList](../objects/PartsList.md).ReferencedDocumentDescriptor, [ReferenceComponent](../objects/ReferenceComponent.md).ReferencedDocumentDescriptor, [SectionDrawingView](../objects/SectionDrawingView.md).ReferencedDocumentDescriptor, [ShrinkwrapComponent](../objects/ShrinkwrapComponent.md).ReferencedDocumentDescriptor, [ShrinkwrapComponentProxy](../objects/ShrinkwrapComponentProxy.md).ReferencedDocumentDescriptor, [iAssemblyMember](../objects/iAssemblyMember.md).ReferencedDocumentDescriptor, [iPartMember](../objects/iPartMember.md).ReferencedDocumentDescriptor

**Referenced types:** [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [FileDescriptor](../objects/FileDescriptor.md), [ModelStateTypeEnum](../enums/ModelStateTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

