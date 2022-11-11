using GetcuReone.Cdo.Logging;
using GetcuReone.ComboPatterns.Adapter;
using Newtonsoft.Json;
using NLog;
using System.Runtime.CompilerServices;

namespace GetcuReone.Cdi
{
    /// <summary>
    /// Base class for adapters.
    /// </summary>
    public abstract class BaseGrAdapter : AdapterBase
    {
        /// <summary>
        /// Adapter name.
        /// </summary>
        protected abstract string AdapterName { get; }

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
            WriteLog(() => $"{Tags.Adapter}{Tags.Call} {AdapterName}.{methodName}");
        }

        /// <summary>
        /// Logs a method call with parameter.
        /// </summary>
        /// <typeparam name="TParameter"></typeparam>
        /// <param name="methodName"></param>
        /// <param name="parameter"></param>
        protected virtual void CallMethodLogging<TParameter>(TParameter parameter, [CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Adapter}{Tags.Call} {AdapterName}.{methodName}\nparameter: {JsonConvert.SerializeObject(parameter)}");
        }

        /// <summary>
        /// Logs no response.
        /// </summary>
        protected virtual void ReturnLogging([CallerMemberName] string methodName = "")
        {
            WriteLog(() => $"{Tags.Adapter}{Tags.Result} {AdapterName}.{methodName}:\nresult: void");
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
            WriteLog(() => $"{Tags.Adapter}{Tags.Result} {AdapterName}.{methodName}\nparameter: {JsonConvert.SerializeObject(returnedObj)}");
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
            WriteLog(() => $"{Tags.Adapter}{Tags.Result} {AdapterName}.{methodName}:\nresult: not logging obj");
            return returnedObj;
        }
    }
}
