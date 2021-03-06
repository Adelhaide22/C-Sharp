using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Algorithms.Other
{
    public static class SieveOfEratosthenes
    {
        public static List<BigInteger> GetPrimeNumbers(int count)
        {
            var output = new List<BigInteger>();
            for (BigInteger n = 2; output.Count < count; n++)
            {
                if (output.All(x => n % x != 0))
                {
                    output.Add(n);
                }
            }

            return output;
        }
    }
}
