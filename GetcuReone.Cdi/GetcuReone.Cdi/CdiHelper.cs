using GetcuReone.Cdi.FactFactory;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory.Versioned.Entities;

namespace GetcuReone.Cdi
{
    /// <summary>
    /// Common domain infrastructure helper.
    /// </summary>
    public static class CdiHelper
    {
        /// <summary>
        /// Create fact factory.
        /// </summary>
        /// <typeparam name="TRulesProvider"></typeparam>
        /// <param name="factory"></param>
        /// <param name="container"></param>
        /// <returns></returns>
        public static GrFactFactory CreateFactFactory<TRulesProvider>(IAbstractFactory factory, VersionedFactContainer container)
            where TRulesProvider : GrFactRulesProviderBase, new()
        {
            var provider = new TRulesProvider { Factory = factory };

            var factFactory = new GrFactFactory(container, provider.GetRules(), provider.GetVersions)
            {
                WriteLogAction = provider.WriteLog,
            };

            foreach (var rule in factFactory.Rules)
                if (rule.WriteLogAction != provider.WriteLog)
                    rule.WriteLogAction = provider.WriteLog;

            return factFactory;
        }
    }
}
