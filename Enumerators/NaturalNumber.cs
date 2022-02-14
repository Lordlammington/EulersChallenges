using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using ProjectEuler;

namespace Enumerators
{
    public static class NaturalNumbers
    {
        public static IEnumerable<BigInteger> Sequence()
        {
            long number = 1;
            do
            {
                yield return number;
                number++;

            } while (true);
        }
    }
}

