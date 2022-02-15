using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    public class Challenge27 : IRunChallenge
    {
        public BigInteger RunChallenge()
        {
            //
            // n * n + n + 41;
            // if N is odd then it would result in an odd number (Odd numbers are primes)
            // if n is even then even + odd = odd, so n in this example can be even or odd.
            // 


            long aHigh = 0;
            long bHigh = 0;
            long runningHigh = 0;

            for (int a = -999; a < 1000; a++)
            {
                for (int b = -999; b <= 1000; b++)
                {
                    var nList = NaturalNumbers.Sequence().Take((a * -1) -1 );

                    bool isAllPrimes = true;
                    long numOfPrimes = 0;

                    foreach (var n in nList)
                    {
                       long result = QuadraticEquation(a, b, (long)n);

                       if (!PrimeNumbers.CheckForPrime(result))
                       {
                           isAllPrimes = false;
                           break;
                       }
                       else
                       {
                           numOfPrimes++;
                       }

                    }

                    if (isAllPrimes && runningHigh < numOfPrimes)
                    {
                        runningHigh = numOfPrimes;
                        aHigh = a;
                        bHigh = b;
                    }


                }
            }





            return bHigh * aHigh;
        }

        private long QuadraticEquation(long a, long b, long n)
        {
            return (n * n)+ (a * n) + b;
        }
    }
}