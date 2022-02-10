using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;

namespace Enumerators
{
    public static class NaturalNumbers
    {
        public static IEnumerable<long> Sequence()
        {
            long startingnum = 1;
            do
            {
                yield return startingnum;
                startingnum++;

            } while (true);
        }
    }
}

