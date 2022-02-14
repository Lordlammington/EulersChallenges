using ProjectEuler;
using System.Linq;
using System.Numerics;
using Enumerators;
using Functions;

namespace Challenges
{
    public class Challenge17 : IRunChallenge
    {
        public BigInteger CalculateInclusive;

        public BigInteger RunChallenge()
        {
            return NaturalNumbers.Sequence().Take((int)CalculateInclusive).Cast<long>().Sum(NumberToWord.NumberOfCharacters);
        }
    }
}
