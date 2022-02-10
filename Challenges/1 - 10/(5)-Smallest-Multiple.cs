using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler;
using Enumerators;

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

            return NaturalNumbers.Sequence().Where(x => DivIntoArrayRemainderCheck(x)).First();


            bool DivIntoArrayRemainderCheck(long input)
            {
               
                foreach (int divisor in _Divisors)
                {
                    //mod the number by each number in the array
                    if (input % divisor != 0)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}
