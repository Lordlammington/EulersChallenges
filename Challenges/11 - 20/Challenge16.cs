﻿using Functions;
using ProjectEuler;
using System;
using System.Numerics;

namespace Challenges
{
    public class Challenge16 : IRunChallenge
    {
        public long _ToThePowerOf;
        public long RunChallenge()
        {
            return InputNumberAs.ListOfDigitsSummed((BigInteger)Math.Pow(2, _ToThePowerOf));
        }
    }
}
