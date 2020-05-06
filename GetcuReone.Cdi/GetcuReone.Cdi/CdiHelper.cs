using GetcuReone.Cdi.FactFactory;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory.Versioned;
using GetcuReone.FactFactory.Versioned.BaseEntities;
using GetcuReone.FactFactory.Versioned.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        /// <summary>
        /// Update or add fact.
        /// </summary>
        /// <typeparam name="TFact"></typeparam>
        /// <param name="container"></param>
        /// <param name="fact"></param>
        public static void UpdateFact<TFact>(this VersionedFactContainerBase<VersionedFactBase> container, TFact fact)
            where TFact : VersionedFactBase
        {
            if (container.TryGetFact(out TFact fact1))
                container.Remove(fact1);

            container.Add(fact);
        }

        /// <summary>
        /// To <see cref="ReadOnlyCollection{TItem}"/>
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static ReadOnlyCollection<TItem> ToReadOnlyCollection<TItem>(this IList<TItem> list)
        {
            return new ReadOnlyCollection<TItem>(list);
        }

        /// <summary>
        /// <see cref="string.Equals(string)"/> with <see cref="StringComparison.Ordinal"/>.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool EqualsOrdinal(this string first, string second)
        {
            return first.Equals(second, StringComparison.Ordinal);
        }

        /// <summary>
        /// <see cref="string.Equals(string)"/> with <see cref="StringComparison.OrdinalIgnoreCase"/>.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool EqualsOrdinalIgnoreCase(this string first, string second)
        {
            return first.Equals(second, StringComparison.OrdinalIgnoreCase);
        }
    }
}
