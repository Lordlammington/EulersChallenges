using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Enumerators;
using Functions;

namespace Challenges
{
    public class Challenge23 : IRunChallenge
    {

        public BigInteger RunChallenge()
        {
            
            var abundantNumbers = NaturalNumbers.Sequence().Take(28123).Where(number => Divisors.IsAbundantNumber(number)).ToList();

            var canBeWrittenAsAbundant = new bool[28123 + 1];

            for (var i = 0; i < abundantNumbers.Count; i++)
            {
                for (var j = i; j < abundantNumbers.Count; j++)
                {
                    if (abundantNumbers[i] + abundantNumbers[j] <= 28123)
                    {
                        canBeWrittenAsAbundant[(int)(abundantNumbers[i] + abundantNumbers[j])] = true;
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
                if (!canBeWrittenAsAbundant[i])
                {
                    sum += i;
                }
            }


            //Somehow take the list of Abundant sums and remove them from a list of integers.


            return sum;
        }
    }
}