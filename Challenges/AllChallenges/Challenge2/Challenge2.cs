using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using ProjectEuler;

namespace Challenges
{
    public class Challenge2 : IRunChallenge
    {
        public int MaxFibbValue { get; set; }   
        public int RunChallenge()
        {
            FibonacciSequence fibonacci = new FibonacciSequence();
            var evensum = fibonacci.TakeWhile(number => number < MaxFibbValue).Sum(Predicate);

            return evensum;
        }

        private int Predicate(int x)
        {
            if (x % 2 == 0)
            {
                return x;
            }

            return 0;
        }
    }

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
                int oldNumber2 = _Number2;
                _Number2 = _Number1 + _Number2;
                _Number1 = oldNumber2;
                return true;
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
