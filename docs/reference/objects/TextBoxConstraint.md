# TextBoxConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface TextBoxConstraint
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Deletable { get; }
    Sketch Parent { get; }
    TextBox TextBox { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [TextBoxConstraintProxy](../objects/TextBoxConstraintProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [TextBox](../objects/TextBox.md)

