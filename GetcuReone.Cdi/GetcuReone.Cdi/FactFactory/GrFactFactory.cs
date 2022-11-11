using GetcuReone.FactFactory;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Interfaces.Context;
using GetcuReone.FactFactory.Interfaces.Operations;
using System.Collections.Generic;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Fact factory.
    /// </summary>
    public class GrFactFactory : BaseFactFactory, IGrFactFactory
    {
        /// <inheritdoc/>
        public IGrFactRulesProvider Provider { get; }

        /// <summary>
        /// Rule collection.
        /// </summary>
        public override IFactRuleCollection Rules { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="provider"></param>
        public GrFactFactory(IGrFactRulesProvider provider)
        {
            Provider = provider;
            Rules = provider.GetRules();
        }

        /// <inheritdoc/>
        protected override IEnumerable<IFact> GetDefaultFacts(IWantActionContext context)
        {
            return Provider.GetDefaultFacts();
        }

        /// <inheritdoc/>
        protected override IFactContainer GetDefaultContainer()
        {
            return Provider.GetDefaultContainer();
        }

        /// <inheritdoc/>
        protected override ISingleEntityOperations GetSingleEntityOperations()
        {
            return Provider.GetSingleEntityOperations();
        }
    }
}
