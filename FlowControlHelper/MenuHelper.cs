using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlHelper
{
    public static class MenuHelper
    {
        public static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to flow control program");
            Console.WriteLine("Here's some functions you can pick");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0: Quit this program");
            Console.WriteLine("1: Get price cost just for you");
            Console.WriteLine("2: Get total price for you and your friends");
            Console.WriteLine("3: Enter anything that repeat ten times");
            Console.WriteLine("4: Get the third word from a sentence entered by you");
        }

        public static void PrintPriceByAge()
        {
            uint price = GetPriceByAge();
            if (price == 80)
            {
                Console.WriteLine($"Teenage price: {price}");
            }
            else if (price == 90)
            {
                Console.WriteLine($"Pensioner price: {price}");
            }
            else
            {
                Console.WriteLine($"Standard price: {price}");
            }
        }
        public static uint GetPriceByAge()
        {
            uint age = Util.AskForInt("Enter age: ");
            if ( age < 20 )
            {
                return 80;
            }
            else
            {
                if ( age <= 64 )
                {
                    return 120;
                }
                else
                {
                    return 90;
                }
            }
        }

        public static uint GetTotalPrice()
        {
            uint number = Util.AskForInt("How many are you?: ");
            uint total_price = 0;

            for (int i = 0; i < number; i++)
            {
                // reuse GetPriceByAge function
                total_price += GetPriceByAge();
            }

            return total_price;
        }

        public static void RepeatTenTimes()
        {
            string input = Util.AskForString("Enter anything: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {input} ");
            }
        }

        public static string GetThirdWord()
        {
            string input;

            do
            {
                input = Util.AskForString("Enter a sentence that contains at least three words: ");

                if (Util.GetWordsCount(input) < 3)
                {
                    Console.WriteLine("Sentence has less than three words, please try again.");
                }
                else
                {
                    string[] words = input.Split(' ');
                    return words[2]; // Return the third word (index 2)
                }
            } while (true);
        }

    }
}
