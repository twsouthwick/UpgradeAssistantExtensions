using Microsoft.UpgradeAssistant;
using Microsoft.UpgradeAssistant.Nodes;
using System.Collections.Generic;

namespace CustomPackaging.Nodes
{
    [SliceNodeBuilder(
        nodeKind: Metadata.SliceNodeKinds.CustomPackaging,
        order: Metadata.SliceNodeOrder.CustomPackaging)]
    internal sealed class CustomPackageSliceNodeBuilder : ISliceNodeBuilder
    {
        public SliceNode CreateNode(string name, string filePath, IReadOnlyDictionary<string, object> properties) => null;
    }
}
