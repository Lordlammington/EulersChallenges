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
            Challenge3 challenge = new Challenge3();
            challenge.InputNumber = 600851475143;
            Console.WriteLine("The Result Is: {0}", challenge.RunChallenge());
        }
    }
}