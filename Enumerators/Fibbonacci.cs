using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler;

namespace Enumerators
{
    public static class Fibonacci
    {
        public static IEnumerable<long> Sequence()
        {
            long primaryTerm = 0;
            long secondaryTerm = 1;
           
            do
            {
                long oldNumber2 = secondaryTerm;
                secondaryTerm = primaryTerm + secondaryTerm;
                yield return secondaryTerm;
                primaryTerm = oldNumber2;

            } while (true);
        }
    }
}
