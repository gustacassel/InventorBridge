# ModelState

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelStates.Item[…]`

```csharp
interface ModelState
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ObjectCollection ChildModelStates { get; } // since 2026
    ModelState DelegateModelState { get; set; } // since 2026
    Document Document { get; }
    Document FactoryDocument { get; }
    ModelStateMemberGenerationStatusEnum GenerateOnSaveStatus { get; set; } // since 2027
    ModelStateMemberDocumentStatusEnum MemberDocumentStatus { get; } // since 2027
    bool ModelStateDelegationAssociative { get; set; } // since 2026
    ModelStateTypeEnum ModelStateType { get; }
    string Name { get; set; }
    ComponentDefinition Parent { get; }
    DocumentDescriptor SubstituteDocumentDescriptor { get; }
    ComponentOccurrence SubstituteOccurrence { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Activate();
    ModelState Copy(string NewName = "");
    DesignViewRepresentation CopyComponentSuppressionToVisibility(string NewName = "");
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void RemoveChildModelStates(); // since 2026
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DesignViewRepresentation](../objects/DesignViewRepresentation.md).CopyComponentVisibilityToSuppression, [ModelState](../objects/ModelState.md).Copy, [ModelState](../objects/ModelState.md).DelegateModelState, [ModelStates](../objects/ModelStates.md).ActiveModelState, [ModelStates](../objects/ModelStates.md).Add, [ModelStates](../objects/ModelStates.md).AddSubstitute, [ModelStates](../objects/ModelStates.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DesignViewRepresentation](../objects/DesignViewRepresentation.md), [Document](../objects/Document.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [ModelStateMemberDocumentStatusEnum](../enums/ModelStateMemberDocumentStatusEnum.md), [ModelStateMemberGenerationStatusEnum](../enums/ModelStateMemberGenerationStatusEnum.md), [ModelStateTypeEnum](../enums/ModelStateTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

