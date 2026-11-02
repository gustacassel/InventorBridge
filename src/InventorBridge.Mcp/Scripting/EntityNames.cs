using System.Runtime.InteropServices;
using Inventor;

namespace InventorBridge.Mcp.Scripting
{
    /// <summary>
    /// Names faces, edges and vertices the way Inventor's "Assign Name" command does (an attribute read by
    /// iLogic), so a later script can find the same entity again by name instead of by index or position.
    /// </summary>
    public static class EntityNames
    {
        private const string SetName = "iLogicEntityNameSet";
        private const string AttributeName = "iLogicEntityName";

        /// <summary>Names a Face, Edge or Vertex. For a proxy, the name goes on the entity in its part document.</summary>
        public static void Set(object entity, string name)
        {
            var sets = AttributeSetsOf(Native(entity))
                ?? throw new ArgumentException($"Only a Face, Edge or Vertex can be named, not {entity.GetType().Name}.");

            var set = sets.NameIsUsed[SetName] ? sets[SetName] : sets.Add(SetName);
            if (set.NameIsUsed[AttributeName])
            {
                set[AttributeName].Value = name;
            }
            else
            {
                set.Add(AttributeName, ValueTypeEnum.kStringType, name);
            }
        }

        /// <summary>The entity's name, or null if it has none. Proxies are read through their native entity.</summary>
        public static string? Get(object entity)
        {
            try
            {
                var sets = AttributeSetsOf(Native(entity));
                if (sets is null || !sets.NameIsUsed[SetName])
                {
                    return null;
                }

                var set = sets[SetName];
                return set.NameIsUsed[AttributeName] ? set[AttributeName].Value as string : null;
            }
            catch (COMException)
            {
                return null;
            }
        }

        /// <summary>The named entity in a part document, or null.</summary>
        public static object? Find(Document document, string name)
        {
            var found = document.AttributeManager.FindObjects(SetName, AttributeName, name);
            return found.Count > 0 ? found[1] : null;
        }

        private static AttributeSets? AttributeSetsOf(object entity)
        {
            switch (entity)
            {
                case Face face:
                    return face.AttributeSets;
                case Edge edge:
                    return edge.AttributeSets;
                case Vertex vertex:
                    return vertex.AttributeSets;
                default:
                    return null;
            }
        }

        private static object Native(object entity)
        {
            switch (entity)
            {
                case FaceProxy face:
                    return face.NativeObject;
                case EdgeProxy edge:
                    return edge.NativeObject;
                case VertexProxy vertex:
                    return vertex.NativeObject;
                default:
                    return entity;
            }
        }
    }
}
