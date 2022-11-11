using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GetcuReone.Cdi.Extensions
{
    /// <summary>
    /// Extensions methods for <see cref="List{T}"/>
    /// </summary>
    public static class ListExtensions
    {
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
        /// If the <paramref name="items"/> is null it will create a new empty list.
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static List<TItem> MayBeNull<TItem>(this List<TItem> items)
        {
            return items ?? new List<TItem>();
        }
    }
}
