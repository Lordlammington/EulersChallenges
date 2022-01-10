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
        public int[] _Divisors; 
        public int RunChallenge()
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
