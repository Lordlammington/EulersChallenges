using System.Linq;
using Xunit.Sdk;

namespace Functions
{
    public class AmicableNumbers
    {
        public static bool IsAmicable(long A, long B)
        {
            var SumOfAllMultiplesOfA = Divisors.List(A).SkipLast(1).Sum();
            var SumOfAllMultiplesOfB = Divisors.List(B).SkipLast(1).Sum();

            if (SumOfAllMultiplesOfA == B && SumOfAllMultiplesOfB == A)
            {
                return true;
            }

            return false;
        }
    }
}