﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using ProjectEuler;
using System.Runtime.InteropServices.ComTypes;
using System.Text;


namespace Challenges
{
    public class Challenge4 : IRunChallenge
    {
        public int _FirstNumber;
        public int _SecondNumber;
        public int _PallindromicNumber;
        public int RunChallenge()
        {
            // Multiply 2, 3 digit numbers
            // Check if its a palindrome 
            // If it is Add to a list
            ThreeDigitMultiplyProducts multiplyProducts = new ThreeDigitMultiplyProducts();
            List<int> pallindromicNumbers = new List<int>();

            foreach (int number in multiplyProducts.AsEnumerable())
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