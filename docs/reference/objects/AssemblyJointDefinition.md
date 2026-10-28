# AssemblyJointDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Joints.Item[…].Definition`

```csharp
interface AssemblyJointDefinition
{
    // Properties
    object AlignmentOne { get; set; }
    object AlignmentTwo { get; set; }
    object AngularPosition { get; set; }
    object AngularPositionEndLimit { get; set; }
    object AngularPositionStartLimit { get; set; }
    object Application { get; }
    bool FlipAlignmentDirection { get; set; }
    bool FlipOriginDirection { get; set; }
    object Gap { get; set; }
    bool HasAngularPositionLimits { get; set; }
    bool HasLinearPositionEndLimit { get; set; }
    bool HasLinearPositionStartLimit { get; set; }
    AssemblyJointTypeEnum JointType { get; set; }
    object LinearPosition { get; set; }
    object LinearPositionEndLimit { get; set; }
    object LinearPositionStartLimit { get; set; }
    GeometryIntent OriginOne { get; set; }
    AssemblyJointOriginDefinitionTypeEnum OriginOneDefinitionType { get; }
    FaceCollection OriginOneReferencedFaces { get; }
    object OriginOneXOffset { get; }
    object OriginOneXOffsetReferencedGeometry { get; }
    object OriginOneYOffset { get; }
    object OriginOneYOffsetReferencedGeometry { get; }
    GeometryIntent OriginTwo { get; set; }
    AssemblyJointOriginDefinitionTypeEnum OriginTwoDefinitionType { get; }
    FaceCollection OriginTwoReferencedFaces { get; }
    object OriginTwoXOffset { get; }
    object OriginTwoXOffsetReferencedGeometry { get; }
    object OriginTwoYOffset { get; }
    object OriginTwoYOffsetReferencedGeometry { get; }
    AssemblyJoint Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AssemblyJointDefinition Copy();
    void SetOriginOneAsBetweenTwoFaces(FaceCollection ReferencedFaces);
    void SetOriginOneAsInfer();
    void SetOriginOneAsOffset(object XOffset, object YOffset);
    void SetOriginTwoAsBetweenTwoFaces(FaceCollection ReferencedFaces);
    void SetOriginTwoAsInfer();
    void SetOriginTwoAsOffset(object XOffset, object YOffset);
}
```

**Returned by:** [AssemblyJoint](../objects/AssemblyJoint.md).Definition, [AssemblyJointDefinition](../objects/AssemblyJointDefinition.md).Copy, [AssemblyJointProxy](../objects/AssemblyJointProxy.md).Definition, [AssemblyJoints](../objects/AssemblyJoints.md).CreateAssemblyJointDefinition

**Referenced types:** [AssemblyJoint](../objects/AssemblyJoint.md), [AssemblyJointOriginDefinitionTypeEnum](../enums/AssemblyJointOriginDefinitionTypeEnum.md), [AssemblyJointTypeEnum](../enums/AssemblyJointTypeEnum.md), [FaceCollection](../objects/FaceCollection.md), [GeometryIntent](../objects/GeometryIntent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

