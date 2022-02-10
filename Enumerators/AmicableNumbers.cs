using System;
using System.Collections.Generic;
using System.Linq;
using Functions;

namespace Enumerators
{
    public static class AmicableNumbers
    {


        //This probably could do with a re write to be honest...


        public static Dictionary<long, long> List(this long calculateUntil)
        {

            Dictionary<long, long> DivisorPairs = new Dictionary<long, long>();
            Dictionary<long, long> AmicablePairs = new Dictionary<long, long>();
            long foo = 0;

            foreach (var natnumber in NaturalNumbers.Sequence().Take((int)calculateUntil))
            {
                DivisorPairs.Add(natnumber, Divisors.List(natnumber).SkipLast(1).Sum());
            }

            foreach (var x in DivisorPairs)
            {
                if (x.Key == 0 || x.Value == 0 || x.Key > calculateUntil || x.Value > calculateUntil )
                {
                    continue;
                }

                long a = DivisorPairs[x.Key];                


                if (x.Key == DivisorPairs[a] && x.Key != x.Value && foo != x.Key)
                {
                    AmicablePairs.Add(x.Key, x.Value);
                    foo = x.Value;
                }

            }

            return AmicablePairs;

        }

        public static bool IsAmicable(long A, long B)
        {
            var SumOfAllMultiplesOfA = Divisors.List(A).SkipLast(1).Sum();
            var SumOfAllMultiplesOfB = Divisors.List(B).SkipLast(1).Sum();

            if (SumOfAllMultiplesOfA == B && SumOfAllMultiplesOfB == A)
            {
                return true;
            }

            return false;
        }
    }
}
