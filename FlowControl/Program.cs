using FlowControlHelper;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // main program, det är här programmet startar
            // flag håller programmet i en loop tills användaren trycker 0
            // input lagrar användarens val från menyn
            // price används för att skriva ut den totala priset beroende på vilken funktion som anropas

            bool flag = true;
            string input;
            uint price;

            do
            {

                MenuHelper.DisplayMenu();
                input = Util.AskForString("Choose option: ");

                switch(input)
                {
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Shutting down this program...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(0);
                        break;
                    case "1":
                        MenuHelper.PrintPriceByAge();
                        break;
                    case "2":
                        price = MenuHelper.GetTotalPrice();
                        Console.WriteLine($"Total price is {price} kr");
                        break;
                    case "3":
                        MenuHelper.RepeatTenTimes();
                        break;
                    case "4":
                        string word = MenuHelper.GetThirdWord();
                        Console.WriteLine($"Third word is: {word}");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option, please try again");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.WriteLine(); // new line bara för att få print snyggt
            } while (flag);
        }
    }
}
