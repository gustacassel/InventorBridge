# ISequentialStream

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ISequentialStream
{
    // Methods
    void RemoteRead(out byte pv, uint cb, out uint pcbRead);
    void RemoteWrite(ref byte pv, uint cb, out uint pcbWritten);
}
```

