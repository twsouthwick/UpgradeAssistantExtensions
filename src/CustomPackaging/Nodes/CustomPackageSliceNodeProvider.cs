using Microsoft.UpgradeAssistant;
using Microsoft.UpgradeAssistant.Nodes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomPackaging.Nodes
{
    [SliceNodeProvider(
        nodeKind: UAMetadata.SliceNodeKinds.Project,
        traits: Metadata.Traits.CustomPackagingConversion)]
    internal sealed class CustomPackageSliceNodeProvider : ISliceNodeProvider
    {
        public async ValueTask<IEnumerable<SliceNode>> GetNodesAsync(SliceContext context, SliceNode parentNode, CancellationToken cancellationToken)
        {
            if (parentNode is not ProjectSliceNode projectNode)
            {
                return [];
            }

            // TODO figure out dependencies
            //return [new CustomPackageSliceNode("name", "path")];

            return [];
        }
    }

    internal sealed class CustomPackageSliceNode : SliceNode
    {
        public CustomPackageSliceNode(string name, string path) : base(Metadata.SliceNodeKinds.CustomPackaging, name, path, SliceNodeFlags.None)
        {
        }
    }
}
