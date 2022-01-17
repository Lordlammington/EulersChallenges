using System;
using ProjectEuler;


namespace Challenges
{
    class Program 
    {
        static void Main(string[] args)
        {
            //new Client().Main();
            Challenge5 challenge = new Challenge5();
            challenge._Divisors = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("The Result Is: {0}", challenge.RunChallenge());
        }
    }
}