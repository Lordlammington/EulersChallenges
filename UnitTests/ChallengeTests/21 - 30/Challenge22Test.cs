﻿using Challenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges21To30
{
    [TestFixture]
    class Challenge22Test
    {
        [Test]
        public void NameScores()
        {
            Challenge22 challenge = new Challenge22();
            Assert.AreEqual(871198282, challenge.RunChallenge());
        }
    }
}