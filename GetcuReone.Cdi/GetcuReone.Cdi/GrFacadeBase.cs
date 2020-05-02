using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdo.Adapters.Logger;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory.Versioned.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GetcuReone.Cdi
{
    /// <summary>
    /// Base clas for facades.
    /// </summary>
    public abstract class GrFacadeBase : ComboPatterns.Facade.FacadeBase, IAdapterCreation
    {
        private GrFactFactory _grFactFactory;

        private string _teg => "[facade]";

        /// <summary>
        /// Facade name.
        /// </summary>
        protected abstract string FacadeName { get; }

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
            WriteLog($"{_teg}[call] {FacadeName}.{methodName}");
        }

        /// <summary>
        /// Logs a method call with parameter.
        /// </summary>
        /// <typeparam name="TParameter"></typeparam>
        /// <param name="methodName"></param>
        /// <param name="parameter"></param>
        protected virtual void CallMethodLogging<TParameter>(TParameter parameter, [CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[call] {FacadeName}.{methodName}\n" + "parameter: {0}", parameter);
        }

        /// <summary>
        /// Logs no response.
        /// </summary>
        protected virtual void ReturnLogging([CallerMemberName]string methodName = "")
        {
            WriteLog($"{_teg}[result] {FacadeName}.{methodName}:\nresult: void");
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
            WriteLog($"{_teg}[result] {FacadeName}.{methodName}:\n" + "result: {0}", returnedObj);
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
            WriteLog($"{_teg}[result] {FacadeName}.{methodName}:\n" + "result: not logging obj");
            return returnedObj;
        }

        /// <summary>
        /// Get fact factory.
        /// </summary>
        /// <typeparam name="TRulesProvider"></typeparam>
        /// <param name="container"></param>
        /// <param name="isOnlyNewFactory"></param>
        /// <returns></returns>
        protected virtual GrFactFactory GetFactFactory<TRulesProvider>(VersionedFactContainer container, bool isOnlyNewFactory = false)
            where TRulesProvider : GrFactRulesProviderBase, new()
        {
            if (_grFactFactory == null || isOnlyNewFactory)
                return _grFactFactory = CdiHelper.CreateFactFactory<TRulesProvider>(Factory, container);

            _grFactFactory.Container.Clear();

            foreach (var fact in container)
                _grFactFactory.Container.Add(fact);

            return _grFactFactory;
        }

        /// <summary>
        /// Get adapter.
        /// </summary>
        /// <typeparam name="TAdapter"></typeparam>
        /// <returns></returns>
        public virtual TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            return ComboPatterns.Adapter.AdapterBase.Create<TAdapter>(Factory);
        }
    }
}
