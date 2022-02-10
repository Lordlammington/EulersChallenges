using System;
using System.Linq;
using ProjectEuler;
using Enumerators;

namespace Challenges
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Challenge1 : IRunChallenge
    {

        public int CalculateUntilNotIncluding { get; set; }
        public long RunChallenge()
        {

            long sum = NaturalNumbers.Sequence().TakeWhile(x => x < CalculateUntilNotIncluding).Where(x => (x % 3 == 0) || x % 5 == 0).Sum();
            Console.WriteLine(sum);
            return sum;
        }
    }
}
