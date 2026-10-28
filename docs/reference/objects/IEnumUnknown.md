# IEnumUnknown

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IEnumUnknown
{
    // Methods
    void Clone(out IEnumUnknown ppEnum);
    void RemoteNext(uint celt, out object rgelt, out uint pceltFetched);
    void Reset();
    void Skip(uint celt);
}
```

