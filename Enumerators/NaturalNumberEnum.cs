using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;

namespace ProjectEuler
{
    public class NaturalNumbers : IEnumerable<long>
    {
        private class NaturalNumbersEnumerator : IEnumerator<long>
        {
            public NaturalNumbersEnumerator()
            {
                Current = 0;
            }

            public bool MoveNext()
            {
                Current++;

                return true;
            }

            public void Reset()
            {
                Current = 1;
            }

            public long Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }
        }
        public IEnumerator<long> GetEnumerator()
        {
            return new NaturalNumbersEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    
}
