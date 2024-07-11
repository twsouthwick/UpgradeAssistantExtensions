using Microsoft.UpgradeAssistant;
using Microsoft.UpgradeAssistant.Nodes;
using System.Collections.Generic;

namespace CustomPackaging.Nodes
{
    /// <summary>
    /// Specifies the order of the slice nodes
    /// </summary>
    [SliceNodeBuilder(
        nodeKind: Metadata.SliceNodeKinds.CustomPackagingEntry,
        order: Metadata.SliceNodeOrder.CustomPackaging)]
    internal sealed class CustomPackageSliceNodeBuilder : ISliceNodeBuilder
    {
        public SliceNode CreateNode(string name, string filePath, IReadOnlyDictionary<string, object> properties) => null;
    }
}
