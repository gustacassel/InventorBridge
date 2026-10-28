# ReferenceKeyEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ReferenceKeyEvents
{
    // Properties
    object Application { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnBindKeyToObject(out byte[] ReferenceKey, object Document, out object Object, out SolutionNatureEnum MatchType, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SolutionNatureEnum](../enums/SolutionNatureEnum.md)

