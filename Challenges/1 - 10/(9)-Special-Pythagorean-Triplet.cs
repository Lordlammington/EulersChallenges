using System.Collections.Generic;
using System.Numerics;
using Functions;
using ProjectEuler;

namespace Challenges
{
    public class Challenge9 : IRunChallenge
    {
        public BigInteger NumberToFind;

        public BigInteger RunChallenge()
        {
            for (BigInteger c = 1; c < NumberToFind; c++)
            {
                for (BigInteger b = 1; b < c-1; b++)
                {
                    for (BigInteger a = 1; a < b-1; a++)
                    {

                        if (Exponents.Square(a) + Exponents.Square(b) == Exponents.Square(c) && a + b + c == NumberToFind)
                        {
                            return a * b * c;
                        }
                    }
                }
            }

            return 0;
        }
    }
}