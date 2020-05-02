using GetcuReone.Cdo.Adapters.Logger;
using System;
using System.Runtime.CompilerServices;

namespace GetcuReone.Cdi
{
    /// <summary>
    /// Base class for adapters.
    /// </summary>
    public abstract class GrAdapterProxyBase<TProxy> : ComboPatterns.Adapter.AdapterProxyBase<TProxy>
    {
        private string _teg => "[adapter]";

        /// <summary>
        /// Adapter name.
        /// </summary>
        protected abstract string AdapterName { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="createProxyFunc"></param>
        protected GrAdapterProxyBase(Func<TProxy> createProxyFunc)
            : base(createProxyFunc)
        {
        }

        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="message"></param>
        protected virtual void WriteLog(string message)
        {
            GetAdapter<NLogAdapter>().Debug(message);
        }

        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="param"></param>
        protected virtual void WriteLog<TParam>(string message, TParam param)
        {
            GetAdapter<NLogAdapter>().Debug(message, param);
        }

        /// <summary>
        /// Logs a method call without parameters.
        /// </summary>
        /// <param name="methodName"></param>
        protected virtual void CallMethodLogging([CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[call] {AdapterName}.{methodName}");
        }

        /// <summary>
        /// Logs a method call with parameter.
        /// </summary>
        /// <typeparam name="TParameter"></typeparam>
        /// <param name="methodName"></param>
        /// <param name="parameter"></param>
        protected virtual void CallMethodLogging<TParameter>(TParameter parameter, [CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[call] {AdapterName}.{methodName}\n" + "parameter: {0}", parameter);
        }

        /// <summary>
        /// Logs no response.
        /// </summary>
        protected virtual void ReturnLogging([CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[result] {AdapterName}.{methodName}:\nresult: void");
        }

        /// <summary>
        /// Logs the result of a method.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="returnedObj"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        protected virtual TResult ReturnLogging<TResult>(TResult returnedObj, [CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[result] {AdapterName}.{methodName}:\n" + "result: {0}", returnedObj);
            return returnedObj;
        }

        /// <summary>
        /// Add information to the log that the object is not logged.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="returnedObj"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        protected virtual TResult ReturnNotLogging<TResult>(TResult returnedObj, [CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[result] {AdapterName}.{methodName}:\n" + "result: not logging obj");
            return returnedObj;
        }
    }

    /// <summary>
    /// Base class for adapters.
    /// </summary>
    public abstract class GrAdapterProxyBase<TProxy, TProxyParam> : ComboPatterns.Adapter.AdapterProxyBase<TProxy, TProxyParam>
    {
        private string _teg => "[adapter]";

        /// <summary>
        /// Adapter name.
        /// </summary>
        protected abstract string AdapterName { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="createProxyFunc"></param>
        protected GrAdapterProxyBase(Func<TProxyParam, TProxy> createProxyFunc)
            : base(createProxyFunc)
        {
        }

        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="message"></param>
        protected virtual void WriteLog(string message)
        {
            GetAdapter<NLogAdapter>().Debug(message);
        }

        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="param"></param>
        protected virtual void WriteLog<TParam>(string message, TParam param)
        {
            GetAdapter<NLogAdapter>().Debug(message, param);
        }

        /// <summary>
        /// Logs a method call without parameters.
        /// </summary>
        /// <param name="methodName"></param>
        protected virtual void CallMethodLogging([CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[call] {AdapterName}.{methodName}");
        }

        /// <summary>
        /// Logs a method call with parameter.
        /// </summary>
        /// <typeparam name="TParameter"></typeparam>
        /// <param name="methodName"></param>
        /// <param name="parameter"></param>
        protected virtual void CallMethodLogging<TParameter>(TParameter parameter, [CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[call] {AdapterName}.{methodName}\n" + "parameter: {0}", parameter);
        }

        /// <summary>
        /// Logs no response.
        /// </summary>
        protected virtual void ReturnLogging([CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[result] {AdapterName}.{methodName}:\nresult: void");
        }

        /// <summary>
        /// Logs the result of a method.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="returnedObj"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        protected virtual TResult ReturnLogging<TResult>(TResult returnedObj, [CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[result] {AdapterName}.{methodName}:\n" + "result: {0}", returnedObj);
            return returnedObj;
        }

        /// <summary>
        /// Add information to the log that the object is not logged.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="returnedObj"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        protected virtual TResult ReturnNotLogging<TResult>(TResult returnedObj, [CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[result] {AdapterName}.{methodName}:\n" + "result: not logging obj");
            return returnedObj;
        }
    }
}
