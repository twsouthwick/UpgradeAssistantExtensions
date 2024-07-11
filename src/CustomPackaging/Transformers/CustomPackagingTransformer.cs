using CustomPackaging.Nodes;
using Microsoft.UpgradeAssistant;
using Microsoft.UpgradeAssistant.Operations;
using Microsoft.UpgradeAssistant.Services;
using Microsoft.UpgradeAssistant.Transformers;
using System.Threading;
using System.Threading.Tasks;

namespace CustomPackaging.Transformers
{
    /// <summary>
    /// A transformer that will be run for each of the custom package entry
    /// </summary>
    [SliceNodeTransformer(
        id: nameof(CustomPackagingTransformer),
        nodeKind: Metadata.SliceNodeKinds.CustomPackagingEntry,
        traits: Metadata.Traits.CustomPackagingConversion)]
    internal class CustomPackagingTransformer : ISliceNodeTransformer
    {
        public async ValueTask<SliceNodeTransformerResult> RunAsync(OperationContext context, SliceNode node, CancellationToken cancellationToken)
        {
            if (node is not CustomPackageEntrySliceNode packageNode)
            {
                return SliceNodeTransformerResult.Skipped;
            }

            // TODO perform the actual conversion
            context.Project.AddPackage(context, "packageName", "version");

            // If you need to drop into the project file:
            using var projectAccess = await context.Services.Msbuild().GetProjectAccessAsync(packageNode.ProjectPath, isReadOnly: false, cancellationToken);

            await projectAccess.RunAsync((project, token) =>
            {
                // Operate on the msbuild project
                return Task.FromResult(true);
            });

            return SliceNodeTransformerResult.Success;
        }
    }
}
