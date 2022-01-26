using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Enumerators;

namespace ProjectEuler
{
    /// <summary>
    ///A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,
    ///
    ///    a2 + b2 = c2
    ///         For exampl, 32 + 42 = 9 + 16 = 25 = 52.
    ///
    ///
    ///   There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    ///    Find the product abc.
    /// </summary>
    ///


    public class Challenge9 : IRunChallenge
    {
        public int Number = 1000;

        public long RunChallenge()
        {

            NaturalNumbers naturalNumbers = new NaturalNumbers();

            //make these natural numbers


            var tupleList = new List<(long N, long M)>{};

            var euclidList = new {n = naturalNumbers.Take(Number) , m = naturalNumbers.Take(Number) };

            return 10;


        }

    }
}