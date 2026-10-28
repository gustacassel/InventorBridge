# DerivedPartComponents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedPartComponents`

```csharp
interface DerivedPartComponents
{
    // Properties
    object Application { get; }
    int Count { get; }
    DerivedPartComponent Item[int Value] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DerivedPartComponent Add(DerivedPartDefinition Definition);
    DerivedPartCoordinateSystemDef CreateCoordinateSystemDef(string FullFileName);
    DerivedPartTransformDef CreateTransformDef(string FullFileName);
    DerivedPartUniformScaleDef CreateUniformScaleDef(string FullFileName);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ReferenceComponents](../objects/ReferenceComponents.md).DerivedPartComponents

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [DerivedPartComponent](../objects/DerivedPartComponent.md), [DerivedPartCoordinateSystemDef](../objects/DerivedPartCoordinateSystemDef.md), [DerivedPartDefinition](../objects/DerivedPartDefinition.md), [DerivedPartTransformDef](../objects/DerivedPartTransformDef.md), [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

