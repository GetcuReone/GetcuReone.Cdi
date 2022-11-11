using System;

namespace GetcuReone.Cdi.Extensions
{
    /// <summary>
    /// Extensions methods <see cref="string"/>
    /// </summary>
    public static class StringExtensions
    {
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
