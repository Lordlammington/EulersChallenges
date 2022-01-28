using System.Threading.Tasks.Dataflow;

namespace Functions
{
    public static class ReturnThe
    {
        public static long BiggerNumber(long a, long b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static long SmallerNumber(long a, long b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}