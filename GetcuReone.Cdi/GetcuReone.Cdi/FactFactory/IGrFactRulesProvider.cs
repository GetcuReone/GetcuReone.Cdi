using GetcuReone.FactFactory;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Interfaces.Operations;
using System.Collections.Generic;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Fact factory data provider
    /// </summary>
    public interface IGrFactRulesProvider
    {
        /// <summary>
        /// Get default facts.
        /// </summary>
        /// <returns>default facts.</returns>
        IEnumerable<IFact> GetDefaultFacts();

        /// <summary>
        /// Get fact rules.
        /// </summary>
        /// <returns>Fact rules.</returns>
        IFactRuleCollection GetRules();

        /// <inheritdoc cref="BaseFactFactory.GetSingleEntityOperations"/>
        ISingleEntityOperations GetSingleEntityOperations();

        /// <inheritdoc cref="BaseFactFactory.GetDefaultContainer"/>
        IFactContainer GetDefaultContainer();
    }
}
