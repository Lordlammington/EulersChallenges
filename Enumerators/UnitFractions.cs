using System;
using System.Collections.Generic;
using System.Numerics;

namespace Enumerators
{
    public class UnitFractions
    {
        public static IEnumerable<BigInteger> Sequence()
        {
            long numerator = 1;
            long denominator = 2;

            do
            {
                BigInteger result = numerator / denominator;

                yield return result;
                denominator++;

            } while (true);
        }

        public static (long, long) LongestRecurringCycle(int ceiling)
        {

            long sequenceLength = 0;
            long sequenceNumber = 0;

            for (int i = ceiling; i > 1; i--)
            {
                if (sequenceLength >= i)
                {
                    break;
                }

                int[] foundRemainders = new int[i];
                int value = 1;
                int position = 0;

                while (foundRemainders[value] == 0 && value != 0)
                {
                    foundRemainders[value] = position;
                    value *= 10;
                    value %= i;
                    position++;
                }

                if (position - foundRemainders[value] > sequenceLength)
                {
                    sequenceNumber = i;
                    sequenceLength = position - foundRemainders[value];
                }
            }

            return (sequenceLength, sequenceNumber);
        }
    }
}