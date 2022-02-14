using Functions;
using ProjectEuler;
using Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Challenge25 : IRunChallenge
    {

        //first index of the item in the fibb sequence to contain 1000 DIGITS

        //have a function the tretuns the n# of digits of an inputted nuber
        public BigInteger RunChallenge()
        {
            var (number, index) = Fibonacci.Sequence().Select((number, i) => (number, i)).First(it => InputNumberAs.CountOfDigits(it.number) == 1000);
            var bar = index;

            //Bar is off by 1, investigate why...
            //answer is 4782 but i'm getting 4781
            return bar +1;
        }
    }
}
