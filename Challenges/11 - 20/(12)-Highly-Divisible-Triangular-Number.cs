using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using ProjectEuler;
using Enumerators;
using Functions;

namespace Challenges
{
    public class Challenge12 : IRunChallenge
    {
        public long _UpToDivisors;

        public long RunChallenge()
        {
            //TriangleNumbers.Sequence()
            
            //var thing = TriangleNumbers.Sequence().Take(7);

            //return thing.TakeUntil(7).Where(x => _UpToDivisors % x == 0).Where(PrimeNumbers.CheckForPrime).First();

            //I SWEAR i could do this with a take while but for now i'm doing to with a nested loop
            //int counter = 0;

            //long foo = 1;

            //triangleNumbers.TakeWhile(x => x * x <= _UpToDivisors).Where(y => DivisibleBy(number, y)).GetNaturalNumbersRay().TakeWhile(x => x * x <= number).Where(y => DivisibleBy(number, y))


            return 0;


                //while (NumberOfDivisors(foo) < _UpToDivisors)
                //{
                //    foo = TriangleNumbers.Sequence().ElementAt(counter);
                //    counter++;
                //}

                //return TriangleNumbers.Sequence().ElementAt(counter);
         

           
        }
    }
}