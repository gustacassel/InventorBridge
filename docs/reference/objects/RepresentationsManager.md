# RepresentationsManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.RepresentationsManager`

```csharp
interface RepresentationsManager
{
    // Properties
    DesignViewRepresentation ActiveDesignViewRepresentation { get; }
    PositionalRepresentation ActivePositionalRepresentation { get; }
    object Application { get; }
    DesignViewRepresentations DesignViewRepresentations { get; }
    ComponentDefinition Parent { get; }
    PositionalRepresentations PositionalRepresentations { get; }
    ObjectTypeEnum Type { get; }
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).RepresentationsManager, [DesignViewRepresentation](../objects/DesignViewRepresentation.md).Parent, [FlatPattern](../objects/FlatPattern.md).RepresentationsManager, [PartComponentDefinition](../objects/PartComponentDefinition.md).RepresentationsManager, [PositionalRepresentation](../objects/PositionalRepresentation.md).Parent, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).RepresentationsManager, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).RepresentationsManager

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [DesignViewRepresentation](../objects/DesignViewRepresentation.md), [DesignViewRepresentations](../objects/DesignViewRepresentations.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PositionalRepresentation](../objects/PositionalRepresentation.md), [PositionalRepresentations](../objects/PositionalRepresentations.md)

