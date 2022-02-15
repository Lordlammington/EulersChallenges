using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler;

namespace Functions
{
    public static class Divisors
    {
        public static long Count(long input)
        {
            var numberOfDivisors = 0;
            var sqrt = (int) Math.Sqrt(input);

            for (var i = 1; i <= sqrt; i++)
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
            var listOfOfDivisors = new List<long>();

            for (var i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    listOfOfDivisors.Add(i);
                }
            }

            return listOfOfDivisors;
        }

        public static bool IsPerfectNumber(long input)
        {
            var listOfOfDivisors = new List<long>();

            for (var i = 1; i <= input; i++)
            {
                if (input % i == 0 && i != input)
                {
                    listOfOfDivisors.Add(i);
                }
            }

            if (listOfOfDivisors.Sum() == input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsAbundantNumber(BigInteger input)
        {
            var listOfOfDivisors = new List<long>();

            for (var i = 1; i <= input; i++)
            {
                if (input % i == 0 && i != input)
                {
                    listOfOfDivisors.Add(i);
                }
            }

            if (listOfOfDivisors.Sum() > input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
