using GetcuReone.FactFactory.BaseEntities;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Versioned;
using GetcuReone.FactFactory.Versioned.BaseEntities;
using System;
using System.Collections.Generic;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Fact rule collection.
    /// </summary>
    public class GrFactRuleCollection : VersionedFactRuleCollectionBase<VersionedFactBase, GrFactRule>
    {
        /// <summary>
        /// Action for logging.
        /// </summary>
        public Action<string> WriteLogAction { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public GrFactRuleCollection()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="factRules"></param>
        public GrFactRuleCollection(IEnumerable<GrFactRule> factRules) : base(factRules)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="factRules"></param>
        /// <param name="isReadOnly"></param>
        public GrFactRuleCollection(IEnumerable<GrFactRule> factRules, bool isReadOnly) : base(factRules, isReadOnly)
        {
        }

        /// <summary>
        /// <see cref="FactRuleCollectionBase{TFact, TFactRule}"/> copy method.
        /// </summary>
        /// <returns>Copied <see cref="VersionedFactRuleCollection"/>.</returns>
        public override FactRuleCollectionBase<VersionedFactBase, GrFactRule> Copy()
        {
            return new GrFactRuleCollection(this, IsReadOnly) { WriteLogAction = WriteLogAction };
        }

        /// <summary>
        /// Creation method <see cref="VersionedFactRule"/>.
        /// </summary>
        /// <param name="func">func for calculate</param>
        /// <param name="inputFactTypes">information on input factacles rules.</param>
        /// <param name="outputFactType">information on output fact.</param>
        /// <returns></returns>
        protected override GrFactRule CreateFactRule(Func<IFactContainer<VersionedFactBase>, IWantAction<VersionedFactBase>, VersionedFactBase> func, List<IFactType> inputFactTypes, IFactType outputFactType)
        {
            return new GrFactRule(func, inputFactTypes, outputFactType, WriteLogAction);
        }
    }
}
