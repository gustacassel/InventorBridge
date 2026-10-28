# BreakOutOperation

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].BreakOutOperations.Item[…]`

```csharp
interface BreakOutOperation
{
    // Properties
    ObjectsEnumerator AllAffectedViews { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    BreakOutDepthTypeEnum DepthType { get; }
    bool DisplayComponentsWithinTheSectionCut { get; set; }
    DrawingView Parent { get; }
    Profile Profile { get; set; }
    bool SectionAllParts { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetDepth(out object DepthSource, out double DepthValue);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetDepth(object DepthSource = Missing, double DepthValue = 0);
}
```

**Returned by:** [BreakOutOperations](../objects/BreakOutOperations.md).Add, [BreakOutOperations](../objects/BreakOutOperations.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BreakOutDepthTypeEnum](../enums/BreakOutDepthTypeEnum.md), [DrawingView](../objects/DrawingView.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Profile](../objects/Profile.md)

