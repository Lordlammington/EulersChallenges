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
            var amicablePairs = new Dictionary<long, long>();
            long foo = 0;

            var divisorPairs = NaturalNumbers.Sequence().Take((int) calculateUntil).ToDictionary(natnumber => natnumber, natnumber => Divisors.List((long)natnumber).SkipLast(1).Sum());

            foreach (var x in divisorPairs)
            {
                if (x.Key == 0 || x.Value == 0 || x.Key > calculateUntil || x.Value > calculateUntil )
                {
                    continue;
                }

                long a = divisorPairs[x.Key];                


                if (x.Key == divisorPairs[a] && x.Key != x.Value && foo != x.Key)
                {
                    amicablePairs.Add((long)x.Key, x.Value);
                    foo = x.Value;
                }

            }

            return amicablePairs;

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
