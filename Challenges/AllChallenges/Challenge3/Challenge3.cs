using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Challenge3
{
    class Challenge3 : IRunChallenge
    {
        public int InputNumber { get; set; }
        public int RunChallenge()
        {

            //A composite number is a number that is made
            //by multiplying multiple other primes together.


            //What is a prime?
            //Cannot be divided by anything other then itself (and 1)
            //and produce a remainder of 0
            PrimeNumbers primes = new PrimeNumbers();




            var first10Primes = primes.Take(10).Sum();
            var result = 0;
            return result;
        }

        public class PrimeNumbers : IEnumerable<int>
        {
            private class PrimeEnumerator : IEnumerator<int>
            {
                private int _Prime;
                private int _PossiblePrime;
                private int _Divisor;

                public PrimeEnumerator()
                {
                    Reset();
                }


                

                public bool MoveNext()
                {

                    do
                    {
                        if (_PossiblePrime % _Divisor != 0 && _Divisor == 1)
                        {
                            _Prime = _PossiblePrime;
                            _PossiblePrime++;
                            _Divisor = _PossiblePrime - 1;
                        }
                        else
                        {
                            _Divisor--;
                        }
                    } while (_Divisor != 1);
                    return true;
                }

                public bool CheckIsPrime()
                {
                    //16 / 15 - remainder Not 0 False
                    //16 / 2 - remainder 0 False
                    //16 / 1 - remainder 0 True
                    //If the remainder is

                    do
                    {
                        if (_PossiblePrime % _Divisor != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        _Divisor--;
                    } while (_Divisor != 1);
                }

                public void Reset()
                {
                    _PossiblePrime = 2;
                    _Divisor = 1;
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
}
