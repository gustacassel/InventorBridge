# IPersistFile

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IPersistFile
{
    // Methods
    void GetClassID(out Guid pClassID);
    void GetCurFile(out string ppszFileName);
    void IsDirty();
    void Load(string pszFileName, uint dwMode);
    void Save(string pszFileName, int fRemember);
    void SaveCompleted(string pszFileName);
}
```

