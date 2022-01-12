using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler 
{ 
    public class ThreeDigitMultiplyProducts : IEnumerable<int>
    {
        private class ThreeDigitMultiplyEnumerator : IEnumerator<int>
        {
            private int _Number1;
            private int _Number2;
            private int _Product;

            public ThreeDigitMultiplyEnumerator()
            {
                Reset();
            }

            public bool MoveNext()
            {
                _Product = _Number1 * _Number2;
                if (_Number1 > 999 && _Number2 > 999)
                {
                    return false;
                }
                else
                {
                    if (_Number1 <= 999)
                    {
                        _Number1++;

                    }
                    else
                    {
                        _Number2++;
                        _Number1 = _Number2 + 1;
                    }
                    return true;
                }
            }

            public void Reset()
            {
                _Number1 = 100;
                _Number2 = 100;
            }

            public int Current => _Product;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new ThreeDigitMultiplyEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
