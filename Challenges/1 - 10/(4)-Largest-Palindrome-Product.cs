using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Threading.Tasks;
using ProjectEuler;
using Enumerators;
using System.Runtime.InteropServices.ComTypes;
using System.Text;


namespace Challenges
{
    public class Challenge4 : IRunChallenge
    {

        public BigInteger RunChallenge()
        {
            return AllProducts.ThreeDigitProducts
                    .Sequence()
                    .AsEnumerable()
                    .Where(IsPalindrome)
                    .ToList()
                    .Max(); ;
        }


        public static bool IsPalindrome(long input)
        {
            var originalNum = input;
            var reversedNum = 0;
            while (input != 0)
            {   
                
                var digit = input % 10;
                reversedNum = (int) ((reversedNum * 10) + digit);
                input /= 10;
            }

            return originalNum == reversedNum;
        }
    }
}
