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
}
