using System.Collections.Generic;
using System.Linq;

namespace Enumerators
{
    public class TriangleNumbers
    {
        public static IEnumerable<long> Sequence()
        {
            NaturalNumbers naturalNumbers = new NaturalNumbers();
            long rowAddend = default;

            do
            {
                long triangleNumber = naturalNumbers.Take((int) rowAddend + 1).Sum();
                rowAddend++;
                yield return triangleNumber;

            } while (true);
        }
    }
}