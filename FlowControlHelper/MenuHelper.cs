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
            // visar bara menyn, vad användaren kan välja etc
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to flow control program");
            Console.WriteLine("Here's some functions you can pick");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0: Quit program");
            Console.WriteLine("1: Get price cost just for you");
            Console.WriteLine("2: Get total price for you and your friends");
            Console.WriteLine("3: Enter anything that repeat ten times");
            Console.WriteLine("4: Get a word from a sentence entered by you");
        }

        // funktioner här nedan
        public static void PrintPriceByAge()
        {
            // printa baserat på ålder, till exempel 80kr = ungdom pris

            uint price = GetPriceByAge();
            if (price == 80)
            {
                Console.WriteLine($"Teenage price: {price} kr");
            }
            else if (price == 90)
            {
                Console.WriteLine($"Pensioner price: {price} kr");
            }
            else if (price == 0)
            {
                Console.WriteLine($"Free price: {price} kr");
            }
            else
            {
                Console.WriteLine($"Standard price: {price} kr");
            }
        }
        public static uint GetPriceByAge()
        {
            // returnera pris baserat på ålder

            uint age = Util.AskForInt("Enter age: ");
            if ( age < 20 )
            {
                if ( age <= 5 )
                    return 0;
                return 80;
            }
            else if ( age <= 64 )
            {
                return 120;
            }
            else
            {
                if (age >= 100)
                    return 0;
                return 90;
            }
        }

        public static uint GetTotalPrice()
        {
            // returnerar totalpris baserat på ett antal personer som vill gå på bio

            uint number = Util.AskForInt("How many are you?: ");
            uint total_price = 0;

            for (int i = 0; i < number; i++)
            {
                // återanvända getpriceage funktion
                total_price += GetPriceByAge();
            }

            return total_price;
        }

        public static void RepeatTenTimes()
        {
            // användaren kan skriva vad som helst här, och programmet skriver ut variabeln tio gånger via for loop
            string input = Util.AskForString("Enter anything: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {input} ");
            }
        }

        public static string GetThirdWord()
        {
            // användaren skriver en mening (minst 3 ord lång) och programmet hämtar ut det tredje ordet
            // nu har jag implementerat något extra, programmet frågar efter ett nummer för att hämta ut ett ord från meningen

            string input;

            do
            {
                input = Util.AskForString("Enter a sentence that contains at least three words: ");
                int number_of_words = Util.GetWordsCount(input);

                if (number_of_words < 3)
                {
                    Console.WriteLine("Sentence has less than three words, please try again.");
                }
                else
                {
                    string[] words = input.Split(' ');
                    uint pickWord;
                    // här är det nåt extra, istället för att hårdkoda och hämta 3e ord
                    do
                    {
                        pickWord = Util.AskForInt($"Pick a number to pick word from the sentence (index starts at 0), must be max {number_of_words - 1}: ");
                        if (pickWord < number_of_words)
                            break;
                    } while (true);

                    // return words[2]; // Return the third word (index 2)
                    return words[pickWord];
                }
            } while (true);
        }

    }
}
