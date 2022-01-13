﻿using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// </summary>
    public class Challenge7 : IRunChallenge
    {

        public long RunChallenge()
        {
            PrimeNumbers primes = new PrimeNumbers();

            return primes.Skip(10000).First();
        }
    }
}
