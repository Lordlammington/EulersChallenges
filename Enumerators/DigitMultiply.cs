using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators
{

    public class AllProducts
    {
        public static IEnumerable<BigInteger> Sequence(BigInteger primaryBigInteger, BigInteger secondaryBigInteger)
        {
            BigInteger number1 = primaryBigInteger;
            BigInteger number2 = secondaryBigInteger;

            var hasReachedLimit = false;
            do
            {
                yield return number1 * number2;

                number1++;

                if (number1 == primaryBigInteger * 10)
                {
                    number2++;
                    number1 = primaryBigInteger;
                }

                if (number2 == secondaryBigInteger * 10)
                {
                    hasReachedLimit = true;
                }

            } while (!hasReachedLimit);
        }

        public class ThreeDigitProducts
        {
            public static IEnumerable<long> Sequence()
            {
                long number1 = 100;
                long number2 = 100;
                var hasReachedLimit = false;
                do
                {
                    yield return number1 * number2;

                    number1++;

                    if (number1 == 1000)
                    {
                        number2++;
                        number1 = 100;
                    }

                    if (number2 == 1000)
                    {
                        hasReachedLimit = true;
                    }

                } while (!hasReachedLimit);
            }
        }

        public class TwoDigitProducts
        {
            public static IEnumerable<long> Sequence()
            {
                long number1 = 10;
                long number2 = 10;
                bool hasReachedLimit = false;
                do
                {
                    yield return number1 * number2;

                    number1++;

                    if (number1 == 100)
                    {
                        number2++;
                        number1 = 10;
                    }

                    if (number2 == 100)
                    {
                        hasReachedLimit = true;
                    }

                } while (!hasReachedLimit);
            }
        }

        public class OneDigitProducts
        {
            public static IEnumerable<long> Sequence()
            {
                long number1 = 1;
                long number2 = 1;
                bool hasReachedLimit = false;
                do
                {
                    yield return number1 * number2;

                    number1++;

                    if (number1 == 10)
                    {
                        number2++;
                        number1 = 1;
                    }

                    if (number2 == 10)
                    {
                        hasReachedLimit = true;
                    }

                } while (!hasReachedLimit);
            }
        }
    }
}
