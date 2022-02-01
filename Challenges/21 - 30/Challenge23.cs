using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerators;
using Functions;
using ProjectEuler.Enumerators;

namespace Challenges
{
    public class Challenge23 : IRunChallenge
    {

        public long RunChallenge()
        {
            NaturalNumbers naturalNumbers = new NaturalNumbers();

            var integers = naturalNumbers.Take(28123);
            List<long> AbundantSums = new List<long>();


            foreach (var integer in integers)
            {

                //Get number
                if (Divisors.IsAbundantNumber(integer))
                {
                    AbundantSums.Add(integer + integer);
                }
                else
                {
                    continue;
                }
            }

            //Somehow take the list of Abundant sums and remove them from a list of integers.


            

            return 10;
        }
    }
}