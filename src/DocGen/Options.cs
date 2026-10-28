namespace DocGen
{
    /// <summary>Command-line options. Without arguments, the repository's default folders are used.</summary>
    internal sealed class Options
    {
        private const string SolutionFileName = "InventorBridge.slnx";
        private const string DefaultStdolePath = @"C:\Windows\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll";

        /// <summary>Folder with one subfolder per Inventor version (lib/inventor/2024/...).</summary>
        public required string LibDirectory { get; init; }

        /// <summary>Folder where the reference is generated (docs/reference).</summary>
        public required string OutputDirectory { get; init; }

        /// <summary>stdole.dll, referenced by the interop. Null if it cannot be found.</summary>
        public string? StdolePath { get; init; }

        public static Options Parse(string[] args)
        {
            var repositoryRoot = FindRepositoryRoot();

            var stdolePath = GetArgument(args, "--stdole") ?? DefaultStdolePath;
            if (!File.Exists(stdolePath))
            {
                Console.Error.WriteLine($"warning: stdole.dll not found at {stdolePath}; types that depend on it may fail.");
                stdolePath = null;
            }

            return new Options
            {
                LibDirectory = GetArgument(args, "--lib") ?? Path.Combine(repositoryRoot, "lib", "inventor"),
                OutputDirectory = GetArgument(args, "--out") ?? Path.Combine(repositoryRoot, "docs", "reference"),
                StdolePath = stdolePath,
            };
        }

        private static string? GetArgument(string[] args, string name)
        {
            var index = Array.IndexOf(args, name);
            if (index < 0 || index + 1 >= args.Length)
            {
                return null;
            }

            return args[index + 1];
        }

        /// <summary>Walks up from the current folder until it finds the solution; falls back to the current folder.</summary>
        private static string FindRepositoryRoot()
        {
            for (var directory = new DirectoryInfo(Directory.GetCurrentDirectory()); directory is not null; directory = directory.Parent)
            {
                if (File.Exists(Path.Combine(directory.FullName, SolutionFileName)))
                {
                    return directory.FullName;
                }
            }

            return Directory.GetCurrentDirectory();
        }
    }
}
