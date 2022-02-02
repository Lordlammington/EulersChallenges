using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace Functions
{
    public class Permutations
    {
        //Character array?
        public static List<long> SequenceOfAll(string input)
        {
            List<long> sequence = new List<long>();
            
            foreach (var character in input)
            {
                sequence.Add((long)char.GetNumericValue(character)); 
            }

            //Defined the boundaries of the Permutations
            List<long> smallestCombination = new List<long>(sequence.OrderBy(num => num));
            List<long> largestCombination = new List<long>(sequence.OrderByDescending(num => num));
            List<long> currentCombination = new List<long>();

            do
            {
                
                //Here, do the permutations





            } while (currentCombination != largestCombination);


            //Total number of Permutations is digits.length!


            //The following algorithm generates the next permutation lexicographically after a given permutation. It changes the given permutation in-place.

            //   Find the largest index k such that a[k] < a[k + 1].If no such index exists, the permutation is the last permutation.



            //   Find the largest index l greater than k such that a[k] < a[l].
            //   Swap the value of a[k] with that of a[l].
            //   Reverse the sequence from a[k + 1] up to and including the final element a[n].


            // 0 1 2 3 4 5 6 7 8 9 
            //How do i get the next smallest number?
            // ...
            // 9 8 7 6 5 4 3 2 1 0



            //Sort the Characters
            //012
            //
            //012   021   102   120   201   210

            //foreach (char foo in sequence)
            {

            }

            //for (int i = 1; i < sequence.Length; i++)
            {
                //take first entry, and swap it for each entry in list
                //(sequence[0], sequence[i]) = (sequence[i], sequence[0]);
              //  allPermutations.Add(sequence);
            }

            return sequence;
        }

        public static BigInteger SumOfAll(string input)
        {
            return Factorial.FactorialOf(input.Length);
        }
    }
}

