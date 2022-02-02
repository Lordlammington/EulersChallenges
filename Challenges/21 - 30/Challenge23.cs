using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
            
            List<long> Abundants = new List<long>();

            foreach (var integer in integers)
            {

                //Get number
                if (Divisors.IsAbundantNumber(integer))
                {
                    Abundants.Add(integer);
                }

            }

            bool[] canBeWrittenasAbundent = new bool[28123 + 1];

            for (int i = 0; i < Abundants.Count; i++)
            {
                for (int j = i; j < Abundants.Count; j++)
                {
                    if (Abundants[i] + Abundants[j] <= 28123)
                    {
                        canBeWrittenasAbundent[Abundants[i] + Abundants[j]] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            long sum = 0;

            for (int i = 1; i <= 28123; i++)
            {
                if (!canBeWrittenasAbundent[i])
                {
                    sum += i;
                }
            }


            //Somehow take the list of Abundant sums and remove them from a list of integers.


            return sum;
        }
    }
}