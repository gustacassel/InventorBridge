using System.Text;
using Inventor;

namespace InventorBridge.Mcp.Scripting
{
    /// <summary>
    /// What a run_csharp script sees as global variables and functions.
    /// </summary>
    /// <remarks>Must stay public: Roslyn compiles the script against this type.</remarks>
    public sealed class ScriptGlobals
    {
        private readonly StringBuilder output = new();

        public ScriptGlobals(Application application, string? workspacePath)
        {
            App = application;
            WorkspacePath = workspacePath;
        }

        /// <summary>The running Inventor.</summary>
        public Application App { get; }

        /// <summary>The active document, or null when no document is open.</summary>
        public Document? ActiveDocument => App.ActiveDocument;

        /// <summary>Creates points, vectors and matrices (App.TransientGeometry).</summary>
        public TransientGeometry Geometry => App.TransientGeometry;

        /// <summary>Creates collections and name/value maps (App.TransientObjects).</summary>
        public TransientObjects Objects => App.TransientObjects;

        /// <summary>Workspace folder of the active Inventor project, where new files should be saved. Null if unknown.</summary>
        public string? WorkspacePath { get; }

        /// <summary>Converts millimeters to the API's internal length unit (centimeters).</summary>
        public double Mm(double millimeters)
        {
            return millimeters / 10.0;
        }

        /// <summary>Converts degrees to the API's internal angle unit (radians).</summary>
        public double Deg(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        /// <summary>Writes a line to the output returned to the agent.</summary>
        public void Log(object? value)
        {
            output.AppendLine(value?.ToString() ?? "null");
        }

        internal string Output => output.ToString();
    }
}
