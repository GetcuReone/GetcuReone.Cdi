using GetcuReone.FactFactory.Interfaces;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Fact Factory with Data Provider.
    /// </summary>
    public interface IGrFactFactory : IFactFactory
    {
        /// <inheritdoc cref="IGrFactRulesProvider"/>
        IGrFactRulesProvider Provider { get; }
    }
}
