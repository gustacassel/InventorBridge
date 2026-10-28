# EnvironmentList

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.ParallelEnvironments`

```csharp
interface EnvironmentList
{
    // Properties
    Application Application { get; }
    int Count { get; }
    Environment Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(Environment Environment);
    void Remove(int Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [UserInterfaceManager](../objects/UserInterfaceManager.md).ParallelEnvironments

**Referenced types:** [Application](../objects/Application.md), [Environment](../objects/Environment.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

