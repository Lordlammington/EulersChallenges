using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators
{
    public class SpiralNumberCorners
    {
        public static IEnumerable<long> Sequence()
        {
            long num = 1;
            long addiator = 2;
            do
            {
                for (int i = 0; i <= 3; i++)
                {
                    yield return num;
                    num += addiator;
                }
                addiator += 2;
            } while (true);
        }
    }
}
