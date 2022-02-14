using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Enumerators;
using Functions;

namespace Challenges
{
    public class Challenge19 : IRunChallenge
    {
        public DateTime _StartDate;
        public DateTime _EndDate;
        public BigInteger RunChallenge()
        {

            long sundayCounter = 0;
            for (var dayCounter = _StartDate; dayCounter < _EndDate; dayCounter = dayCounter.AddMonths(1))
            {
                if (dayCounter.DayOfWeek == DayOfWeek.Sunday && dayCounter.Day == 1)
                {
                    sundayCounter++;
                }
            }

            return sundayCounter;
        }
    }
}
