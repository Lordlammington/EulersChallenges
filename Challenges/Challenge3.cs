using System;
using System.Linq;
using Enumerators;

namespace ProjectEuler.Challenges
{
    public class Challenge3 : IRunChallenge
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public long InputNumber { get; set; }
        public long RunChallenge()
        {
            LongReverseSegment integerReverse = new LongReverseSegment((long)Math.Ceiling(Math.Sqrt(InputNumber)));

            return integerReverse.Where(x => InputNumber % x == 0).Where(PrimeNumbers.CheckForPrime).First();

        }
    }
}
