using ProjectEuler;
using System.Collections.Generic;
using System.Linq;
using Functions;

namespace Challenges
{
    public class Challenge18 : IRunChallenge
    {   
        public long RunChallenge()
        {
            List<long[]> triangle = new List<long[]>
            {
                new long[] {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23},
                new long[] {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
                new long[] {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
                new long[] {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
                new long[] {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
                new long[] {41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
                new long[] {41, 41, 26, 56, 83, 40, 80, 70, 33},
                new long[] {99, 65, 04, 28, 06, 16, 70, 92},
                new long[] {88, 02, 77, 73, 07, 63, 67},
                new long[] {19, 01, 23, 75, 03, 34},
                new long[] {20, 04, 82, 47, 65},
                new long[] {18, 35, 87, 10},
                new long[] {17, 47, 82},
                new long[] {95, 64},
                new long[] {75}
                
            };

            for (int x = 0; x < triangle.Count; x++)
            {
                for (int i = 0; i <= triangle[x].Length - 2; i++)
                {
                    var bds = triangle[x].Skip(i).Take(2);
                    triangle[x+1][i] += ReturnThe.BiggerNumber(bds.First(), bds.Last());
                }
            }

            return 10;
        }
    }
}
