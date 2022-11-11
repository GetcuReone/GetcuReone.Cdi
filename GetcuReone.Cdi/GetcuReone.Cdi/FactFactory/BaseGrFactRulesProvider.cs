using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory;
using GetcuReone.FactFactory.Entities;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Interfaces.Operations;
using GetcuReone.FactFactory.Versioned.Facades.SingleEntityOperations;
using System;
using System.Collections.Generic;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Base class for provider.
    /// </summary>
    public abstract class BaseGrFactRulesProvider : IGrFactRulesProvider, IFacadeCreation, IAdapterCreation
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

        /// <inheritdoc />
        public abstract IEnumerable<IFact> GetDefaultFacts();

        /// <inheritdoc />
        public abstract IFactRuleCollection GetRules();

        /// <inheritdoc />
        public virtual ISingleEntityOperations GetSingleEntityOperations()
        {
            return GetFacade<VersionedSingleEntityOperationsFacade>();
        }

        /// <inheritdoc />
        public virtual IFactContainer GetDefaultContainer()
        {
            return new FactContainer();
        }
    }
}
