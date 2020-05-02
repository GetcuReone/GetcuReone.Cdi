using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Versioned;
using GetcuReone.FactFactory.Versioned.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Fact rule.
    /// </summary>
    public class GrFactRule : VersionedFactRuleBase<VersionedFactBase>
    {
        /// <summary>
        /// Action for logging.
        /// </summary>
        public Action<string> WriteLogAction { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="func"></param>
        /// <param name="inputFactTypes"></param>
        /// <param name="outputFactType"></param>
        /// <param name="writeLogFunc"></param>
        public GrFactRule(Func<IFactContainer<VersionedFactBase>, IWantAction<VersionedFactBase>, VersionedFactBase> func, List<IFactType> inputFactTypes, IFactType outputFactType, Action<string> writeLogFunc = null) : base(func, inputFactTypes, outputFactType)
        {
            WriteLogAction = writeLogFunc;
        }

        /// <summary>
        /// Rule of fact calculate.
        /// </summary>
        /// <typeparam name="TContainer"></typeparam>
        /// <typeparam name="TWantAction"></typeparam>
        /// <param name="container"></param>
        /// <param name="wantAction"></param>
        /// <returns></returns>
        public override VersionedFactBase Calculate<TContainer, TWantAction>(TContainer container, TWantAction wantAction)
        {
            WriteLogAction?.Invoke($"FactFactory | FactRule.Calculate | [start] {ToString()}");

            VersionedFactBase versionedFact = base.Calculate(container, wantAction);

            WriteLogAction?.Invoke($"FactFactory | FactRule.Calculate | [finish] {ToString()}");

            return versionedFact;
        }
    }
}
