# ReferenceKeyEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ReferenceKeyEvents
{
    // Properties
    object Application { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnBindKeyToObject(ref byte[] ReferenceKey, object Document, ref object Object, out SolutionNatureEnum MatchType, NameValueMap Context, ref HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SolutionNatureEnum](../enums/SolutionNatureEnum.md)

