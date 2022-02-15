using System.Linq;
using System.Numerics;
using ProjectEuler;
using Enumerators;

namespace Challenges
{
    public class Challenge5 : IRunChallenge
    {
        public int[] Divisors; 
        public BigInteger RunChallenge()
        {
            return NaturalNumbers.Sequence().First(DivIntoArrayRemainderCheck);
        }

        public bool DivIntoArrayRemainderCheck(BigInteger input)
        {
            return Divisors.All(divisor => input % divisor == 0);
        }
    }
    
}
