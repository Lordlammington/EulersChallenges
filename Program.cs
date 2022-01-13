using System;
using ProjectEuler;


namespace Challenges
{
    class Program 
    {
        static void Main(string[] args)
        {
            new Client().Main();
            Challenge8 challenge = new Challenge8();
            challenge._NumberOfAdjacents = 13;
            Console.WriteLine("The Result Is: {0}", challenge.RunChallenge());
        }
    }
}