# ImportedComponents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents`

```csharp
interface ImportedComponents
{
    // Properties
    object Application { get; }
    int Count { get; }
    ImportedComponent Item[object Index] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ImportedComponent Add(ImportedComponentDefinition Definition);
    ImportedComponentDefinition CreateDataExchangeDefinition(string exchangeUrn, object Options = Missing);
    ImportedComponentDefinition CreateDefinition(string FullFileName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).ImportedComponents, [ReferenceComponents](../objects/ReferenceComponents.md).ImportedComponents, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).ImportedComponents

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [ImportedComponent](../objects/ImportedComponent.md), [ImportedComponentDefinition](../objects/ImportedComponentDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

