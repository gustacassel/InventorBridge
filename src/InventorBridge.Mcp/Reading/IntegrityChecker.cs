using System.Diagnostics;
using System.Runtime.InteropServices;
using Inventor;

namespace InventorBridge.Mcp.Reading;

/// <summary>
/// Looks for what is broken in a document and in every document it references: missing files, documents that
/// need an update, features and constraints with errors, broken flat patterns, detached dimensions and
/// balloons in drawings. Reads only.
/// </summary>
/// <remarks>
/// A large assembly can reference hundreds of documents, each read through COM calls, so the check stops at a
/// time limit and says how far it got.
/// </remarks>
public static class IntegrityChecker
{
    public static object Check(Application application, Document document, int maxItems, TimeSpan timeLimit)
    {
        var stopwatch = Stopwatch.StartNew();
        var problems = new List<Problem>();
        var documents = new List<Document> { document };
        foreach (Document referenced in document.AllReferencedDocuments)
        {
            documents.Add(referenced);
        }

        var checkedCount = 0;
        foreach (var current in documents)
        {
            if (stopwatch.Elapsed > timeLimit)
            {
                break;
            }

            CheckDocument(current, problems);
            checkedCount++;
        }

        var complete = checkedCount == documents.Count;
        var notes = new List<string>();
        if (!complete)
        {
            notes.Add($"""
                stopped after {timeLimit.TotalSeconds:0} s: {checkedCount} of {documents.Count} documents checked
                (the active one first, then the referenced ones). Problems in the others are not listed.
                """);
        }

        if (problems.Count > maxItems)
        {
            notes.Add($"problems: {maxItems} of {problems.Count} shown; pass a larger maxItems");
        }

        return new
        {
            document = document.DisplayName,
            documentsChecked = checkedCount,
            documentsReferenced = documents.Count - 1,
            complete,
            elapsedSeconds = Math.Round(stopwatch.Elapsed.TotalSeconds, 1),
            problemCount = problems.Count,
            problemsByKind = problems.GroupBy(problem => problem.Kind).ToDictionary(group => group.Key, group => group.Count()),
            problems = problems.Take(maxItems).Select(problem => new { document = problem.Document, kind = problem.Kind, detail = problem.Detail }),
            notes,
        };
    }

    private sealed record Problem(string Document, string Kind, string Detail);

    private static void CheckDocument(Document document, List<Problem> problems)
    {
        var name = SafeName(document);
        void Add(string kind, string detail) => problems.Add(new Problem(name, kind, detail));

        Try(() =>
        {
            foreach (FileDescriptor descriptor in document.File.ReferencedFileDescriptors)
            {
                if (descriptor.ReferenceMissing)
                {
                    Add("missingFile", descriptor.FullFileName);
                }
            }
        }, Add);

        Try(() =>
        {
            if (document.RequiresUpdate)
            {
                Add("needsUpdate", "the document needs an update (Update or Rebuild)");
            }
        }, Add);

        switch (document)
        {
            case PartDocument part:
                Try(() => CheckPart(part, Add), Add);
                break;
            case AssemblyDocument assembly:
                Try(() => CheckAssembly(assembly, Add), Add);
                break;
            case DrawingDocument drawing:
                Try(() => CheckDrawing(drawing, Add), Add);
                break;
        }
    }

    private static void CheckPart(PartDocument part, Action<string, string> add)
    {
        var definition = part.ComponentDefinition;
        foreach (PartFeature feature in definition.Features)
        {
            var health = feature.HealthStatus;
            if (health is not (HealthStatusEnum.kUpToDateHealth or HealthStatusEnum.kSuppressedHealth or HealthStatusEnum.kBeyondStopNodeHealth))
            {
                add("featureError", $"{feature.Name}: {health}");
            }
        }

        if (definition is SheetMetalComponentDefinition { HasFlatPattern: true } sheetMetal)
        {
            var box = sheetMetal.FlatPattern.RangeBox;
            if (box.MinPoint.DistanceTo(box.MaxPoint) < 1e-9)
            {
                add("brokenFlatPattern", "the flat pattern has no geometry: unfolding failed");
            }
        }
    }

    private static void CheckAssembly(AssemblyDocument assembly, Action<string, string> add)
    {
        foreach (AssemblyConstraint constraint in assembly.ComponentDefinition.Constraints)
        {
            var health = constraint.HealthStatus;
            if (health is not (HealthStatusEnum.kUpToDateHealth or HealthStatusEnum.kSuppressedHealth or HealthStatusEnum.kBeyondStopNodeHealth))
            {
                add("constraintError", $"{constraint.Name}: {health}");
            }
        }
    }

    private static void CheckDrawing(DrawingDocument drawing, Action<string, string> add)
    {
        foreach (Sheet sheet in drawing.Sheets)
        {
            var detached = 0;
            foreach (DrawingDimension dimension in sheet.DrawingDimensions)
            {
                if (!dimension.Attached)
                {
                    detached++;
                }
            }

            if (detached > 0)
            {
                add("detachedDimensions", $"{sheet.Name}: {detached} dimension(s) no longer attached to geometry");
            }

            var loose = 0;
            foreach (Balloon balloon in sheet.Balloons)
            {
                if (!balloon.Attached)
                {
                    loose++;
                }
            }

            if (loose > 0)
            {
                add("detachedBalloons", $"{sheet.Name}: {loose} balloon(s) no longer attached");
            }
        }
    }

    /// <summary>Runs one check; a COM error is reported as a problem instead of stopping the whole check.</summary>
    private static void Try(Action check, Action<string, string> add)
    {
        try
        {
            check();
        }
        catch (COMException exception)
        {
            add("unreadable", $"0x{exception.HResult:X8}: {exception.Message}");
        }
    }

    private static string SafeName(Document document)
    {
        try
        {
            var file = document.FullFileName;
            return string.IsNullOrEmpty(file) ? document.DisplayName : System.IO.Path.GetFileName(file);
        }
        catch (COMException)
        {
            return "?";
        }
    }
}
