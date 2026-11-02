# SurfaceEvaluator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreatePlane(…).Evaluator`

```csharp
interface SurfaceEvaluator
{
    // Properties
    double Area { get; }
    int Continuity { get; }
    bool IsExtrudedShape { get; }
    bool IsParamOnFace[ref double[] Params] { get; }
    bool IsRevolvedShape { get; }
    Box2d ParamRangeRect { get; }
    Box RangeBox { get; }
    // Methods
    object Get3dCurveFrom2dCurve(object Curve2d);
    void GetCurvatures(ref double[] Params, ref double[] MaxTangents, ref double[] MaxCurvatures, ref double[] MinCurvatures);
    void GetFirstDerivatives(ref double[] Params, ref double[] UPartials, ref double[] VPartials);
    ObjectCollection GetIsoCurve(double Parameter, bool UDirection);
    void GetNormal(ref double[] Params, ref double[] Normals);
    void GetNormalAtPoint(ref double[] Points, ref double[] Normals);
    void GetParamAnomaly(ref double[] PeriodicityU, ref double[] PeriodicityV, out int NumEndSingularitiesU, ref double[] SingularitiesU, out int NumEndSingularitiesV, ref double[] SingularitiesV, ref bool[] UnboundedParams);
    void GetParamAtPoint(ref double[] Points, ref double[] GuessParams, ref double[] MaxDeviations, ref double[] Params, ref SolutionNatureEnum[] SolutionNatures);
    void GetPointAtParam(ref double[] Params, ref double[] Points);
    void GetSecondDerivatives(ref double[] Params, ref double[] UUPartials, ref double[] UVPartials, ref double[] VVPartials);
    void GetTangents(ref double[] Params, ref double[] UTangents, ref double[] VTangents);
    void GetThirdDerivatives(ref double[] Params, ref double[] UUUPartials, ref double[] VVVPartials);
}
```

**Returned by:** [BSplineSurface](../objects/BSplineSurface.md).Evaluator, [Cone](../objects/Cone.md).Evaluator, [Cylinder](../objects/Cylinder.md).Evaluator, [EllipticalCone](../objects/EllipticalCone.md).Evaluator, [EllipticalCylinder](../objects/EllipticalCylinder.md).Evaluator, [Face](../objects/Face.md).Evaluator, [FaceProxy](../objects/FaceProxy.md).Evaluator, [MeshFace](../objects/MeshFace.md).Evaluator, [MeshFaceProxy](../objects/MeshFaceProxy.md).Evaluator, [Plane](../objects/Plane.md).Evaluator, [PresentationFace](../objects/PresentationFace.md).Evaluator, [Sphere](../objects/Sphere.md).Evaluator, [Torus](../objects/Torus.md).Evaluator

**Referenced types:** [Box](../objects/Box.md), [Box2d](../objects/Box2d.md), [ObjectCollection](../objects/ObjectCollection.md), [SolutionNatureEnum](../enums/SolutionNatureEnum.md)

