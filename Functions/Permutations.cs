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
        // ReSharper disable once InconsistentNaming
        public static List<char[]> _Combinations = new();

		public static void Start(string input)
		{
			char[] arr = input.ToCharArray();
			Permute(arr, 0, arr.Length - 1);
		}


		private static void Swap(ref char a, ref char b)
		{
			(a, b) = (b, a);
        }


		private static void Permute(char[] elements, int recursionDepth, int maxDepth)
		{
			

			if (recursionDepth == maxDepth)
			{

				var temp = elements.ToArray();
				_Combinations.Add(temp);
				return;
			}

			for (int i = recursionDepth; i <= maxDepth; i++)
			{
				Swap(ref elements[recursionDepth], ref elements[i]);
				Permute(elements, recursionDepth + 1, maxDepth);
				// backtrack
				Swap(ref elements[recursionDepth], ref elements[i]);
			}
		}


		public static BigInteger SumOfAll(string input)
        {
            return Factorial.FactorialOf(input.Length);
        }



    }

}

