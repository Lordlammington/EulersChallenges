using System;
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
        public static List<long[]> List(this long calculateUntil)
        {
            //count up to Calculate until
            //Get a list of all divisors, and sum them
            //Check 

            //Generate 2 lists of natural numbers up to the calculate until
            //find some way to verify if numbers are Amicable
            NaturalNumbers natural = new NaturalNumbers();

            var seedSetA = natural.Take((int)calculateUntil);
            var seedSetB = natural.Take((int)calculateUntil);


            List<long[]> PairsOfAmicableNumbers = new List<long[]>();


            foreach (var seedNumberA in seedSetA)
            {
                foreach (var seedNumberB in seedSetB)
                {
                    if (IsAmicable(seedNumberA, seedNumberB))
                    {
                        PairsOfAmicableNumbers.Add(new[] {seedNumberA, seedNumberB});
                    }

                }

            }

            return PairsOfAmicableNumbers;
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
