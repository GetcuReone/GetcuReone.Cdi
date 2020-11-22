using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdm.Errors;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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
        /// <returns></returns>
        public static GrFactFactory CreateFactFactory<TRulesProvider>(IAbstractFactory factory)
            where TRulesProvider : GrFactRulesProviderBase, new()
        {
            var provider = new TRulesProvider { Factory = factory };
            return new GrFactFactory(provider);
        }

        /// <summary>
        /// Provider type check.
        /// </summary>
        /// <param name="factFactory"></param>
        /// <typeparam name="TRulesProvider"></typeparam>
        /// <returns></returns>
        public static bool IsRulesProvider<TRulesProvider>(this GrFactFactory factFactory)
        {
            return factFactory._provider is TRulesProvider;
        }

        /// <summary>
        /// Update or add fact.
        /// </summary>
        /// <typeparam name="TFact"></typeparam>
        /// <typeparam name="TFactContainer"></typeparam>
        /// <param name="container"></param>
        /// <param name="fact"></param>
        public static void UpdateFact<TFactContainer, TFact>(this TFactContainer container, TFact fact)
            where TFactContainer : IFactContainer
            where TFact : IFact
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

        /// <summary>
        /// Create exception.
        /// </summary>
        /// <param name="code">error code.</param>
        /// <param name="reason">error reason.</param>
        /// <returns></returns>
        public static GetcuReoneException CreateException(string code, string reason)
        {
            return CreateException(new List<ErrorDetail>
            {
                new ErrorDetail
                {
                    Code = code,
                    Reason = reason,
                },
            });
        }

        /// <summary>
        /// Create exception.
        /// </summary>
        /// <param name="details"></param>
        /// <returns></returns>
        public static GetcuReoneException CreateException(List<ErrorDetail> details)
        {
            return new GetcuReoneException(details.MayBeNull().ToReadOnlyCollection());
        }

        /// <summary>
        /// If the <paramref name="items"/> is null it will create a new empty list.
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static List<TItem> MayBeNull<TItem>(this List<TItem> items)
        {
            return items ?? new List<TItem>();
        }

        /// <summary>
        /// Is null or empty.
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<TItem>(this IEnumerable<TItem> items)
        {
            return items == null || !items.Any();
        }
    }
}
