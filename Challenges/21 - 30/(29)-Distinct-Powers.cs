using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
                   
                    allProducts.Add((BigInteger)Math.Pow(a,b));

                }
            }

            var distinct = allProducts.Distinct();




            return distinct.Count();
        }


    }
}