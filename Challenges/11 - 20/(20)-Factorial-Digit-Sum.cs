using ProjectEuler;
using Functions;

namespace Challenges
{
    public class Challenge20 : IRunChallenge
    {
        public long _FactorialDigits;
        public long RunChallenge()
        {
            return InputNumberAs.ListOfDigitsSummed(Factorial.FactorialOf(_FactorialDigits)); 
        }
    }
}
