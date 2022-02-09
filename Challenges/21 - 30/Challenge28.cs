using System.Linq;
using ProjectEuler;
using ProjectEuler.Enumerators;

namespace Challenges
{
    public class Challenge28 : IRunChallenge
    {
        public long sizeofGrid;
        public long RunChallenge()
        {
            return SpiralNumberCorners.Sequence().TakeWhile(x => x <= sizeofGrid * sizeofGrid).Sum();
        }
    }
}