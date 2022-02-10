using System.Linq;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10001st prime number?
    /// </summary>
   
    public class Challenge7 : IRunChallenge
    {
        public long RunChallenge()
        {
            return PrimeNumbers.Sequence().Skip(10000).First();
        }
    }
}
