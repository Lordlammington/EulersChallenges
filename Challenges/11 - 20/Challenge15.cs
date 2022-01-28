using Enumerators;
using Functions;
using ProjectEuler;
using System.Linq;

namespace Challenges
{
    public class Challenge15 : IRunChallenge
    {
        public long _SizeOfSquare;
        public long RunChallenge()
        {
            return Binomial.Solve(_SizeOfSquare, _SizeOfSquare); ;
        }
    }
}
