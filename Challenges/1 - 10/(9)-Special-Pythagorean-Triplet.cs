using System.Collections.Generic;
using System.Numerics;
using Functions;
using ProjectEuler;

namespace Challenges
{
    public class Challenge9 : IRunChallenge
    {
        public BigInteger Ceiling, NumberToFind;

        public BigInteger RunChallenge()
        {

            List<BigInteger> productList = new();

            for (BigInteger c = 1; c < Ceiling; c++)
            {
                for (BigInteger b = 1; b < c-1; b++)
                {
                    for (BigInteger a = 1; a < b-1; a++)
                    {
                        productList.Add(Exponents.Square(a)+ Exponents.Square(b) + Exponents.Square(c));
                    }
                }
            }
            return productList.Find(x => x == NumberToFind);
        }
    }
}