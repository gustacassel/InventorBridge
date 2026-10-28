# IStream

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IStream
{
    // Methods
    void Clone(out IStream ppstm);
    void Commit(uint grfCommitFlags);
    void LockRegion(_ULARGE_INTEGER libOffset, _ULARGE_INTEGER cb, uint dwLockType);
    void RemoteCopyTo(IStream pstm, _ULARGE_INTEGER cb, out _ULARGE_INTEGER pcbRead, out _ULARGE_INTEGER pcbWritten);
    void RemoteRead(out byte pv, uint cb, out uint pcbRead);
    void RemoteSeek(_LARGE_INTEGER dlibMove, uint dwOrigin, out _ULARGE_INTEGER plibNewPosition);
    void RemoteWrite(ref byte pv, uint cb, out uint pcbWritten);
    void Revert();
    void SetSize(_ULARGE_INTEGER libNewSize);
    void Stat(out tagSTATSTG pstatstg, uint grfStatFlag);
    void UnlockRegion(_ULARGE_INTEGER libOffset, _ULARGE_INTEGER cb, uint dwLockType);
}
```

