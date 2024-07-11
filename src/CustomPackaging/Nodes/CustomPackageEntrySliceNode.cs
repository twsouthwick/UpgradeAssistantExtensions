using Microsoft.UpgradeAssistant;

namespace CustomPackaging.Nodes
{
    /// <summary>
    /// A custom <see cref="SliceNode"/> used for information about a custom package entry
    /// </summary>
    internal sealed class CustomPackageEntrySliceNode : SliceNode
    {
        public CustomPackageEntrySliceNode(string projectPath, string name, string path) : base(Metadata.SliceNodeKinds.CustomPackagingEntry, name, path, SliceNodeFlags.None)
        {
            ProjectPath = projectPath;
        }

        public string ProjectPath { get; }
    }
}
