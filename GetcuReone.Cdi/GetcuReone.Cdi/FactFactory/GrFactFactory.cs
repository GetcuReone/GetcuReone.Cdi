using GetcuReone.FactFactory.Entities;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Interfaces.Context;
using GetcuReone.FactFactory.Interfaces.Operations;
using GetcuReone.FactFactory.Versioned;
using GetcuReone.FactFactory.Versioned.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Fact factory.
    /// </summary>
    public class GrFactFactory : VersionedFactFactoryBase<FactRule, FactRuleCollection, WantAction, VersionedFactContainer>
    {
        internal readonly GrFactRulesProviderBase _provider;

        /// <summary>
        /// Rule collection.
        /// </summary>
        public override FactRuleCollection Rules { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="provider"></param>
        public GrFactFactory(GrFactRulesProviderBase provider)
        {
            _provider = provider;
            Rules = provider.GetRules();
        }

        /// <inheritdoc/>
        protected override IEnumerable<IFact> GetDefaultFacts(IWantActionContext<WantAction, VersionedFactContainer> context)
        {
            return _provider.GetDefaultFacts();
        }

        /// <inheritdoc/>
        protected override WantAction CreateWantAction(Action<IEnumerable<IFact>> wantAction, List<IFactType> factTypes, FactWorkOption option)
        {
            return new WantAction(wantAction, factTypes, option);
        }

        /// <inheritdoc/>
        protected override WantAction CreateWantAction(Func<IEnumerable<IFact>, ValueTask> wantAction, List<IFactType> factTypes, FactWorkOption option)
        {
            return new WantAction(wantAction, factTypes, option);
        }

        /// <inheritdoc/>
        protected override VersionedFactContainer GetDefaultContainer()
        {
            return new VersionedFactContainer();
        }

        /// <inheritdoc/>
        public override ISingleEntityOperations GetSingleEntityOperations()
        {
            return GetFacade<GrSingleEntityOperationsFacade>();
        }
    }
}
