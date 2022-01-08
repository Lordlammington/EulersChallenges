using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Challenge1
{
    public class ShanesNaturalNumbers : IEnumerable<int>
    {
        private class ShanesNaturalNumbersEnumerator : IEnumerator<int>
        {
            public ShanesNaturalNumbersEnumerator()
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

            public int Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }
        }
        //how is this being called?
        public IEnumerator<int> GetEnumerator()
        {
            return new ShanesNaturalNumbersEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    /// <summary>
    /// Foo
    /// </summary>

    public class NaturalNumber
    {
        public NaturalNumber(int number)
        {
            this.Number = number;
        }
        public int Number;
    }

    public class NaturalNumbers : IEnumerable
    {
        private NaturalNumber[] _naturalNumbers;

        public NaturalNumbers(NaturalNumber[] nArray)
        {
            _naturalNumbers = new NaturalNumber[nArray.Length];
            for (int i = 0; i < nArray.Length; i++)
            {
                _naturalNumbers[i] = nArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public NaturalNumberEnum GetEnumerator()
        {
            return new NaturalNumberEnum(_naturalNumbers);
        }

        public class NaturalNumberEnum : IEnumerator
        {
            public NaturalNumber[] _NaturalNumbers;
            int position = -1;

            public NaturalNumberEnum(NaturalNumber[] list)
            {
                _NaturalNumbers = list;
            }

            public bool MoveNext()
            {
                position++;
                return true;
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current => Current;

            public NaturalNumber Current
            {
                get
                {
                    try
                    {
                        return _NaturalNumbers[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

    }
}
