using System;
using ProjectEuler;
using ProjectEuler.Challenge3;

namespace Challenges
{
    class Program 
    {
        static void Main(string[] args)
        {
            new Client().Main();
            Challenge6 challenge = new Challenge6();
            challenge._SquareDifference = 100;
            Console.WriteLine("The Result Is: {0}", challenge.RunChallenge());
        }
    }
}