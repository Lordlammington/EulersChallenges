using System.Linq;
using System.Numerics;
using Functions;
using ProjectEuler;
using Enumerators;


namespace Challenges
{
    public class Challenge4 : IRunChallenge
    {
        public BigInteger RunChallenge()
        {
            return AllProducts.ThreeDigitProducts()
                    .AsEnumerable()
                    .Where(x => Palindriome.IsPalindrome(x))
                    .ToList()
                    .Max(); 
        }
    }
}
