using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler;

namespace Challenges
{
    public class Challenge5 : IRunChallenge
    {
        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public int[] _Divisors; 
        public long RunChallenge()
        {
            int possibleSmallestMultiple = _Divisors.Max();
            int isTheSmallestMultple = 0;

            restart:
            foreach (int divisor in _Divisors)
            {
                if (possibleSmallestMultiple % divisor == 0)
                {
                    isTheSmallestMultple++;
                }
            }

            if (isTheSmallestMultple != _Divisors.Length)
            {
                isTheSmallestMultple = 0;
                possibleSmallestMultiple++;
                goto restart;
            }




            //Define any set of whole numbers 
            //iterate a function that checks 
            return possibleSmallestMultiple;
        }
    }
}
