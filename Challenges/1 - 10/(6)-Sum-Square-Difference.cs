using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Challenge6 : IRunChallenge
    {
        public int SquareDifference;
        public BigInteger RunChallenge()
        {
            List<long> squares = new();

            do
            {
                squares.Add(SquareDifference);
                SquareDifference--;

            } while (SquareDifference > 0);


            return squares.Sum() * squares.Sum() - squares.Sum(entry => entry * entry);
        }
    }
}
