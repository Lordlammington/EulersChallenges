﻿using ProjectEuler;
using System.Linq;
using Enumerators;
using Functions;

namespace Challenges
{
    public class Challenge17 : IRunChallenge
    {
        public long _CalculateInclusive;

        public long RunChallenge()
        {
            NaturalNumbers naturalNumbers = new NaturalNumbers();
            long CharLengthOfAllNumbers = 0;
            foreach (long number in naturalNumbers.Take((int)_CalculateInclusive))
            {
                CharLengthOfAllNumbers = CharLengthOfAllNumbers + NumberToWord.NumberOfCharacters(number);
            }

            return CharLengthOfAllNumbers;
        }
    }
}
