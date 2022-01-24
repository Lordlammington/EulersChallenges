using System.Collections.Generic;

namespace Enumerators
{
    public static class CollatzSeries
    {
        public static IEnumerable<long> Sequence(this long source)
        {
            long current = source;

            do
            {

                yield return current;
                if (current == 1) break;
                if (current % 2 == 0) current /= 2L;
                else current = 3L * current + 1;

            } while (true);
        }
    }
}