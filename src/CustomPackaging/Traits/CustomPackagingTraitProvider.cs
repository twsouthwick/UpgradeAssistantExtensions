using Microsoft.UpgradeAssistant;
using Microsoft.UpgradeAssistant.Traits;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CustomPackaging
{
    /// <summary>
    /// Used to mark a project as having the custom packaging format we're looking to upgrade. Any operation/node provider/transformer/etc that
    /// only wants to be run when this is the case can add the trait to their attribute
    /// </summary>
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
