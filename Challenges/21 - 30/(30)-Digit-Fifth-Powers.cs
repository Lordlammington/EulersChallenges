using ProjectEuler;
using Enumerators;
using Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Challenge30 : IRunChallenge
    {
        public long Exponent;
        public BigInteger RunChallenge()
        {
            //upper bound 354294
            var digitSums = new List<long>();

            for (var i = 2; i < 354294; i++)
            {
                var listOfDigits = InputNumberAs.ListOfDigits(i);
                var powerSum = listOfDigits.Sum(digit => (long) Math.Pow(digit, Exponent));

                if (powerSum == i)
                {
                    digitSums.Add(i);
                }

            }

            //what is the maximum number?

            return digitSums.Sum();
        }
    }
}
