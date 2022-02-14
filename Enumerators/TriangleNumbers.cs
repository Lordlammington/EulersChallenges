using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Xunit.Abstractions;

namespace Enumerators
{
    public class TriangleNumbers
    {
        public static IEnumerable<long> Sequence()
        {
            long rowAddend = default;

            do
            {
                var triangleNumber = NaturalNumbers.Sequence().Take((int) rowAddend + 1).Aggregate(BigInteger.Add);
                rowAddend++;
                yield return (long)triangleNumber;

            } while (true);
        }
    }
}