using System.Numerics;

namespace Functions
{
    public class SquareRoot
    {
        public BigInteger Solve(BigInteger input)
        {

            return 10;
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

            for (int i = 0; i <= exponent; i++)
            {
                runningTotal *= numerator;
            }

            return runningTotal;
        }
    }
}