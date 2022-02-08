using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler;

namespace Enumerators
{
    public static class Fibonacci
    {
        public static IEnumerable<BigInteger> Sequence()
        {
            BigInteger primaryTerm = 0;
            BigInteger secondaryTerm = 1;
           
            do
            {
                yield return secondaryTerm;
                BigInteger oldNumber2 = secondaryTerm;
                secondaryTerm = primaryTerm + secondaryTerm;
                primaryTerm = oldNumber2;

            } while (true);
        }
    }
}
