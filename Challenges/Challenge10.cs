﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10001st prime number?
    /// </summary>
    public class Challenge10 : IRunChallenge
    {
        public long _CountUpTo;
        public long RunChallenge()
        {
            PrimeNumbers prime = new PrimeNumbers();
            return prime.TakeWhile(x => x < (int)_CountUpTo).Sum();
        }
    }
}
