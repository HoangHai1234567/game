using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReadNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number;
            while (true)
            {
                string input = Console.ReadLine();
                bool valid = int.TryParse(input, out int temp);
                if (valid && temp > 0 && temp < 1000)
                {
                    Console.WriteLine("You entered number: " + temp);
                    number = temp;
                    break;
                }
                if (valid && (temp <= 0 || temp >= 1000))
                {
                    Console.WriteLine("out of ability");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                }
            }

            //array for ones and tens
            string[] ones =
            {
                    "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                    "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                    "seventeen", "eighteen", "nineteen"
            };

            string[] tens =
            {
                    "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
            };

            string word = "";

            //handle condition
            if (number >= 100)
            {
                word += ones[number / 100] + " hundred ";
                number %= 100;
            }
            switch (number)
            {
                case < 20:
                    word += ones[number];
                    break;

                default:
                    word +=tens[number / 10] + " " + ones[number % 10];
                    break;
            }

            Console.WriteLine(word);

        }
    }
}