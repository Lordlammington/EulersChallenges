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
    public class Challenge21 : IRunChallenge
    {

        public BigInteger RunChallenge()
        {
            var list = AmicableNumbers.List(10000);

            long total = 0;
            foreach (var numberPair in list)
            {
               total += numberPair.Key + numberPair.Value;
            }

            return total;
        }
    }
}
