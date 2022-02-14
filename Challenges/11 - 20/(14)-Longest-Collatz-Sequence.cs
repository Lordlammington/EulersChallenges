using Enumerators;
using ProjectEuler;
using System.Linq;
using System.Numerics;

namespace Challenges
{
    public class Challenge14 : IRunChallenge
    {
        public BigInteger InputNumber;
        public BigInteger RunChallenge()
        {
            var longestSeries = new BigInteger();
            var responsibleNumber = new BigInteger();

            foreach (var number in NaturalNumberCountdown.Sequence(InputNumber))
            {
                var currentSeries = CollatzSeries.Sequence(number).Count();
                if (longestSeries >= currentSeries) continue;

                longestSeries = currentSeries;
                responsibleNumber = number;
            }
            return responsibleNumber;
        }
    }
}