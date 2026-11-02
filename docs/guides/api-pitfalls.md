# API pitfalls

> The mistakes that most often break Inventor scripts in C#: units, indices, VARIANT arguments, indexed properties, arrays, proxies.

## Units

- Lengths are always cm and angles radians, whatever the document units. Use `Mm(x)` and `Deg(x)`.
- The tools (`inspect`, `topology`, `expect`) report and take mm. Only the API itself uses cm.
- `object` arguments (VARIANT) such as distances and offsets take a number in API units, or an expression string with its unit (`"25 mm"`, `"90 deg"`), or a parameter name.

## Collections

- Collections are 1-based: `Faces[1]` is the first face, and `Faces[0]` is an error.
- `foreach (Face face in body.Faces)` works. COM collections are not generic, so start LINQ with `.Cast<T>()`: `body.Faces.Cast<Face>().Where(face => face.SurfaceType == SurfaceTypeEnum.kPlaneSurface)`.
- Build a collection to pass to the API with `Objects.CreateObjectCollection()`, then `.Add(item)`.

## Types and casts

- `App.ActiveDocument` is a `Document`. Cast it to `PartDocument`, `AssemblyDocument` or `DrawingDocument` to reach `ComponentDefinition`.
- The interop hides COM inheritance: an `ExtrudeFeature` is also a `PartFeature`, a `PartDocument` is also a `Document`. `api_lookup` shows "Inherits from".
- Enum values start with `k`: `DocumentTypeEnum.kPartDocumentObject`, `PartFeatureOperationEnum.kJoinOperation`.

## Indexed properties and methods with array arguments

- Some properties take an argument. C# calls them with brackets, such as `attributeSets.NameIsUsed["Set"]` or `occurrences.ItemByName["Tube:1"]`.
- A few properties have a getter and a setter of different types and cannot be used as properties. Call `get_X()` and `set_X(value)`: for example `parameter.get_Units()`.
- Methods that fill arrays take them with `ref` and need arrays created first. For example:

```csharp
var body = ((PartDocument)ActiveDocument!).ComponentDefinition.SurfaceBodies[1];
Face face = body.Faces[1];
double[] points = { face.PointOnFace.X, face.PointOnFace.Y, face.PointOnFace.Z };
double[] normals = new double[3];
face.Evaluator.GetNormalAtPoint(ref points, ref normals);
return $"{normals[0]}, {normals[1]}, {normals[2]}";
```

- `out` parameters are real outputs: `occurrence.GetDegreesOfFreedom(out int translations, out _, out int rotations, out _, out _)`.

## Assemblies: proxies

- A face, edge or work plane of a part is not valid in an assembly. Use its proxy: `occurrence.CreateGeometryProxy(entity, out object proxy)`, or `Named(occurrence, "name")` for named entities.
- `occurrence.SurfaceBodies` already returns proxies, in assembly coordinates.
- A proxy's `NativeObject` is the entity in the part.

## Errors

- `COMException` with `E_INVALIDARG` (0x80070057) usually means a wrong argument: a part entity used instead of a proxy, a wrong enum value, or a value in mm instead of cm.
- `E_FAIL` (0x80004005) often means the geometry could not be built: a profile that is not closed, or an extent that does not reach anything. Check the sketch and the numbers.
- A failed feature can leave a sketch behind. The transaction rolls it back only in the document that was active when the script started.
