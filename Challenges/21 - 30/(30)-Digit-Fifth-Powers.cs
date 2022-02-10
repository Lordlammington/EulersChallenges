using ProjectEuler;
using Enumerators;
using Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Challenge30 : IRunChallenge
    {
        public long _exponent;
        public long RunChallenge()
        {
            //upper bound 354294
            List<long> DigitSums = new List<long>();

            for (int i = 2; i < 354294; i++)
            {
                var digitlist = InputNumberAs.ListOfDigits(i);
                long powerSum = 0;

                foreach (var digit in digitlist)
                {
                    powerSum = powerSum + (long)Math.Pow(digit, _exponent);

                }

                if (powerSum == i)
                {
                    DigitSums.Add(i);
                }

            }

            //what is the maximum number?

            return DigitSums.Sum();
        }
    }
}
