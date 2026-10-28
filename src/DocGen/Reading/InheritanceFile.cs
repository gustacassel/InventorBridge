namespace DocGen.Reading
{
    /// <summary>
    /// Reads inheritance.txt: one "Derived: Base" line per type, or "Derived: Base1 | Base2" when the
    /// Autodesk poster legend is ambiguous. Lines starting with # are comments.
    /// </summary>
    public static class InheritanceFile
    {
        /// <summary>Returns the candidate bases of each derived type.</summary>
        public static Dictionary<string, string[]> Load(string path)
        {
            var basesByDerived = new Dictionary<string, string[]>();

            foreach (var line in File.ReadAllLines(path))
            {
                if (line.StartsWith('#') || !line.Contains(':'))
                {
                    continue;
                }

                var parts = line.Split(':', 2);
                var derivedName = parts[0].Trim();
                var baseNames = parts[1].Split('|', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

                basesByDerived[derivedName] = baseNames;
            }

            return basesByDerived;
        }
    }
}
