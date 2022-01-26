using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Functions
{
    public static class InputNumberAs
    {
        public static List<long> ListOfDigits(BigInteger inputNumber)
        {
            List<long> everyDigit = new List<long>();

            while (!inputNumber.IsZero)
            {

                BigInteger digit = inputNumber % 10;
                everyDigit.Add((long)digit);
                inputNumber /= 10;
            }

            everyDigit.Reverse();
            return everyDigit;
        }

        public static long ListOfDigitsSummed(BigInteger inputNumber)
        {
            List<long> everyDigit = new List<long>();

            while (!inputNumber.IsZero)
            {

                BigInteger digit = inputNumber % 10;
                everyDigit.Add((long)digit);
                inputNumber /= 10;
            }

            return everyDigit.Sum();
        }
    }
}
