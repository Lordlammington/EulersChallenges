using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;

namespace Enumerators
{
    public class TriangleNumbers : IEnumerable<long>
    {
        private class TriangleNumberEnumerator : IEnumerator<long>
        {
            private long _triangleNumber;
            private long _countUpTo;

            public TriangleNumberEnumerator()
            {
                Reset();
            }

            public bool MoveNext()
            {
                NaturalNumbers naturalNumbers = new NaturalNumbers();
                _triangleNumber = naturalNumbers.Take((int)_countUpTo + 1).Sum();
                _countUpTo++;
                return true;
            }

            public void Reset()
            {
            _countUpTo = 0;
            }

            public long Current => _triangleNumber;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
        public IEnumerator<long> GetEnumerator()
        {
            return new TriangleNumberEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}