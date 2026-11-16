using System.Diagnostics;
using System.Runtime.InteropServices;
using Inventor;
using InventorBridge.Mcp.Reading;
using InventorBridge.Mcp.Scripting;

namespace InventorBridge.Mcp.ILogic
{
    /// <summary>
    /// Lists, writes and runs iLogic rules through the automation interface of the iLogic add-in that ships with
    /// Inventor. A rule runs inside Inventor's process, so a loop over thousands of entities is far faster there
    /// than through run_csharp's out-of-process calls.
    /// </summary>
    /// <remarks>
    /// The automation interface has no type library in the interop, so it is used late-bound. Running a rule goes
    /// through a transaction like a run_csharp script: undo_last undoes it, an error rolls it back.
    /// </remarks>
    public static class ILogicRules
    {
        private const string ILogicAddInId = "{3BDD8D79-2179-4B11-8A5A-257B1C0263AC}";

        public static object List(Application application, string? documentName, bool withText, int maxItems)
        {
            var document = OpenDocuments.Find(application, documentName);
            var automation = Automation(application);
            var rules = new List<object>();
            var total = 0;

            if (automation.Rules(document) is System.Collections.IEnumerable all)
            {
                foreach (dynamic rule in all)
                {
                    total++;
                    if (rules.Count >= maxItems)
                    {
                        continue;
                    }

                    rules.Add(new
                    {
                        name = (string)rule.Name,
                        active = (bool)rule.IsActive,
                        text = withText ? (string)rule.Text : null,
                    });
                }
            }

            return new
            {
                document = document.DisplayName,
                rules,
                truncated = total > rules.Count ? $"{rules.Count} of {total} rules shown; pass a larger maxItems" : null,
                externalRuleFolders = ReadExternalFolders(automation),
            };
        }

        public static string Set(Application application, string? documentName, string name, string text)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Give the rule a name.");
            }

            var document = OpenDocuments.Find(application, documentName);
            var automation = Automation(application);
            dynamic? existing = automation.GetRule(document, name);
            var added = existing is null;

            // AddRule runs the new rule at once, whatever RulesEnabled says, while changing a rule's text with
            // rules disabled does not run it. So a new rule starts as a comment and gets its text afterwards.
            bool rulesEnabled = automation.RulesEnabled;
            automation.RulesEnabled = false;
            try
            {
                if (existing is null)
                {
                    automation.AddRule(document, name, "' Added by InventorBridge; the text follows.");
                    existing = automation.GetRule(document, name);
                }

                existing!.Text = text;
            }
            finally
            {
                automation.RulesEnabled = rulesEnabled;
            }

            var what = added ? $"added rule \"{name}\" to" : $"replaced the text of rule \"{name}\" in";
            return $"{what} {document.DisplayName} without running it; run it with ilogic_run. Inventor marks the document " +
                "changed: save it to keep the rule.";
        }

        /// <summary>Runs an internal rule by name, or an external rule file, on a document.</summary>
        public static string Run(Application application, string? documentName, string? name, string? externalFile)
        {
            if (string.IsNullOrWhiteSpace(name) == string.IsNullOrWhiteSpace(externalFile))
            {
                throw new ArgumentException("Give either the name of a rule in the document or the path of an external rule file.");
            }

            if (externalFile is not null && !System.IO.File.Exists(externalFile))
            {
                throw new InvalidOperationException($"The external rule {externalFile} does not exist.");
            }

            var document = OpenDocuments.Find(application, documentName);
            var automation = Automation(application);
            var label = name is not null ? $"iLogic rule {name}" : $"iLogic external rule {System.IO.Path.GetFileName(externalFile)}";

            if (name is not null && automation.GetRule(document, name) is null)
            {
                throw new InvalidOperationException($"{document.DisplayName} has no rule named \"{name}\". Call ilogic_list to see its rules.");
            }

            if (!ReferenceEquals(application.ActiveDocument, document))
            {
                document.Activate();
            }

            var stopwatch = Stopwatch.StartNew();
            var transaction = ScriptTransaction.Start(application, ScriptRunner.TransactionPrefix + label, undoable: true);

            try
            {
                if (name is not null)
                {
                    automation.RunRule(document, name);
                }
                else
                {
                    automation.RunExternalRule(document, externalFile);
                }
            }
            catch (Exception exception) when (exception is COMException or Microsoft.CSharp.RuntimeBinder.RuntimeBinderException
                or System.Reflection.TargetInvocationException)
            {
                var note = transaction.RollBack(application);
                var message = (exception.InnerException ?? exception).Message;
                throw new InvalidOperationException($"{label} failed: {message}. Transaction: {note}");
            }

            var committed = transaction.Commit(application);
            return $"ran {label} on {document.DisplayName} in {stopwatch.Elapsed.TotalSeconds.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} s. " +
                $"Transaction: {committed}. iLogic writes Logger output to its own log window, not here; return values " +
                "through a parameter or an iProperty, and read them with inspect.";
        }

        private static dynamic Automation(Application application)
        {
            ApplicationAddIn addIn;
            try
            {
                addIn = application.ApplicationAddIns.ItemById[ILogicAddInId];
            }
            catch (ArgumentException)
            {
                throw new InvalidOperationException("The iLogic add-in is not installed in this Inventor.");
            }

            if (!addIn.Activated)
            {
                addIn.Activate();
            }

            return addIn.Automation ?? throw new InvalidOperationException("The iLogic add-in did not return its automation interface.");
        }

        private static string[]? ReadExternalFolders(dynamic automation)
        {
            try
            {
                return (string[])automation.FileOptions.ExternalRuleDirectories;
            }
            catch (Exception exception) when (exception is COMException or Microsoft.CSharp.RuntimeBinder.RuntimeBinderException or InvalidCastException)
            {
                return null;
            }
        }
    }
}
