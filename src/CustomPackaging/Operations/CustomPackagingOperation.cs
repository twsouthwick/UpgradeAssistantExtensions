using Microsoft.UpgradeAssistant;
using Microsoft.UpgradeAssistant.Operations;
using Microsoft.UpgradeAssistant.Services;
using Microsoft.UpgradeAssistant.Traits;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CustomPackaging
{
    /// <summary>
    /// Specifies an operation that Upgrade Assistant can invoke
    /// </summary>
    [OperationController(
        nameof(CustomPackagingOperation),
        UAMetadata.ControllerCategories.UpgradeFeature,
        traits: Metadata.Traits.CustomPackaging)]
    public class CustomPackagingOperation : IOperationController
    {
        public string Id => nameof(CustomPackagingOperation);

        public string DisplayName => "Convert custom packaging";

        public string Description => "Description for custom packaging";

        public async ValueTask<OperationContext> GetContextAsync(string sourceProjectPath, ITraitsSet traits, IServiceCollection serviceCollection, IReadOnlyDictionary<string, object> properties, CancellationToken cancellationToken)
        {
            var sourceProject = await serviceCollection.Project().GetProjectByPathAsync(solution: null, sourceProjectPath, cancellationToken);

            if (sourceProject is null)
            {
                return null;
            }

            var context = new OperationContext(serviceCollection, sourceProject, traits);

            context.SetMany(properties);

            return context;
        }

        public ValueTask<OperationDefinition> GetOperationDefinitionAsync(string projectPath, ITraitsSet traits, CancellationToken cancellationToken)
        {
            var definition = new OperationDefinition
            {
                RootNodeProvider = new ProjectOperationSliceNodeProvider(),
            };
            throw new NotImplementedException();
        }

        public ValueTask<ITraitsSet> GetTraitsAsync(ITraitsSet traits, CancellationToken cancellationToken)
        {
            return new ValueTask<ITraitsSet>(traits.With(
                UAMetadata.Traits.UpgradeFeature,
                Metadata.Traits.CustomPackagingConversion
                ));
        }
    }
}
