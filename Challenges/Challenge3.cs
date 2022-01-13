using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Challenge3
{
    public class Challenge7 : IRunChallenge
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public long InputNumber { get; set; }
        public int RunChallenge()
        {
            PrimeNumbers primes = new PrimeNumbers();

            List<int> allPrimesBelowInput = primes.TakeWhile(number => number < 10000).ToList();
            List<int> LadderPrimes = new List<int>();


            restart:
            foreach (int prime in allPrimesBelowInput)
            {
                
                if (InputNumber % prime == 0)
                {
                    if (InputNumber == prime)
                    {
                        LadderPrimes.Add(prime);
                        break;
                    }
                    
                    InputNumber = InputNumber / prime;
                    LadderPrimes.Add(prime);
                    goto restart;
                }
            }
            return LadderPrimes.Max();
        }
    }
}
