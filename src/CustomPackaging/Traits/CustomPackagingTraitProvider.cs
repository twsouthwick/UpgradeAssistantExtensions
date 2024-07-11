using Microsoft.UpgradeAssistant;
using Microsoft.UpgradeAssistant.Traits;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace UpgradeAssistantExtensions
{
    [TraitProvider]
    internal sealed class CustomPackagingTraitProvider : ITraitProvider
    {
        public ValueTask<IEnumerable<object>> GetTraitsAsync(ProjectContext context, CancellationToken cancellationToken)
        {
            // TODO: Do something to identify if custom packaging is used
            return new ValueTask<IEnumerable<object>>([Metadata.Traits.CustomPackaging]);
        }
    }
}
