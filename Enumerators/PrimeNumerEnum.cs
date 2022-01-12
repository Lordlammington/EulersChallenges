using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
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
