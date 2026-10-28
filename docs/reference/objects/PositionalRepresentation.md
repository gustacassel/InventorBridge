# PositionalRepresentation

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.RepresentationsManager.PositionalRepresentations.Item[…]`

```csharp
interface PositionalRepresentation
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    string Name { get; set; }
    RepresentationsManager Parent { get; }
    bool Primary { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Activate();
    void ClearRelationshipOverrides(object Relationship);
    PositionalRepresentation Copy(string NewName = "");
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    bool IsFlexibleOverridden(ComponentOccurrence Occurrence, out bool Flexible);
    bool IsGroundingOverridden(ComponentOccurrence Occurrence, out bool Grounded);
    bool IsPatternAngleOffsetOverridden(CircularOccurrencePattern Pattern, out string AngleOffset);
    bool IsPatternColumnOffsetOverridden(RectangularOccurrencePattern Pattern, out string ColumnOffset);
    bool IsPatternRowOffsetOverridden(RectangularOccurrencePattern Pattern, out string RowOffset);
    bool IsPositionalRepresentationOverridden(ComponentOccurrence Occurrence, out string Representation);
    bool IsRelationshipSuppressionOverridden(object Relationship, out bool Suppressed);
    bool IsRelationshipValueOverridden(object Relationship, RelationshipValueTypeEnum RelationShipValueType, out string Expression);
    bool IsTransformOverridden(ComponentOccurrence Occurrence, out Matrix Transform);
    void RemoveFlexibleOverride(ComponentOccurrence Occurrence);
    void RemoveGroundingOverride(ComponentOccurrence Occurrence);
    void RemovePatternAngleOffsetOverride(CircularOccurrencePattern Pattern);
    void RemovePatternColumnOffsetOverride(RectangularOccurrencePattern Pattern);
    void RemovePatternRowOffsetOverride(RectangularOccurrencePattern Pattern);
    void RemovePositionalRepresentationOverride(ComponentOccurrence Occurrence);
    void RemoveRelationshipSuppressionOverride(object Relationship);
    void RemoveRelationshipValueOverride(object Relationship, RelationshipValueTypeEnum RelationShipValueType);
    void RemoveTransformOverride(ComponentOccurrence Occurrence);
    void SetFlexibleOverride(ComponentOccurrence Occurrence, bool Flexible);
    void SetGroundingOverride(ComponentOccurrence Occurrence, bool Grounded);
    void SetPatternAngleOffsetOverride(CircularOccurrencePattern Pattern, string AngleOffset);
    void SetPatternColumnOffsetOverride(RectangularOccurrencePattern Pattern, string ColumnOffset);
    void SetPatternRowOffsetOverride(RectangularOccurrencePattern Pattern, string RowOffset);
    void SetPositionalRepresentationOverride(ComponentOccurrence Occurrence, string Representation);
    void SetRelationshipSuppressionOverride(object Relationship, bool Suppressed);
    void SetRelationshipValueOverride(object Relationship, RelationshipValueTypeEnum RelationShipValueType, string Expression);
    void SetTransformOverride(ComponentOccurrence Occurrence, Matrix Transform);
}
```

7 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PositionalRepresentation](../objects/PositionalRepresentation.md).Copy, [PositionalRepresentations](../objects/PositionalRepresentations.md).Add, [PositionalRepresentations](../objects/PositionalRepresentations.md).Item, [RepresentationsManager](../objects/RepresentationsManager.md).ActivePositionalRepresentation

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [CircularOccurrencePattern](../objects/CircularOccurrencePattern.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RectangularOccurrencePattern](../objects/RectangularOccurrencePattern.md), [RelationshipValueTypeEnum](../enums/RelationshipValueTypeEnum.md), [RepresentationsManager](../objects/RepresentationsManager.md)

