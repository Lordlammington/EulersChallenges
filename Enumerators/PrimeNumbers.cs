﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators
{
    public class PrimeNumbers 
    {
        public static IEnumerable<long> Sequence()
        {
            long number = 1;
            do
            {
                if (CheckForPrime(number))
                {
                    yield return number;
                }

                number++;

            } while (true);
        }

        public static bool CheckForPrime(long naturalNumber)
        {

            if (naturalNumber <= 1) return false;
            if (naturalNumber == 2) return true;
            if (naturalNumber % 2 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(naturalNumber));

            for (long i = 3; i <= boundary; i += 2)
                if (naturalNumber % i == 0)
                    return false;

            return true;
        }

    }


    
}
