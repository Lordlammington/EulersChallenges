using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerators;
using Functions;

namespace Challenges
{
    public class Challenge20 : IRunChallenge
    {
        public long _FactorialDigits;
        public long RunChallenge()
        {
            return InputNumberAs.ListOfDigitsSummed(Factorial.FactorialOf(_FactorialDigits)); 
        }
    }
}
