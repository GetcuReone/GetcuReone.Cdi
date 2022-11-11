using GetcuReone.Cdo.Logging;
using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Interfaces;
using Newtonsoft.Json;
using NLog;
using System.Runtime.CompilerServices;

namespace GetcuReone.Cdi
{
    /// <summary>
    /// Base clas for facades.
    /// </summary>
    public abstract class BaseGrFacade : ComboPatterns.Facade.FacadeBase, IAdapterCreation
    {
        /// <summary>
        /// Facade name.
        /// </summary>
        protected abstract string FacadeName { get; }

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

        /// <summary>
        /// Logs a method call without parameters.
        /// </summary>
        /// <param name="methodName"></param>
        protected virtual void CallMethodLogging([CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Facade}{Tags.Call} {FacadeName}.{methodName}");
        }

        /// <summary>
        /// Logs a method call with parameter.
        /// </summary>
        /// <typeparam name="TParameter"></typeparam>
        /// <param name="methodName"></param>
        /// <param name="parameter"></param>
        protected virtual void CallMethodLogging<TParameter>(TParameter parameter, [CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Facade}{Tags.Call} {FacadeName}.{methodName}\nparameter: {JsonConvert.SerializeObject(parameter)}");
        }

        /// <summary>
        /// Logs no response.
        /// </summary>
        protected virtual void ReturnLogging([CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Facade}{Tags.Result} {FacadeName}.{methodName}:\nresult: void");
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
            WriteLog(() => $"{Tags.Facade}{Tags.Result} {FacadeName}.{methodName}\nparameter: {JsonConvert.SerializeObject(returnedObj)}");
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
            WriteLog(() => $"{Tags.Facade}{Tags.Result} {FacadeName}.{methodName}:\nresult: not logging obj");
            return returnedObj;
        }

        /// <summary>
        /// Get adapter.
        /// </summary>
        /// <typeparam name="TAdapter"></typeparam>
        /// <returns></returns>
        public virtual TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            if (Factory is IAdapterCreation adapterCreation)
                return adapterCreation.GetAdapter<TAdapter>();

            return AdapterBase.Create<TAdapter>(Factory);
        }
    }
}
