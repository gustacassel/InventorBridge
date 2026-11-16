using Inventor;

namespace InventorBridge.Mcp.Reading
{
    /// <summary>What the agent needs to know before working: version, project folders, templates and open documents.</summary>
    public static class StatusReader
    {
        public static object Read(Application application, bool startedByThisCall)
        {
            return new
            {
                running = true,
                startedByThisCall,
                version = application.SoftwareVersion.DisplayVersion,
                visible = application.Visible,
                ready = application.Ready,
                project = ReadProject(application),
                templates = ReadTemplates(application),
                activeDocument = application.ActiveDocument?.DisplayName,
                openDocuments = ReadOpenDocuments(application),
                units = "The API always uses centimeters and radians, regardless of document units. Use Mm() and Deg() in scripts.",
                otherInventorProcesses = ReadOtherInstances(application),
            };
        }

        /// <summary>
        /// Inventor processes other than the one this server talks to, or null when there are none. Windows gives
        /// a running Inventor to any client that asks, so with two of them the user may be watching the other one;
        /// one without a window is usually left over from a crash.
        /// </summary>
        private static object? ReadOtherInstances(Application application)
        {
            var connectedId = InventorBridge.Mcp.Connection.InventorWindows.ProcessIdOf(new IntPtr(application.MainFrameHWND));
            var others = new List<object>();

            foreach (var process in System.Diagnostics.Process.GetProcessesByName("Inventor"))
            {
                using (process)
                {
                    if (process.Id == connectedId)
                    {
                        continue;
                    }

                    var hasWindow = process.MainWindowHandle != IntPtr.Zero;
                    others.Add(new
                    {
                        processId = process.Id,
                        hasWindow,
                        started = TryRead(() => process.StartTime.ToString("yyyy-MM-dd HH:mm")),
                    });
                }
            }

            if (others.Count == 0)
            {
                return null;
            }

            return new
            {
                connectedProcessId = connectedId,
                others,
                note = "This server works with the Inventor in process " + connectedId + ". Tell the user, so they look at " +
                    "the right window. An Inventor with no window is usually left over from a crash and still holds " +
                    "memory and possibly a license: the user can end it in Task Manager.",
            };
        }

        private static string? TryRead(Func<string> read)
        {
            try
            {
                return read();
            }
            catch (InvalidOperationException)
            {
                return null;
            }
            catch (System.ComponentModel.Win32Exception)
            {
                return null;
            }
        }

        public static string WorkspacePath(Application application)
        {
            return application.DesignProjectManager.ActiveDesignProject.WorkspacePath;
        }

        private static object ReadProject(Application application)
        {
            var project = application.DesignProjectManager.ActiveDesignProject;

            return new
            {
                name = project.Name,
                file = project.FullFileName,
                workspace = project.WorkspacePath,
                templatesFolder = project.TemplatesPath,
            };
        }

        private static object ReadTemplates(Application application)
        {
            var fileManager = application.FileManager;

            return new
            {
                part = fileManager.GetTemplateFile(DocumentTypeEnum.kPartDocumentObject),
                assembly = fileManager.GetTemplateFile(DocumentTypeEnum.kAssemblyDocumentObject),
                drawing = fileManager.GetTemplateFile(DocumentTypeEnum.kDrawingDocumentObject),
            };
        }

        private static List<object> ReadOpenDocuments(Application application)
        {
            var documents = new List<object>();

            foreach (Document document in application.Documents.VisibleDocuments)
            {
                documents.Add(new
                {
                    name = document.DisplayName,
                    file = document.FullFileName,
                    type = DocumentTypeName(document.DocumentType),
                    unsavedChanges = document.Dirty,
                });
            }

            return documents;
        }

        public static string DocumentTypeName(DocumentTypeEnum documentType)
        {
            switch (documentType)
            {
                case DocumentTypeEnum.kPartDocumentObject: return "part";
                case DocumentTypeEnum.kAssemblyDocumentObject: return "assembly";
                case DocumentTypeEnum.kDrawingDocumentObject: return "drawing";
                case DocumentTypeEnum.kPresentationDocumentObject: return "presentation";
                default: return documentType.ToString();
            }
        }
    }
}
