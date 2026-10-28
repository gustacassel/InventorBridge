# CommandTypesEnum

Inventor API enum · versions: 2024+ · [index](../index.md)

```csharp
enum CommandTypesEnum
{
    kShapeEditCmdType = 1,
    kQueryOnlyCmdType = 2,
    kFileOperationsCmdType = 4,
    kFilePropertyEditCmdType = 8,
    kUpdateWithReferencesCmdType = 16,
    kNonShapeEditCmdType = 32,
    kEditMaskCmdType = 57,
    kReferencesChangeCmdType = 64,
    kSchemaChangeCmdType = 128,
    kModelStateUpdatesCmdType = 256,
    kModelStateSmudgeCmdType = 512,
    kViewRepSmudgeCmdType = 1024,
}
```

**Used by:** [ApplicationEvents](../objects/ApplicationEvents.md).OnDocumentChange, [AssemblyDocument](../objects/AssemblyDocument.md).DisabledCommandTypes, [AssemblyDocument](../objects/AssemblyDocument.md).GetMissingAddInBehavior, [AssemblyDocument](../objects/AssemblyDocument.md).RecentChanges, [AssemblyDocument](../objects/AssemblyDocument.md).SetMissingAddInBehavior, [ButtonDefinition](../objects/ButtonDefinition.md).Classification, [ChangeDefinition](../objects/ChangeDefinition.md).ChangeType, [ChangeProcessor](../objects/ChangeProcessor.md).ChangeType, [ComboBoxDefinition](../objects/ComboBoxDefinition.md).Classification, [ControlDefinition](../objects/ControlDefinition.md).Classification, [ControlDefinitions](../objects/ControlDefinitions.md).AddButtonDefinition, [ControlDefinitions](../objects/ControlDefinitions.md).AddComboBoxDefinition, [Document](../objects/Document.md).DisabledCommandTypes, [Document](../objects/Document.md).GetMissingAddInBehavior, [Document](../objects/Document.md).RecentChanges, [Document](../objects/Document.md).SetMissingAddInBehavior, [DocumentEvents](../objects/DocumentEvents.md).OnChange, [DrawingDocument](../objects/DrawingDocument.md).DisabledCommandTypes, [DrawingDocument](../objects/DrawingDocument.md).GetMissingAddInBehavior, [DrawingDocument](../objects/DrawingDocument.md).RecentChanges, [DrawingDocument](../objects/DrawingDocument.md).SetMissingAddInBehavior, [DrawingViewEvents](../objects/DrawingViewEvents.md).OnViewUpdate, [Environment](../objects/Environment.md).DisabledCommandTypes, [MacroControlDefinition](../objects/MacroControlDefinition.md).Classification, [PartDocument](../objects/PartDocument.md).DisabledCommandTypes, [PartDocument](../objects/PartDocument.md).GetMissingAddInBehavior, [PartDocument](../objects/PartDocument.md).RecentChanges, [PartDocument](../objects/PartDocument.md).SetMissingAddInBehavior, [PresentationDocument](../objects/PresentationDocument.md).DisabledCommandTypes, [PresentationDocument](../objects/PresentationDocument.md).GetMissingAddInBehavior, [PresentationDocument](../objects/PresentationDocument.md).RecentChanges, [PresentationDocument](../objects/PresentationDocument.md).SetMissingAddInBehavior, [PresentationEvents](../objects/PresentationEvents.md).OnPublicationModelingDataUpdate, [PresentationEvents](../objects/PresentationEvents.md).OnStoryboardChange

