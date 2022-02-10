using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
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
        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public int _FirstNumber;
        public int _SecondNumber;
        public int _PallindromicNumber;
        public long RunChallenge()
        {
            // Multiply 2, 3 digit numbers
            // Check if its a palindrome 
            // If it is Add to a list
            List<int> pallindromicNumbers = new();

            foreach (int number in ThreeDigitProducts.Sequence().AsEnumerable())
            {
                if (IsPalindrome(number))
                {
                    pallindromicNumbers.Add(number);
                }
            }

            return pallindromicNumbers.Max();
        }

        public bool IsPalindrome(int input)
        {
            int originalNum = input;
            int reversedNum = 0;
            while (input != 0)
            {   
                
                int digit = input % 10;
                reversedNum = (reversedNum * 10) + digit;
                input /= 10;
            }

            if (originalNum == reversedNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
