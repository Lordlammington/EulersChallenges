﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenges;
using ProjectEuler;

namespace Challenges
{
    public class Challenge1 : IRunChallenge
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
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
