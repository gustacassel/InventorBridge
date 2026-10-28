# SurfaceBodyDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…)`

```csharp
interface SurfaceBodyDefinition
{
    // Properties
    object Application { get; }
    EdgeDefinitions EdgeDefinitions { get; }
    LumpDefinitions LumpDefinitions { get; }
    ObjectTypeEnum Type { get; }
    VertexDefinitions VertexDefinitions { get; }
    // Methods
    SurfaceBody CreateTransientSurfaceBody(out NameValueMap Errors, object Options = Missing);
}
```

**Returned by:** [TransientBRep](../objects/TransientBRep.md).CreateSurfaceBodyDefinition

**Referenced types:** [EdgeDefinitions](../objects/EdgeDefinitions.md), [LumpDefinitions](../objects/LumpDefinitions.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md), [VertexDefinitions](../objects/VertexDefinitions.md)

