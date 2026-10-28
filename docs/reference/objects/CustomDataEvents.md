# CustomDataEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface CustomDataEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnExecuteCustomAction(NameValueMap Context, NameValueMap CustomData);
    event OnRequestCustomData(NameValueMap Context, out NameValueMap CustomData);
}
```

**Referenced types:** [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

