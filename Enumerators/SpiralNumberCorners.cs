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

            //Start at 1
            // add 2, 4 times, then add 4, 4 times, then add 6, 4 times

            long num = 1;
            long addiator = 2;
            


            do
            {

                //do this 4 times

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
