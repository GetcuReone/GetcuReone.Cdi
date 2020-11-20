using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdo.Logging;
using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Facade;
using GetcuReone.ComboPatterns.Factory;
using GetcuReone.ComboPatterns.Interfaces;
using NLog;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace GetcuReone.Cdi
{
    /// <inheritdoc/>
    /// <remarks>Added logging.</remarks>
    public abstract class GrFactoryBase : FactoryBase, IFacadeCreation, IAdapterCreation
    {
        private GrFactFactory _grFactFactory;

        /// <summary>
        /// Factory name.
        /// </summary>
        protected abstract string FactoryName { get; }

        /// <summary>
        /// Logger.
        /// </summary>
        protected NLogAdapter NLogger => _nLogAdapter ?? (_nLogAdapter = GetAdapter<NLogAdapter>());
        private NLogAdapter _nLogAdapter;

        /// <inheritdoc/>
        public virtual TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            return AdapterBase.Create<TAdapter>(this);
        }

        /// <inheritdoc/>
        public virtual TFacade GetFacade<TFacade>() where TFacade : IFacade, new()
        {
            return FacadeBase.Create<TFacade>(this);
        }

        /// <summary>
        /// Get fact factory.
        /// </summary>
        /// <typeparam name="TFactRulesProvider"></typeparam>
        /// <param name="needNewFactory"></param>
        /// <returns></returns>
        public virtual GrFactFactory GetFactFactory<TFactRulesProvider>(bool needNewFactory = false)
            where TFactRulesProvider : GrFactRulesProviderBase, new()
        {
            if (_grFactFactory == null || needNewFactory || !_grFactFactory.IsRulesProvider<TFactRulesProvider>())
                _grFactFactory = CdiHelper.CreateFactFactory<TFactRulesProvider>(this);
            return _grFactFactory;
        }

        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="messageFunc"></param>
        protected virtual void WriteLog(LogMessageGenerator messageFunc)
        {
            NLogger.Info(messageFunc);
        }

        /// <summary>
        /// Logs a method call without parameters.
        /// </summary>
        /// <param name="methodName"></param>
        protected virtual void CallMethodLogging([CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Factory}{Tags.Call} {FactoryName}.{methodName}");
        }

        /// <summary>
        /// Logs a method call with parameter.
        /// </summary>
        /// <typeparam name="TParameter"></typeparam>
        /// <param name="methodName"></param>
        /// <param name="parameter"></param>
        protected virtual void CallMethodLogging<TParameter>(TParameter parameter, [CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Factory}{Tags.Call} {FactoryName}.{methodName}\nparameter: {JsonConvert.SerializeObject(parameter)}");
        }

        /// <summary>
        /// Logs no response.
        /// </summary>
        protected virtual void ReturnLogging([CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Factory}{Tags.Result} {FactoryName}.{methodName}:\nresult: void");
        }

        /// <summary>
        /// Logs the result of a method.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="returnedObj"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        protected virtual TResult ReturnLogging<TResult>(TResult returnedObj, [CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Factory}{Tags.Result} {FactoryName}.{methodName}\nparameter: {JsonConvert.SerializeObject(returnedObj)}");
            return returnedObj;
        }

        /// <summary>
        /// Add information to the log that the object is not logged.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="returnedObj"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        protected virtual TResult ReturnNotLogging<TResult>(TResult returnedObj, [CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Factory}{Tags.Result} {FactoryName}.{methodName}:\nresult: not logging obj");
            return returnedObj;
        }
    }
}
