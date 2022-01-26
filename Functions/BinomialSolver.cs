using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace Functions
{
    public static class Binomial
    {
        public static long Solve(long n, long k)
        {
            // need to do the initial calculation
            //  ( n + k )
            //  (   n   )  

            long topBinomialNumber = n + k;
            long bottomBinomialNumber = n;


            //Then do the solving to find the point in pascals triangle
            // result =  n! / k! * (n - k)! 
            BigInteger result = Factorial.FactorialOf(topBinomialNumber) / ( Factorial.FactorialOf(bottomBinomialNumber) * Factorial.FactorialOf(topBinomialNumber - bottomBinomialNumber) );



            return (long)result;
        }


    }
}
