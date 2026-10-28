# ReferenceComponents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents`

```csharp
interface ReferenceComponents
{
    // Properties
    object Application { get; }
    DerivedAliasComponents DerivedAliasComponents { get; }
    DerivedAssemblyComponents DerivedAssemblyComponents { get; }
    DerivedFutureAssemblyComponents DerivedFutureAssemblyComponents { get; }
    DerivedFuturePartComponents DerivedFuturePartComponents { get; }
    DerivedPartComponents DerivedPartComponents { get; }
    ImportedComponents ImportedComponents { get; }
    ShrinkwrapComponents ShrinkwrapComponents { get; }
    ObjectTypeEnum Type { get; }
    iFeatureTemplateDescriptors iFeatureTemplateDescriptors { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartComponentDefinition](../objects/PartComponentDefinition.md).ReferenceComponents, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).ReferenceComponents

**Referenced types:** [DerivedAliasComponents](../objects/DerivedAliasComponents.md), [DerivedAssemblyComponents](../objects/DerivedAssemblyComponents.md), [DerivedFutureAssemblyComponents](../objects/DerivedFutureAssemblyComponents.md), [DerivedFuturePartComponents](../objects/DerivedFuturePartComponents.md), [DerivedPartComponents](../objects/DerivedPartComponents.md), [ImportedComponents](../objects/ImportedComponents.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ShrinkwrapComponents](../objects/ShrinkwrapComponents.md), [iFeatureTemplateDescriptors](../objects/iFeatureTemplateDescriptors.md)

