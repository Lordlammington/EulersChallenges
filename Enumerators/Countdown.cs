using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerators
{
    public static class NaturalNumberCountdown 
    {
        public static IEnumerable<long> Sequence(long startingNum)
        {
            do
            {
                yield return startingNum;
                startingNum--;
                
            } while (startingNum > 0);
        }
    }
}
