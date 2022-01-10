using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Challenge3
{
    public class Challenge3 : IRunChallenge
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
    public class PrimeNumbers : IEnumerable<int>
    {
        private class PrimeEnumerator : IEnumerator<int>
        {
            private int _Prime;
            private int _PossiblePrime;

            public PrimeEnumerator()
            {
                Reset();
            }
            public bool MoveNext()
            {
              
                do
                {
                  _PossiblePrime++;
                } while (CheckForPrime() == false);


                _Prime = _PossiblePrime;
               

                return true;
            }

            public bool CheckForPrime()
            {
                
                if (_PossiblePrime <= 1) return false;
                if (_PossiblePrime == 2) return true;
                if (_PossiblePrime % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(_PossiblePrime));

                for (int i = 3; i <= boundary; i += 2)
                    if (_PossiblePrime % i == 0)
                        return false;

                return true;
            }

            public void Reset()
            {
                _PossiblePrime = 1;
            }

            public int Current => _Prime;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new PrimeEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
