using System.Linq;
using System.Numerics;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    public class Challenge28 : IRunChallenge
    {
        public long sizeofGrid;
        public BigInteger RunChallenge()
        {
            return SpiralNumberCorners.Sequence().TakeWhile(x => x <= sizeofGrid * sizeofGrid).Sum();
        }
    }
}