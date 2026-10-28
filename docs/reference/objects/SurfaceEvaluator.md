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
    bool IsParamOnFace[out double[] Params] { get; }
    bool IsRevolvedShape { get; }
    Box2d ParamRangeRect { get; }
    Box RangeBox { get; }
    // Methods
    object Get3dCurveFrom2dCurve(object Curve2d);
    void GetCurvatures(out double[] Params, out double[] MaxTangents, out double[] MaxCurvatures, out double[] MinCurvatures);
    void GetFirstDerivatives(out double[] Params, out double[] UPartials, out double[] VPartials);
    ObjectCollection GetIsoCurve(double Parameter, bool UDirection);
    void GetNormal(out double[] Params, out double[] Normals);
    void GetNormalAtPoint(out double[] Points, out double[] Normals);
    void GetParamAnomaly(out double[] PeriodicityU, out double[] PeriodicityV, out int NumEndSingularitiesU, out double[] SingularitiesU, out int NumEndSingularitiesV, out double[] SingularitiesV, out bool[] UnboundedParams);
    void GetParamAtPoint(out double[] Points, out double[] GuessParams, out double[] MaxDeviations, out double[] Params, out SolutionNatureEnum[] SolutionNatures);
    void GetPointAtParam(out double[] Params, out double[] Points);
    void GetSecondDerivatives(out double[] Params, out double[] UUPartials, out double[] UVPartials, out double[] VVPartials);
    void GetTangents(out double[] Params, out double[] UTangents, out double[] VTangents);
    void GetThirdDerivatives(out double[] Params, out double[] UUUPartials, out double[] VVVPartials);
}
```

**Returned by:** [BSplineSurface](../objects/BSplineSurface.md).Evaluator, [Cone](../objects/Cone.md).Evaluator, [Cylinder](../objects/Cylinder.md).Evaluator, [EllipticalCone](../objects/EllipticalCone.md).Evaluator, [EllipticalCylinder](../objects/EllipticalCylinder.md).Evaluator, [Face](../objects/Face.md).Evaluator, [FaceProxy](../objects/FaceProxy.md).Evaluator, [MeshFace](../objects/MeshFace.md).Evaluator, [MeshFaceProxy](../objects/MeshFaceProxy.md).Evaluator, [Plane](../objects/Plane.md).Evaluator, [PresentationFace](../objects/PresentationFace.md).Evaluator, [Sphere](../objects/Sphere.md).Evaluator, [Torus](../objects/Torus.md).Evaluator

**Referenced types:** [Box](../objects/Box.md), [Box2d](../objects/Box2d.md), [ObjectCollection](../objects/ObjectCollection.md), [SolutionNatureEnum](../enums/SolutionNatureEnum.md)

