using Functions;
using ProjectEuler;
using System;
using System.Numerics;

namespace Challenges
{
    public class Challenge16 : IRunChallenge
    {
        public BigInteger ToThePowerOf;
        public BigInteger RunChallenge()
        {
            return InputNumberAs.ListOfDigitsSummed(Exponents.Solve(2, ToThePowerOf));
        }
    }
}
