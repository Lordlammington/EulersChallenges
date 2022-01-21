using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using ProjectEuler;
using Enumerators;

namespace ProjectEuler.Challenges
{
    public class Challenge12 : IRunChallenge
    {
        public long _UpToDivisors;

        public long RunChallenge()
        {
            TriangleNumbers triangleNumbers = new TriangleNumbers();
            //var thing = triangleNumbers.Take(7);

            //return thing.TakeUntil(7).Where(x => _UpToDivisors % x == 0).Where(PrimeNumbers.CheckForPrime).First();

            //I SWEAR i could do this with a take while but for now i'm doing to with a nested loop
            //int counter = 0;

            //long foo = 1;

            //triangleNumbers.TakeWhile(x => x * x <= _UpToDivisors).Where(y => DivisibleBy(number, y)).GetNaturalNumbersRay().TakeWhile(x => x * x <= number).Where(y => DivisibleBy(number, y))





        //    while (NumberOfDivisors(foo) < _UpToDivisors)
        //    {
        //        foo = triangleNumbers.ElementAt(counter);
        //        counter++;
        //    }

        //    return triangleNumbers.ElementAt(counter);
        //}


        //public bool DivisbleBy(long inputnumber1, long number2)
        //{
        //    if (number2 % inputnumber1 == 0) 
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }


        //}
        //public long NumberOfDivisors(long input)
        //{
        //    int numberOfDivisors = 0;
        //    int sqrt = (int) Math.Sqrt(input);

        //    for (int i = 1; i <= sqrt; i++)
        //    {
        //        if (input % i == 0)
        //        {
        //            numberOfDivisors += 2;
        //        }
        //    }

        //    if (sqrt * sqrt == input)
        //    {
        //        numberOfDivisors--;
        //    }

            return 10;
        }
    }
}