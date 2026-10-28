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
                activeDocument = application.ActiveDocument?.FullFileName,
                openDocuments = ReadOpenDocuments(application),
                units = "The API always uses centimeters and radians, regardless of document units. Use Mm() and Deg() in scripts.",
            };
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
