using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Transactions;

namespace Enumerators
{
    public class CollatzSequence : IEnumerable<long>
    {
        private long _CollatzSeedNumber;
        private long _CurrentSequenceNumber;

        public CollatzSequence(long countdown)
        {
            if (countdown < 2)
            {
                throw new ArgumentException(nameof(countdown));
            }

            this._CollatzSeedNumber = countdown;
        }

        private class CollatzSequenceEnumerator : IEnumerator<long>
        {
            private long _CollatzSeedNumber;
            private long _CurrentSequenceNumber;

            public CollatzSequenceEnumerator(long countdown)
            {
                if (countdown < 2)
                {
                    throw new ArgumentException(nameof(countdown));
                }

                this._CollatzSeedNumber = countdown;

                Reset();
            }

            public bool MoveNext()
            {
                if (_CurrentSequenceNumber == 1)
                {
                    return false;
                }

                if (_CurrentSequenceNumber % 2 == 0)
                {
                    _CurrentSequenceNumber /= 2;
                    return true;
                }
                else
                {
                    _CurrentSequenceNumber = (_CurrentSequenceNumber * 3) + 1;
                    return true;
                }
            }

            public void Reset()
            {
                _CurrentSequenceNumber = _CollatzSeedNumber;
            }

            public long Current { get; private set; }

            object IEnumerator.Current => _CurrentSequenceNumber;

            public void Dispose()
            {

            }
        }
        public IEnumerator<long> GetEnumerator()
        {
            return new CollatzSequenceEnumerator(_CollatzSeedNumber);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
