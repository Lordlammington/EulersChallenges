using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class FilterEnum<T> : IEnumerable<T>
    {
        private IEnumerable<T> _ToBeFiltered;
        private Func<T, bool> _Predicate;

        public FilterEnum(IEnumerable<T> toBeFiltered, Func<T, bool> predicate)
        {
            if (toBeFiltered is null)
            {
                throw new ArgumentNullException(nameof(toBeFiltered));
            }

            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            this._ToBeFiltered = toBeFiltered;
            this._Predicate = predicate;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new FilterEnumerator(_ToBeFiltered.GetEnumerator(), _Predicate);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new FilterEnumerator(_ToBeFiltered.GetEnumerator(), _Predicate);
        }

        private class FilterEnumerator : IEnumerator<T>
        {
            private IEnumerator<T> _Enumerator;
            private Func<T, bool> _Predicate;

            public FilterEnumerator(IEnumerator<T> enumerator, Func<T, bool> predicate)
            {
                if (enumerator is null)
                {
                    throw new ArgumentNullException(nameof(enumerator));
                }

                if (predicate is null)
                {
                    throw new ArgumentNullException(nameof(predicate));
                }

                this._Enumerator = enumerator;
                this._Predicate = predicate;
            }


            public T Current => _Enumerator.Current;

            object IEnumerator.Current => _Enumerator.Current;

            public void Dispose()
            {
                _Enumerator.Dispose();
            }

            public bool MoveNext()
            {
                bool isNext;

                do
                {
                    isNext = _Enumerator.MoveNext();
                } while (isNext && !_Predicate(_Enumerator.Current) );

                return isNext;

            }

            public void Reset()
            {
                _Enumerator.Reset();
            }
        }
    }
}
