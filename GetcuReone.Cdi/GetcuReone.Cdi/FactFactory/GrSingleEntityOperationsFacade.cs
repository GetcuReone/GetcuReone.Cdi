using GetcuReone.Cdo.Logging;
using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Interfaces.Context;
using GetcuReone.FactFactory.Interfaces.Operations.Entities;
using GetcuReone.FactFactory.Versioned.Facades.SingleEntityOperations;
using NLog;
using System.Threading.Tasks;

namespace GetcuReone.Cdi.FactFactory
{
    /// <inheritdoc/>
    /// <remarks>Added logging.</remarks>
    public class GrSingleEntityOperationsFacade : VersionedSingleEntityOperationsFacade, IAdapterCreation
    {
        /// <summary>
        /// Logger.
        /// </summary>
        protected NLogAdapter NLogger => _nLogAdapter ?? (_nLogAdapter = GetAdapter<NLogAdapter>());
        private NLogAdapter _nLogAdapter;

        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="messageFunc"></param>
        protected virtual void WriteLog(LogMessageGenerator messageFunc)
        {
            NLogger.Debug(messageFunc);
        }

        /// <inheritdoc/>
        public override IFact CalculateFact<TFactRule, TWantAction, TFactContainer>(NodeByFactRule<TFactRule> node, IWantActionContext<TWantAction, TFactContainer> context)
        {
            var fact = base.CalculateFact(node, context);
            WriteLog(() => $"FactFactory | FactRule\n{node.Info.Rule}\nInput facts: {string.Join(", ", GetRequireFacts(node.Info.Rule, context))}\nResult: {fact}");
            return fact;
        }

        /// <inheritdoc/>
        public override async ValueTask<IFact> CalculateFactAsync<TFactRule, TWantAction, TFactContainer>(NodeByFactRule<TFactRule> node, IWantActionContext<TWantAction, TFactContainer> context)
        {
            var fact = await base.CalculateFactAsync(node, context).ConfigureAwait(false);
            WriteLog(() => $"FactFactory | FactRule\n{node.Info.Rule}\nInput facts: {string.Join(", ", GetRequireFacts(node.Info.Rule, context))}\nResult: {fact}");
            return fact;
        }

        /// <inheritdoc/>
        public override void DeriveWantFacts<TWantAction, TFactContainer>(WantActionInfo<TWantAction, TFactContainer> wantActionInfo)
        {
            base.DeriveWantFacts(wantActionInfo);
            WriteLog(() => $"FactFactory | WantAction\n{wantActionInfo.Context.WantAction}\nInput facts: {string.Join(", ", GetRequireFacts(wantActionInfo.Context.WantAction, wantActionInfo.Context))}");
        }

        /// <inheritdoc/>
        public override async ValueTask DeriveWantFactsAsync<TWantAction, TFactContainer>(WantActionInfo<TWantAction, TFactContainer> wantActionInfo)
        {
            await base.DeriveWantFactsAsync(wantActionInfo).ConfigureAwait(false);
            WriteLog(() => $"FactFactory | WantAction\n{wantActionInfo.Context.WantAction}\nInput facts: {string.Join(", ", GetRequireFacts(wantActionInfo.Context.WantAction, wantActionInfo.Context))}");
        }

        /// <inheritdoc/>
        public virtual TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            if (Factory is IAdapterCreation adapterCreation)
                return adapterCreation.GetAdapter<TAdapter>();

            return AdapterBase.Create<TAdapter>(Factory);
        }
    }
}
