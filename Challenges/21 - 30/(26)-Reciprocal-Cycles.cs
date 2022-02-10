using System;
using System.Collections.Generic;
using System.Linq;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    public class Challenge26 : IRunChallenge
    {
        public long RunChallenge()
        {
            return UnitFractions.LongestRecurringCycle(1000).Item2;
        }
    }
}