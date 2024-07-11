using Microsoft.UpgradeAssistant;
using Microsoft.UpgradeAssistant.Nodes;
using Microsoft.UpgradeAssistant.Operations;
using Microsoft.UpgradeAssistant.Transformers;
using System.Threading;
using System.Threading.Tasks;

namespace CustomPackaging.Transformers
{
    [SliceNodeValidator(
        id: nameof(CustomPackagingRemovalTransformer),
        nodeKind: UAMetadata.SliceNodeKinds.ProjectDependenciesFinalizer,
        traits: Metadata.Traits.CustomPackagingConversion)]
    [SliceNodeTransformer(
        id: nameof(CustomPackagingRemovalTransformer),
        nodeKind: UAMetadata.SliceNodeKinds.ProjectDependenciesFinalizer,
        traits: Metadata.Traits.CustomPackagingConversion)]
    internal sealed class CustomPackagingRemovalTransformer : ISliceNodeTransformer, ISliceNodeValidator
    {
        async ValueTask<SliceNodeTransformerResult> ISliceNodeTransformer.RunAsync(OperationContext context, SliceNode node, CancellationToken cancellationToken)
        {
            // TODO: Clean up custom packaging, i.e. remove from project, etc

            return SliceNodeTransformerResult.Skipped;
        }

        async ValueTask<SliceNodeValidatorResult> ISliceNodeValidator.ValidateAsync(OperationContext context, SliceNode node, CancellationToken cancellationToken)
        {
            // TODO: validate that transformations were correct - only a value of Success will run the transformer

            return SliceNodeValidatorResult.Success;
        }
    }
}
