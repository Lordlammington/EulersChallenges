using System;
using System.Collections.Generic;
using System.Linq;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    /// <summary>
    ///A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    ///
    ///    a2 + b2 = c2
    ///    For example, 32 + 42 = 9 + 16 = 25 = 52.
    ///
    ///
    ///   There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    ///   Find the product abc.
    ///   
    ///  U N F I N I S H E D
    /// </summary>

    public class Challenge9 : IRunChallenge
    {
        public int Number = 1000;

        public long RunChallenge()
        {
            var tupleList = new List<(long N, long M)>{};

            var euclidList = new {n = NaturalNumbers.Sequence().Take(Number) , m = NaturalNumbers.Sequence().Take(Number) };

            return 0;


        }

    }
}