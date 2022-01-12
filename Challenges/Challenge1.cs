using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenges;
using ProjectEuler;
using ProjectEuler.Challenge1;

namespace Challenges
{
    public class Challenge1 : IRunChallenge
    {
        public int CalculateUntilNotIncluding { get; set; }
        public int RunChallenge()
        {
           NaturalNumbers shanesNaturalNumbers = new NaturalNumbers();

            var sum = shanesNaturalNumbers.TakeWhile(x => x < CalculateUntilNotIncluding).Where(x => (x % 3 == 0) || x % 5 == 0).Sum();
            Console.WriteLine(sum);
            return sum;
        }
    }
}
