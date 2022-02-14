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
            List<BigInteger> allProducts = new List<BigInteger>();
            //Just 2 loops?
            for (int a = 2; a <= Ceiling; a++)
            {
                for (int b = 2; b <= Ceiling; b++)
                {
                   
                    allProducts.Add((BigInteger)Math.Pow(a,b));

                }
            }
            //0.1 + 0.2 = 0.30000000000004?
            BigInteger foo;


            var distinct = allProducts.Distinct();




            return distinct.Count();
        }


    }
}