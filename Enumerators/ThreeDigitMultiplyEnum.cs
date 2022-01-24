using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators
{
    public class ThreeDigitProducts
    {
        public static IEnumerable<long> Sequence()
        {
            long number1 = 100;
            long number2 = 100;
            bool hasReachedLimit = false;
            do
            {
                yield return number1 * number2;

                number1++;

                if (number1 == 1000)
                {
                    number2++;
                    number1 = 100;
                }

                if (number2 == 1000 )
                {
                    hasReachedLimit = true;
                }

            } while (!hasReachedLimit);
        }
    }
}
