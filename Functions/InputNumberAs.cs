using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public static class InputNumberAs
    {
        public static List<long> ListOfDigits(BigInteger inputNumber)
        {
            List<long> everyDigit = new List<long>();

            while (!inputNumber.IsZero)
            {

                var digit = inputNumber % 10;
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

                var digit = inputNumber % 10;
                everyDigit.Add((long)digit);
                inputNumber /= 10;
            }

            return everyDigit.Sum();
        }

        public static long CountOfDigits(BigInteger inputNumber)
        {
            long numberDigits = 0;

            while (!inputNumber.IsZero)
            {
                inputNumber /= 10;
                numberDigits++;
            }

            return numberDigits;
        }
    }
}
