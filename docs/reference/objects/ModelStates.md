# ModelStates

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelStates`

```csharp
interface ModelStates
{
    // Properties
    ModelState ActiveModelState { get; }
    object Application { get; }
    int Count { get; }
    object ExcelWorkSheet { get; }
    ModelStateMemberGenerationStatusEnum GenerateOnSaveStatus { get; set; } // since 2027
    ModelState Item[object Index] { get; }
    MemberEditScopeEnum MemberEditScope { get; set; }
    ModelStateTable ModelStateTable { get; }
    ObjectCollection ModelStatesInEdit { get; set; } // since 2026
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelState Add(string Name = "");
    ModelState AddSubstitute(string FullFileName, object Name = Missing, object SkipDocumentSave = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).ModelStates, [ModelStateTable](../objects/ModelStateTable.md).Parent, [PartComponentDefinition](../objects/PartComponentDefinition.md).ModelStates, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).ModelStates, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).ModelStates

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [MemberEditScopeEnum](../enums/MemberEditScopeEnum.md), [ModelState](../objects/ModelState.md), [ModelStateMemberGenerationStatusEnum](../enums/ModelStateMemberGenerationStatusEnum.md), [ModelStateTable](../objects/ModelStateTable.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

