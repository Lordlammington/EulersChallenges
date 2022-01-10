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
