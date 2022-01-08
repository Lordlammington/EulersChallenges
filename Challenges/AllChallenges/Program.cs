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
            IRunChallenge challenge = new Challenge3();
            Console.WriteLine("The Result Is: {0}", challenge.RunChallenge());
        }
    }
}