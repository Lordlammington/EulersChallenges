using ProjectEuler.Challenge3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Challenge7 : IRunChallenge
    {
        public int RunChallenge()
        {
            PrimeNumbers primes = new PrimeNumbers();

            return primes.Take(10001).Last();
        }
    }
}
