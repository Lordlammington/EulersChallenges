using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class Challenge6 : IRunChallenge
    {
        public int _SquareDifference;
        public int RunChallenge()
        {
            List<int> squares = new List<int>();
            int remainingNumtoAdd = _SquareDifference;
            do
            {
                squares.Add(remainingNumtoAdd);
                remainingNumtoAdd--;

            } while (remainingNumtoAdd > 0);

            int sumOftheSquares = squares.Sum() * squares.Sum();

            int squareOfTheSum = 0;

            foreach (int entry in squares)
            {
                squareOfTheSum += entry * entry;
            }

            //int[] naturalNumbers = 
            return sumOftheSquares - squareOfTheSum;
        }
    }
}
