using GetcuReone.Cdi.Extensions;
using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdm.Errors;
using GetcuReone.ComboPatterns.Interfaces;
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
        /// <typeparam name="TProvider"></typeparam>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static IGrFactFactory CreateFactFactory<TProvider>(IAbstractFactory factory)
            where TProvider : IGrFactRulesProvider, new()
        {
            var provider = new TProvider();

            if (provider is BaseGrFactRulesProvider baseGrFactRulesProvider)
                baseGrFactRulesProvider.Factory = factory;

            return new GrFactFactory(provider);
        }

        /// <summary>
        /// To <see cref="ReadOnlyCollection{TItem}"/>
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="list"></param>
        /// <returns>Read-only collection.</returns>
        public static ReadOnlyCollection<TItem> ToReadOnlyCollection<TItem>(this IList<TItem> list)
        {
            return new ReadOnlyCollection<TItem>(list);
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
    }
}
