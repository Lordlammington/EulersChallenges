using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace Enumerators
{
    public static class NaturalNumberCountdown 
    {
        public static IEnumerable<BigInteger> Sequence(BigInteger startingNum)
        {
            do
            {
                yield return startingNum;
                startingNum--;
                
            } while (startingNum > 0);
        }
    }
}
