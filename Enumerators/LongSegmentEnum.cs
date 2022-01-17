using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerators
{
    public class LongReverseSegment : IEnumerable<long>
    {
        private long _Countdown;

        public LongReverseSegment(long countdown)
        {
            if (countdown < 1)
            {
                throw new ArgumentException(nameof(countdown));
            }

            this._Countdown = countdown;
        }

        private class LongReverseSegmentEnumerator : IEnumerator<long>
        {
            private long _Countdown;

            public LongReverseSegmentEnumerator(long countdown)
            {
                if (countdown < 1)
                {
                    throw new ArgumentException(nameof(countdown));
                }

                this._Countdown = countdown;
                Reset();
            }

            public bool MoveNext()
            {
                Current--;

                return Current > 0;
            }

            public void Reset()
            {
                Current = _Countdown;
            }

            public long Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }
        }
        public IEnumerator<long> GetEnumerator()
        {
            return new LongReverseSegmentEnumerator(_Countdown);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    } 
}
