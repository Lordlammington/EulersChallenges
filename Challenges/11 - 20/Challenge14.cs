using Enumerators;
using ProjectEuler;
using System.Linq;

namespace Challenges
{
    public class Challenge14 : IRunChallenge
    {
        public long _InputNumber;
        public long RunChallenge()
        {
            long LongestSeries = 0;
            long responsibleNumber = 0;
            foreach (var number in NaturalNumberCountdown.Sequence(_InputNumber))
            {
                long CurrentSeries = CollatzSeries.Sequence(number).Count();
                if (LongestSeries < CurrentSeries)
                {
                    LongestSeries = CurrentSeries;
                    responsibleNumber = number;
                }
            }
            return responsibleNumber;
        }
    }
}