using GetcuReone.FactFactory;
using GetcuReone.FactFactory.Helpers;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Versioned;
using GetcuReone.FactFactory.Versioned.Entities;
using GetcuReone.FactFactory.Versioned.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Fact factory.
    /// </summary>
    public class GrFactFactory : VersionedFactFactoryBase<VersionedFactBase, VersionedFactContainer, GrFactRule, GrFactRuleCollection, GrWantAction>
    {
        private readonly Func<List<IVersionFact>> _getAllVersionFactsFunc;

        /// <summary>
        /// Action for logging.
        /// </summary>
        public Action<string> WriteLogAction { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="rulles"></param>
        /// <param name="getAllVersionFactsFunc">Function that returns all versioned facts used in the rules.</param>
        public GrFactFactory(VersionedFactContainer container, GrFactRuleCollection rulles, Func<List<IVersionFact>> getAllVersionFactsFunc)
        {
            _getAllVersionFactsFunc = getAllVersionFactsFunc;
            Container = container;
            Rules = rulles;
        }

        /// <summary>
        /// Container.
        /// </summary>
        public override VersionedFactContainer Container { get; }

        /// <summary>
        /// Rule collection.
        /// </summary>
        public override GrFactRuleCollection Rules { get; }

        /// <summary>
        /// Derive the facts.
        /// </summary>
        public override void Derive()
        {
            if (WriteLogAction != null)
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine("FactFactory | Derive");

                if (!Container.IsNullOrEmpty())
                {
                    stringBuilder.Append("There are facts in the container: " + string.Join(", ", Container.Select(fact => fact.GetFactType().FactName)));
                }
                else
                    stringBuilder.Append("No facts in container.");

                WriteLogAction(stringBuilder.ToString());
            }

            base.Derive();
        }

        /// <summary>
        /// Creation method <see cref="IWantAction{TFact}"/>.
        /// </summary>
        /// <param name="wantAction">action taken after deriving a fact.</param>
        /// <param name="factTypes">facts required to launch an action.</param>
        /// <returns></returns>
        protected override GrWantAction CreateWantAction(Action<IFactContainer<VersionedFactBase>> wantAction, IReadOnlyCollection<IFactType> factTypes)
        {
            return new GrWantAction(wantAction, factTypes) { WriteLogAction = WriteLogAction };
        }

        /// <summary>
        /// Returns instances of all used versions.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<IVersionFact> GetAllVersions()
        {
            return _getAllVersionFactsFunc?.Invoke() ?? Enumerable.Empty<IVersionFact>();
        }

        /// <summary>
        /// Get fact type.
        /// </summary>
        /// <typeparam name="TGetFact"></typeparam>
        /// <returns></returns>
        protected override IFactType GetFactType<TGetFact>()
        {
            return new FactType<TGetFact>();
        }
    }
}
