using System.Numerics;
using ProjectEuler;
using Functions;

namespace Challenges
{
    public class Challenge20 : IRunChallenge
    {
        public long _FactorialDigits;
        public BigInteger RunChallenge()
        {
            return InputNumberAs.ListOfDigitsSummed(Factorial.FactorialOf(_FactorialDigits)); 
        }
    }
}
