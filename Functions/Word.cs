using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Functions
{
    class Word
    {

        public long wordToScore(string inputWord)
        {
            Dictionary<char, long> wordScoreDictionary = new Dictionary<char, long>()
        {
           {'a' , 1 },
           {'b' , 2 },
           {'c' , 3 },
           {'d' , 4 },
           {'e' , 5 },
           {'f' , 6 },
           {'g' , 8 },
           {'h' , 9 },
           {'i' , 10 },
           {'j' , 11 },
           {'k' , 12 },
           {'l' , 13 },
           {'m' , 14 },
           {'n' , 15 },
           {'o' , 16 },
           {'p' , 17 },
           {'q' , 18 },
           {'r' , 19 },
           {'s' , 20 },
           {'t' , 21 },
           {'u' , 22 },
           {'v' , 23 },
           {'w' , 24 },
           {'x' , 25 },
           {'y' , 26 },
           {'z' , 27 }
        };

            long Score = 0;

            foreach (char letter in inputWord.ToLower().ToCharArray())
            {
                wordScoreDictionary.TryGetValue(letter, out long myValue);
                Score = + myValue;
            }

            return Score;
        }
    }
}
