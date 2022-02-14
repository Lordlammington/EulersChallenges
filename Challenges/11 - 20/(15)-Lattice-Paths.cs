using System.Numerics;
using Functions;
using ProjectEuler;

namespace Challenges
{
    public class Challenge15 : IRunChallenge
    {
        public long SizeOfSquare;
        public BigInteger RunChallenge()
        {
            return Binomial.Solve(SizeOfSquare, SizeOfSquare);
        }
    }
}
