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
        /// <summary>
        /// The sum of the squares of the first ten natural numbers is 385
        /// The square of the sum of the first ten natural numbers is 3025
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        
        public int _SquareDifference;
        public long RunChallenge()
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

            return sumOftheSquares - squareOfTheSum;
        }
    }
}
