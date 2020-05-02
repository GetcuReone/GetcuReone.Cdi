using GetcuReone.Cdo.Adapters.Logger;
using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory.Versioned.Interfaces;
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

        /// <summary>
        /// Get adapter.
        /// </summary>
        /// <typeparam name="TAdapter"></typeparam>
        /// <returns></returns>
        public virtual TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            return AdapterBase.Create<TAdapter>(Factory);
        }

        /// <summary>
        /// Get facade.
        /// </summary>
        /// <typeparam name="TFacade"></typeparam>
        /// <returns></returns>
        public virtual TFacade GetFacade<TFacade>() where TFacade : IFacade, new()
        {
            return ComboPatterns.Facade.FacadeBase.Create<TFacade>(Factory);
        }

        /// <summary>
        /// Get all versions.
        /// </summary>
        /// <returns></returns>
        public abstract List<IVersionFact> GetVersions();

        /// <summary>
        /// Get all rules.
        /// </summary>
        /// <returns></returns>
        public abstract GrFactRuleCollection GetRules();

        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="message"></param>
        public virtual void WriteLog(string message)
        {
            GetAdapter<NLogAdapter>().Debug(message);
        }
    }
}
