using CustomPackaging.Nodes;
using Microsoft.UpgradeAssistant;
using Microsoft.UpgradeAssistant.Operations;
using Microsoft.UpgradeAssistant.Transformers;
using System.Threading;
using System.Threading.Tasks;

namespace CustomPackaging.Transformers
{
    [SliceNodeTransformer(
        id: nameof(CustomPackagingTransformer),
        nodeKind: Metadata.SliceNodeKinds.CustomPackaging,
        traits: Metadata.Traits.CustomPackagingConversion)]
    internal class CustomPackagingTransformer : ISliceNodeTransformer
    {
        public async ValueTask<SliceNodeTransformerResult> RunAsync(OperationContext context, SliceNode node, CancellationToken cancellationToken)
        {
            if (node is not CustomPackageSliceNode packageNode)
            {
                return SliceNodeTransformerResult.Skipped;
            }

            // TODO perform the actual conversion
            return SliceNodeTransformerResult.Success;
        }
    }
}
