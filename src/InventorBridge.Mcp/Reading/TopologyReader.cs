using System.Runtime.InteropServices;
using Inventor;
using InventorBridge.Mcp.Scripting;

namespace InventorBridge.Mcp.Reading
{
    public enum FaceDetail
    {
        All,
        Cylinders,
        None,
    }

    public enum EdgeDetail
    {
        All,
        Circles,
        None,
    }

    /// <summary>
    /// Lists the faces and edges of a part's bodies, or of one occurrence in an assembly, with what a script needs
    /// to pick them: 1-based index, type, a point, normals, cylinder axes and circle centers, in millimeters.
    /// </summary>
    /// <remarks>
    /// For an occurrence the entities are proxies in assembly coordinates, which is what assembly constraints
    /// take. Cylinders split into several faces are merged into one entry, with the centers of their circular
    /// edges (the open ends of a tube, for example).
    /// </remarks>
    public static class TopologyReader
    {
        private const double MillimetersPerCentimeter = 10.0;
        private const double SquareMillimetersPerSquareCentimeter = 100.0;
        private const double GeometryTolerance = 1e-6;
        private const int MaxNamesInError = 30;

        public static object Read(Application application, string? occurrenceName, string? bodyName,
            FaceDetail faceDetail, EdgeDetail edgeDetail, int maxItems)
        {
            var document = application.ActiveDocument
                ?? throw new InvalidOperationException("No document is open.");

            var (bodies, occurrence) = FindBodies(document, occurrenceName);

            var result = new Dictionary<string, object?>
            {
                ["document"] = document.DisplayName,
                ["occurrence"] = occurrence?.Name,
                ["coordinates"] = occurrence is null ? "part, mm" : "assembly, mm",
                ["howToUse"] = occurrence is null
                    ? "In a script: var body = ((PartDocument)ActiveDocument).ComponentDefinition.SurfaceBodies[b]; " +
                      "body.Faces[i], body.Edges[i] (1-based). Indices hold while the geometry does not change; name " +
                      "the entities you will reuse with Name(entity, \"name\")."
                    : $"In a script: var body = occurrence.SurfaceBodies[b], with the occurrence named \"{occurrence.Name}\"; " +
                      "body.Faces[i], body.Edges[i] (1-based) are proxies in the assembly, ready for constraints. " +
                      "Indices hold while the geometry does not change; Named(occurrence, \"name\") finds named entities.",
            };

            var bodyList = new List<object>();
            var bodyIndex = 0;
            foreach (SurfaceBody body in bodies)
            {
                bodyIndex++;
                if (bodyName is not null && !string.Equals(body.Name, bodyName, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                bodyList.Add(ReadBody(body, bodyIndex, faceDetail, edgeDetail, maxItems));
            }

            if (bodyList.Count == 0)
            {
                throw new InvalidOperationException(bodyName is null
                    ? "There are no bodies to read."
                    : $"There is no body named \"{bodyName}\". Leave body empty to list them all.");
            }

            result["bodies"] = bodyList;
            return result;
        }

        private static (SurfaceBodies Bodies, ComponentOccurrence? Occurrence) FindBodies(Document document, string? occurrenceName)
        {
            switch (document)
            {
                case PartDocument part:
                    return (part.ComponentDefinition.SurfaceBodies, null);
                case AssemblyDocument assembly:
                    var occurrences = assembly.ComponentDefinition.Occurrences;
                    if (string.IsNullOrWhiteSpace(occurrenceName))
                    {
                        throw new InvalidOperationException(
                            "The active document is an assembly: give the occurrence to read, one of: " + ListNames(occurrences));
                    }

                    var occurrence = FindOccurrence(occurrences, occurrenceName)
                        ?? throw new InvalidOperationException(
                            $"There is no occurrence named \"{occurrenceName}\". Top-level occurrences: " + ListNames(occurrences));
                    return (occurrence.SurfaceBodies, occurrence);
                default:
                    throw new InvalidOperationException("Topology can only be read from a part or an assembly.");
            }
        }

        /// <summary>A top-level occurrence by name, or else the first leaf occurrence with that name.</summary>
        private static ComponentOccurrence? FindOccurrence(ComponentOccurrences occurrences, string name)
        {
            foreach (ComponentOccurrence occurrence in occurrences)
            {
                if (string.Equals(occurrence.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return occurrence;
                }
            }

            foreach (ComponentOccurrence occurrence in occurrences.AllLeafOccurrences)
            {
                if (string.Equals(occurrence.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return occurrence;
                }
            }

            return null;
        }

        private static string ListNames(ComponentOccurrences occurrences)
        {
            var names = new List<string>();
            foreach (ComponentOccurrence occurrence in occurrences)
            {
                if (names.Count >= MaxNamesInError)
                {
                    names.Add("...");
                    break;
                }

                names.Add(occurrence.Name);
            }

            return names.Count == 0 ? "(none)" : string.Join(", ", names);
        }

        private static object ReadBody(SurfaceBody body, int bodyIndex, FaceDetail faceDetail, EdgeDetail edgeDetail, int maxItems)
        {
            var entry = new Dictionary<string, object?>
            {
                ["index"] = bodyIndex,
                ["name"] = body.Name,
                ["solid"] = body.IsSolid,
                ["faceCount"] = body.Faces.Count,
                ["edgeCount"] = body.Edges.Count,
            };

            switch (faceDetail)
            {
                case FaceDetail.All:
                    entry["faces"] = ReadFaces(body, maxItems);
                    break;
                case FaceDetail.Cylinders:
                    entry["cylinders"] = ReadCylinders(body, maxItems);
                    break;
            }

            if (edgeDetail != EdgeDetail.None)
            {
                entry["edges"] = ReadEdges(body, edgeDetail == EdgeDetail.Circles, maxItems);
            }

            return entry;
        }

        private static List<object> ReadFaces(SurfaceBody body, int maxItems)
        {
            var faces = new List<object>();
            var faceCount = body.Faces.Count;

            for (var index = 1; index <= faceCount && faces.Count < maxItems; index++)
            {
                var face = body.Faces[index];
                faces.Add(ReadEntity(index, () =>
                {
                    var entry = new Dictionary<string, object?>
                    {
                        ["index"] = index,
                        ["type"] = ShortName(face.SurfaceType.ToString(), "Surface"),
                        ["areaMm2"] = Round(face.Evaluator.Area * SquareMillimetersPerSquareCentimeter),
                        ["pointMm"] = ToMillimeters(face.PointOnFace),
                    };

                    switch (face.Geometry)
                    {
                        case Plane:
                            entry["normal"] = NormalAt(face);
                            break;
                        case Cylinder cylinder:
                            entry["axisOriginMm"] = ToMillimeters(cylinder.BasePoint);
                            entry["axis"] = ToVector(cylinder.AxisVector);
                            entry["radiusMm"] = Round(cylinder.Radius * MillimetersPerCentimeter);
                            break;
                    }

                    AddName(entry, face);
                    return entry;
                }));
            }

            return faces;
        }

        private static List<object> ReadEdges(SurfaceBody body, bool circlesOnly, int maxItems)
        {
            var edges = new List<object>();
            var edgeCount = body.Edges.Count;

            for (var index = 1; index <= edgeCount && edges.Count < maxItems; index++)
            {
                var edge = body.Edges[index];
                var geometryType = edge.GeometryType;
                var isCircular = geometryType is CurveTypeEnum.kCircleCurve or CurveTypeEnum.kCircularArcCurve;

                if (circlesOnly && !isCircular)
                {
                    continue;
                }

                edges.Add(ReadEntity(index, () =>
                {
                    var entry = new Dictionary<string, object?>
                    {
                        ["index"] = index,
                        ["type"] = ShortName(geometryType.ToString(), "Curve"),
                        ["lengthMm"] = Round(LengthOf(edge) * MillimetersPerCentimeter),
                    };

                    switch (edge.Geometry)
                    {
                        case Circle circle:
                            entry["centerMm"] = ToMillimeters(circle.Center);
                            entry["axis"] = ToVector(circle.Normal);
                            entry["radiusMm"] = Round(circle.Radius * MillimetersPerCentimeter);
                            break;
                        case Arc3d arc:
                            entry["centerMm"] = ToMillimeters(arc.Center);
                            entry["axis"] = ToVector(arc.Normal);
                            entry["radiusMm"] = Round(arc.Radius * MillimetersPerCentimeter);
                            break;
                        case LineSegment:
                            entry["startMm"] = ToMillimeters(edge.StartVertex.Point);
                            entry["endMm"] = ToMillimeters(edge.StopVertex.Point);
                            break;
                        default:
                            entry["pointMm"] = ToMillimeters(edge.PointOnEdge);
                            break;
                    }

                    AddName(entry, edge);
                    return entry;
                }));
            }

            return edges;
        }

        /// <summary>One entry per cylinder (faces sharing axis and radius), with the centers of its circular edges.</summary>
        private static List<object> ReadCylinders(SurfaceBody body, int maxItems)
        {
            var groups = new List<CylinderGroup>();
            var faceCount = body.Faces.Count;

            for (var index = 1; index <= faceCount; index++)
            {
                var face = body.Faces[index];
                if (face.SurfaceType != SurfaceTypeEnum.kCylinderSurface || face.Geometry is not Cylinder cylinder)
                {
                    continue;
                }

                var origin = ToArray(cylinder.BasePoint);
                var axis = ToArray(cylinder.AxisVector);
                var radius = cylinder.Radius;

                var group = groups.FirstOrDefault(candidate => candidate.Matches(origin, axis, radius));
                if (group is null)
                {
                    group = new CylinderGroup(origin, axis, radius);
                    groups.Add(group);
                }

                group.FaceIndices.Add(index);
                group.AddEndCenters(face);
            }

            return groups.Take(maxItems).Select(group => group.ToEntry()).ToList();
        }

        /// <summary>Runs one entity's read; a COM error becomes { index, error } instead of failing the whole list.</summary>
        private static object ReadEntity(int index, Func<object> read)
        {
            try
            {
                return read();
            }
            catch (COMException exception)
            {
                return new { index, error = $"0x{exception.HResult:X8}: {exception.Message}" };
            }
        }

        private static void AddName(Dictionary<string, object?> entry, object entity)
        {
            var name = EntityNames.Get(entity);
            if (name is not null)
            {
                entry["name"] = name;
            }
        }

        private static double LengthOf(Edge edge)
        {
            edge.Evaluator.GetParamExtents(out var minParam, out var maxParam);
            edge.Evaluator.GetLengthAtParam(minParam, maxParam, out var length);
            return length;
        }

        private static double[] NormalAt(Face face)
        {
            var points = ToArray(face.PointOnFace);
            var normals = new double[3];
            face.Evaluator.GetNormalAtPoint(ref points, ref normals);
            return [Round(normals[0], 4), Round(normals[1], 4), Round(normals[2], 4)];
        }

        /// <summary>"kCylinderSurface" -> "cylinder", "kCircularArcCurve" -> "circularArc".</summary>
        private static string ShortName(string enumName, string suffix)
        {
            var name = enumName.StartsWith('k') ? enumName[1..] : enumName;
            if (name.EndsWith(suffix, StringComparison.Ordinal))
            {
                name = name[..^suffix.Length];
            }

            return name.Length == 0 ? enumName : char.ToLowerInvariant(name[0]) + name[1..];
        }

        private static double Round(double value, int decimals = 3)
        {
            return Math.Round(value, decimals);
        }

        private static double[] ToMillimeters(Point point)
        {
            return [Round(point.X * MillimetersPerCentimeter), Round(point.Y * MillimetersPerCentimeter), Round(point.Z * MillimetersPerCentimeter)];
        }

        private static double[] ToVector(UnitVector vector)
        {
            return [Round(vector.X, 4), Round(vector.Y, 4), Round(vector.Z, 4)];
        }

        private static double[] ToArray(Point point)
        {
            return [point.X, point.Y, point.Z];
        }

        private static double[] ToArray(UnitVector vector)
        {
            return [vector.X, vector.Y, vector.Z];
        }

        /// <summary>Cylindrical faces that lie on the same infinite cylinder (same axis line and radius), in cm.</summary>
        private sealed class CylinderGroup
        {
            private readonly double[] origin;
            private readonly double[] axis;
            private readonly double radius;
            private readonly List<double[]> endCenters = [];

            public CylinderGroup(double[] origin, double[] axis, double radius)
            {
                this.origin = origin;
                this.axis = axis;
                this.radius = radius;
            }

            public List<int> FaceIndices { get; } = [];

            public bool Matches(double[] otherOrigin, double[] otherAxis, double otherRadius)
            {
                return Math.Abs(otherRadius - radius) < GeometryTolerance
                    && Math.Abs(Math.Abs(Dot(otherAxis, axis)) - 1) < GeometryTolerance
                    && IsOnAxis(otherOrigin);
            }

            /// <summary>Adds the centers of the face's circular edges that lie on this cylinder's axis.</summary>
            public void AddEndCenters(Face face)
            {
                foreach (Edge edge in face.Edges)
                {
                    if (edge.Geometry is not Circle circle || Math.Abs(circle.Radius - radius) > GeometryTolerance)
                    {
                        continue;
                    }

                    var center = ToArray(circle.Center);
                    if (IsOnAxis(center) && !endCenters.Any(known => Distance(known, center) < GeometryTolerance))
                    {
                        endCenters.Add(center);
                    }
                }
            }

            public object ToEntry()
            {
                return new
                {
                    radiusMm = Round(radius * MillimetersPerCentimeter),
                    diameterMm = Round(2 * radius * MillimetersPerCentimeter),
                    axisOriginMm = Scale(origin, MillimetersPerCentimeter, 3),
                    axis = Scale(axis, 1, 4),
                    faces = FaceIndices,
                    endCentersMm = endCenters.Select(center => Scale(center, MillimetersPerCentimeter, 3)).ToList(),
                };
            }

            private bool IsOnAxis(double[] point)
            {
                var offset = new[] { point[0] - origin[0], point[1] - origin[1], point[2] - origin[2] };
                var along = Dot(offset, axis);
                var perpendicular = new[] { offset[0] - along * axis[0], offset[1] - along * axis[1], offset[2] - along * axis[2] };
                return Math.Sqrt(Dot(perpendicular, perpendicular)) < GeometryTolerance;
            }

            private static double Dot(double[] a, double[] b)
            {
                return a[0] * b[0] + a[1] * b[1] + a[2] * b[2];
            }

            private static double Distance(double[] a, double[] b)
            {
                var difference = new[] { a[0] - b[0], a[1] - b[1], a[2] - b[2] };
                return Math.Sqrt(Dot(difference, difference));
            }

            private static double[] Scale(double[] values, double factor, int decimals)
            {
                return [Round(values[0] * factor, decimals), Round(values[1] * factor, decimals), Round(values[2] * factor, decimals)];
            }
        }
    }
}
