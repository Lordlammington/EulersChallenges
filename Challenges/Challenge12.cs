using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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

            bool hasFoundDivisors = false;
            int counter = 0;
            long trinum;
            do
            {
                trinum = triangleNumbers.ElementAt(counter);
                int numberOfDivisorsfound = 0;


                for (int i = 1; i < trinum; i++)
                {
                    if (trinum % i == 0)
                    {
                        numberOfDivisorsfound++;
                    }
                }

                if (numberOfDivisorsfound > _UpToDivisors)
                {
                    hasFoundDivisors = true;
                }
                else
                {
                    counter++;
                }

            } while (!hasFoundDivisors);
            
           

            return trinum;
        }
    }
}