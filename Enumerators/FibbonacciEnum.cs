using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler;

namespace Enumerators
{
    public class FibonacciSequence : IEnumerable<int>
    {
        private class FibonacciEnumerator : IEnumerator<int>
        {
            private int _Number1;
            private int _Number2;

            public FibonacciEnumerator()    
            {
                Reset();
            }

            public bool MoveNext()
            {
                if (_Number1 + _Number2 < int.MaxValue)
                {
                    int oldNumber2 = _Number2;
                    _Number2 = _Number1 + _Number2;
                    _Number1 = oldNumber2;
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

            public void Reset()
            {
                _Number1 = 0;
                _Number2 = 1;
            }

            public int Current => _Number2;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new FibonacciEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
