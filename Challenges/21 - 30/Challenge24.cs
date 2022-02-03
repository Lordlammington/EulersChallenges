using ProjectEuler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Functions;
using Functions;

namespace Challenges
{
    public class Challenge24 : IRunChallenge
    {
        public long RunChallenge()
        {
            string str = "0123456789";
            Permutations.Start(str);

            var ordered = Permutations._Combinations
                .OrderByDescending(s => s.Length);

            var skipped = ordered.Skip(999999).First();
                


            long total = 0;
            foreach (var digit in skipped)
            {
                total = (total + (long)char.GetNumericValue(digit)) * 10;
            }

            //2783915460

            //2785960341


            return total / 10;
        }
    }
}