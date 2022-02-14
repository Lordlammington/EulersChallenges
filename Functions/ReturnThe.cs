using System.Threading.Tasks.Dataflow;

namespace Functions
{
    public static class ReturnThe
    {
        public static long BiggerNumber(long a, long b)
        {
            return a > b ? a : b;
        }

        public static long SmallerNumber(long a, long b)
        {
            return a > b ? b : a;
        }
    }
}