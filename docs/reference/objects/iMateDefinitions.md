# iMateDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iMateDefinitions`

```csharp
interface iMateDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    iMateDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AngleiMateDefinition AddAngleiMateDefinition(object Entity, bool DirectionReversed, object Angle, object BiasPoint = Missing, string Name = "", object MatchList = Missing);
    CompositeiMateDefinition AddCompositeiMateDefinition(ObjectCollection iMates, string Name = "", object MatchList = Missing);
    FlushiMateDefinition AddFlushiMateDefinition(object Entity, object Offset, object BiasPoint = Missing, string Name = "", object MatchList = Missing);
    InsertiMateDefinition AddInsertiMateDefinition(object Entity, bool AxesOpposed, object Distance, object BiasPoint = Missing, string Name = "", object MatchList = Missing);
    MateiMateDefinition AddMateiMateDefinition(object Entity, object Offset, InferredTypeEnum EntityInferredType = InferredTypeEnum.kNoInference, object BiasPoint = Missing, string Name = "", object MatchList = Missing);
    RotateRotateiMateDefinition AddRotateRotateiMateDefinition(object Entity, object Ratio, bool ForwardDirection, object BiasPoint = Missing, string Name = "", object MatchList = Missing);
    RotateTranslateiMateDefinition AddRotateTranslateiMateDefinition(object Entity, object Ratio, bool ForwardDirection, object BiasPoint = Missing, string Name = "", object MatchList = Missing);
    TangentiMateDefinition AddTangentiMateDefinition(object Entity, bool InsideTangency, object Offset, object BiasPoint = Missing, string Name = "", object MatchList = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).iMateDefinitions, [PartComponentDefinition](../objects/PartComponentDefinition.md).iMateDefinitions, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).iMateDefinitions, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).iMateDefinitions

**Referenced types:** [AngleiMateDefinition](../objects/AngleiMateDefinition.md), [CompositeiMateDefinition](../objects/CompositeiMateDefinition.md), [FlushiMateDefinition](../objects/FlushiMateDefinition.md), [InferredTypeEnum](../enums/InferredTypeEnum.md), [InsertiMateDefinition](../objects/InsertiMateDefinition.md), [MateiMateDefinition](../objects/MateiMateDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RotateRotateiMateDefinition](../objects/RotateRotateiMateDefinition.md), [RotateTranslateiMateDefinition](../objects/RotateTranslateiMateDefinition.md), [TangentiMateDefinition](../objects/TangentiMateDefinition.md), [iMateDefinition](../objects/iMateDefinition.md)

