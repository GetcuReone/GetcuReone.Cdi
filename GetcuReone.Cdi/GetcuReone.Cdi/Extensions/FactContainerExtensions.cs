using GetcuReone.FactFactory.Interfaces;

namespace GetcuReone.Cdi.Extensions
{
    /// <summary>
    /// Extensions methods for <see cref="IFactContainer"/>
    /// </summary>
    public static class FactContainerExtensions
    {
        /// <summary>
        /// Update or add fact.
        /// </summary>
        /// <typeparam name="TFact"></typeparam>
        /// <typeparam name="TFactContainer"></typeparam>
        /// <param name="container"></param>
        /// <param name="fact"></param>
        /// <returns><paramref name="container"/></returns>
        public static TFactContainer UpdateFact<TFactContainer, TFact>(this TFactContainer container, TFact fact)
            where TFactContainer : IFactContainer
            where TFact : IFact
        {
            if (container.TryGetFact(out TFact fact1))
                container.Remove(fact1);

            container.Add(fact);

            return container;
        }
    }
}
