using System;

namespace Functions
{
    public static class NumberToWord
    {
        private static readonly string[] Units = 
            { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

        private static readonly string[] Tens =
            {"", "" , "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "Hundred"};


        public static string AsAFullWord(long number)
        {


            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + AsAFullWord(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
               words += AsAFullWord(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += AsAFullWord(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += AsAFullWord(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";



                if (number < 20)
                    words += Units[number];
                else
                {
                    words += Tens[number / 10];
                    if ((number % 10) > 0)
                        words += " " + Units[number % 10];
                }
            }

            return words;
        }

        public static long NumberOfCharacters(long number)
        {
            return AsAFullWord(number).Replace(" ", "").Length;
        }
    }
}
