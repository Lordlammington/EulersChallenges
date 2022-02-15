using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public static class Factorial
    {

        public static BigInteger FactorialOf(long input)
        {
            switch (input)
            {
                case < 0:
                    throw new ArgumentOutOfRangeException();
                case 0:
                    return 1;
            }

            BigInteger result = input;

            for (int i = 1; i < input; i++)
            {
                result *= i;

                // =+ +=

            }

            return result;
        }
    }
}
