using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonachiGenerator
{
    /// <summary>
    /// Contains method for generating numbers.
    /// </summary>
    public static class Generator
    {
        /// <summary>
        /// Generates fibonachi numbers.
        /// </summary>
        /// <param name="count">Count of numbers.</param>
        /// <returns>Fibonachi numbers.</returns>
        public static IEnumerable<BigInteger> GenerateFibonachi(int count)
        {
            if(count <= 0)
            {
                throw new ArgumentException($"{nameof(count)} can't be or equal 0");
            }

            return Generate(count);
        }

        private static IEnumerable<BigInteger> Generate(int count)
        {
            BigInteger first = 0, second = 1, sum;

            for (int i = count; i > 0; i--)
            {
                yield return first;

                sum = first + second;
                first = second;
                second = sum;
            }         
        }
    }
}
