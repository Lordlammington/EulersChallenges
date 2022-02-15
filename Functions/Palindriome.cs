using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public static class Palindriome
    {
        public static bool IsPalindrome(long input)
        {
            var originalNum = input;
            var reversedNum = 0;
            while (input != 0)
            {

                var digit = input % 10;
                reversedNum = (int)((reversedNum * 10) + digit);
                input /= 10;
            }

            return originalNum == reversedNum;
        }
    }
}
