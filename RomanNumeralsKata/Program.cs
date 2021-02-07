using System;

namespace RomanNumeralsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter a number to convert to roman numerals\n");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    running = false;
                }
                else
                {
                    ReadAndConvertToNumeral(input);
                }

            }
        }

        private static void ReadAndConvertToNumeral(string input)
        {
            try
            {
                var numeral = RomanNumeralConverter.convertInt(Convert.ToInt32(input));
                Console.WriteLine("Your Roman numeral is\n\t: " + numeral + "\n goodbye");
            }
            catch (Exception e)
            {
                GoodByeMessage();
            }
        }

        private static void GoodByeMessage()
        {
            Console.WriteLine("Invalid entry. Goodbye");
        }
    }
}
