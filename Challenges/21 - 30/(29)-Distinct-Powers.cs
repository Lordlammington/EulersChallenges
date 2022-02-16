using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Functions;
using ProjectEuler;

namespace Challenges21To30
{
    public class Challenge29 : IRunChallenge
    {

        public long Ceiling;

        public BigInteger RunChallenge()
        {
            var allProducts = new List<BigInteger>();


            for (var a = 2; a <= Ceiling; a++)
            {
                for (var b = 2; b <= Ceiling; b++)
                {
                   
                    allProducts.Add(Exponents.Solve(a,b));

                }
            }

            var distinct = allProducts.Distinct();




            return distinct.Count();
        }


    }
}