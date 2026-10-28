# DesignViewRepresentation

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.RepresentationsManager.DesignViewRepresentations.Item[…]`

```csharp
interface DesignViewRepresentation
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool AutoSaveCamera { get; set; }
    Camera Camera { get; set; }
    string DesignViewInfo { get; }
    DesignViewTypeEnum DesignViewType { get; }
    bool IsSectionViewSuppressed { get; set; }
    bool Locked { get; set; }
    bool ModelAnnotationAutoScale { get; set; }
    double ModelAnnotationScale { get; set; }
    string Name { get; set; }
    RepresentationsManager Parent { get; }
    bool Publish { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Activate();
    DesignViewRepresentation Copy(string NewName = "");
    ModelState CopyComponentVisibilityToSuppression(string NewName = "");
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void GetSectionViewInfo(out SectionViewTypeEnum SectionViewType, out Plane FirstSectionPlane, out Plane SecondSectionPlane);
    void HideAll();
    void RemoveAppearanceOverrides();
    void RestoreCamera();
    void SaveCurrentCamera();
    void SetAllContentCenterComponentsVisibility(bool Visible);
    void SetSectionView(SectionViewTypeEnum SectionViewType, object FirstSectionPlane = Missing, object SecondSectionPlane = Missing);
    void SetVisibilityOfOccurrences(ObjectCollection Occurrences, bool Visible);
    void ShowAll();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DesignViewRepresentation](../objects/DesignViewRepresentation.md).Copy, [DesignViewRepresentations](../objects/DesignViewRepresentations.md).Add, [DesignViewRepresentations](../objects/DesignViewRepresentations.md).Item, [ModelState](../objects/ModelState.md).CopyComponentSuppressionToVisibility, [RepresentationsManager](../objects/RepresentationsManager.md).ActiveDesignViewRepresentation

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Camera](../objects/Camera.md), [DesignViewTypeEnum](../enums/DesignViewTypeEnum.md), [ModelState](../objects/ModelState.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Plane](../objects/Plane.md), [RepresentationsManager](../objects/RepresentationsManager.md), [SectionViewTypeEnum](../enums/SectionViewTypeEnum.md)

