using System.Numerics;
using System;

namespace Functions
{
    public class SquareRoot
    {
        public BigInteger Solve(BigInteger input)
        {
            return input;
        }
    }


    public class Exponents
    {
        public static BigInteger Square(BigInteger numerator)
        {
            return numerator * numerator;
        }

        public static BigInteger Cube(BigInteger numerator)
        {
            return numerator * numerator * numerator;
        }

        public static BigInteger Solve(BigInteger numerator, BigInteger exponent)
        {
            var runningTotal = numerator;

            for (int i = 1; i < exponent; i++)
            {
                runningTotal *= numerator;
            }

            return runningTotal;
        }
    }

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


            }

            return result;
        }
    }

}