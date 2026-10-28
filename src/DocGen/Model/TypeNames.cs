namespace DocGen.Model
{
    public static class TypeNames
    {
        /// <summary>Element type of an array ("Face[]" becomes "Face"). Other types are returned unchanged.</summary>
        public static string WithoutArray(string typeName)
        {
            return typeName.EndsWith("[]") ? typeName[..^2] : typeName;
        }
    }
}
