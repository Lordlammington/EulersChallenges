﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerators;
using Functions;

namespace ProjectEuler.Enumerators
{
    public static class AmicableNumbers
    {
        public static Dictionary<long, long> List(this long calculateUntil)
        {
            //count up to Calculate until
            //Get a list of all divisors, and sum them
            //Check 

            //Generate 2 lists of natural numbers up to the calculate until
            //find some way to verify if numbers are Amicable

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
                    //CHERCK FOR DUPLICATE
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
