# TextBoxConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface TextBoxConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    TextBoxConstraint NativeObject { get; }
    Sketch Parent { get; }
    TextBox TextBox { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [TextBox](../objects/TextBox.md), [TextBoxConstraint](../objects/TextBoxConstraint.md)

