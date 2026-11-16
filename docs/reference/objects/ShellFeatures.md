# ShellFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ShellFeatures`

```csharp
interface ShellFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ShellFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ShellFeature Add(ShellDefinition Definition);
    ShellDefinition CreateDefinition(object InputFaces = Missing, object Solids = Missing, object Thickness = Missing, ShellDirectionEnum Direction = ShellDirectionEnum.kInsideShellDirection, ShellMethodEnum Method = ShellMethodEnum.kSharpShellMethod, object MoreOptions = Missing); // since 2026
    ShellDefinition CreateShellDefinition(object InputFaces = Missing, object Thickness = Missing, ShellDirectionEnum Direction = ShellDirectionEnum.kInsideShellDirection); // hidden in 2026, 2027: there, prefer the newer members
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).ShellFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ShellFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ShellDefinition](../objects/ShellDefinition.md), [ShellDirectionEnum](../enums/ShellDirectionEnum.md), [ShellFeature](../objects/ShellFeature.md), [ShellMethodEnum](../enums/ShellMethodEnum.md)

