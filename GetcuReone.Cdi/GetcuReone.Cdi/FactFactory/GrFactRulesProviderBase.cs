using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory.Entities;
using GetcuReone.FactFactory.Interfaces;
using System.Collections.Generic;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Base class for provider.
    /// </summary>
    public abstract class GrFactRulesProviderBase : IFacadeCreation, IAdapterCreation
    {
        /// <summary>
        /// Factory.
        /// </summary>
        public IAbstractFactory Factory { get; internal set; }

        /// <inheritdoc/>
        public virtual TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            if (Factory is IAdapterCreation adapterCreation)
                return adapterCreation.GetAdapter<TAdapter>();

            return AdapterBase.Create<TAdapter>(Factory);
        }

        /// <inheritdoc/>
        public virtual TFacade GetFacade<TFacade>() where TFacade : IFacade, new()
        {
            if (Factory is IFacadeCreation facadeCreation)
                return facadeCreation.GetFacade<TFacade>();

            return ComboPatterns.Facade.FacadeBase.Create<TFacade>(Factory);
        }

        /// <summary>
        /// Get default facts.
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<IFact> GetDefaultFacts();

        /// <summary>
        /// Get rules.
        /// </summary>
        /// <returns></returns>
        public abstract FactRuleCollection GetRules();
    }
}
