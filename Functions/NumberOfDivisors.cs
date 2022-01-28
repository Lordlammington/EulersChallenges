using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler;

namespace Functions
{
    public static class Divisors
    {
        public static long Count(long input)
        {
            int numberOfDivisors = 0;
            int sqrt = (int)Math.Sqrt(input);

            for (int i = 1; i <= sqrt; i++)
            {
                if (input % i == 0)
                {
                    numberOfDivisors += 2;
                }
            }

            if (sqrt * sqrt == input)
            {
                numberOfDivisors--;
            }

            return numberOfDivisors;
        }

        public static List<long> List(long input)
        {
            List<long> listOfOfDivisors = new List<long>();

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    listOfOfDivisors.Add(i);
                }
            }

            return listOfOfDivisors;
        }
    }
}
