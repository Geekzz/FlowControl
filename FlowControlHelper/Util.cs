namespace FlowControlHelper
{
    public class Util
    {
        public static string AskForString(string prompt)
        {
            // denna funktion frågar efter en sträng från användaren
            // och validerar att den inte är null eller tom (nullOrEmpty)

            string input;
            bool flag = true;

            do
            {

                Console.Write($"{prompt}");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Empty input, please type input for {prompt.ToLower()}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    flag = false;
                }
            }while(flag);

            return input;
        }
        public static uint AskForInt(string prompt)
        {
            // denna funktion frågar efter en uint (positivt heltal) från användaren
            // och validerar genom uint.TryParse för att säkerställa att det är ett giltigt positivt heltal

            do
            {
                string input = AskForString(prompt);
                if (uint.TryParse(input, out uint result))
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Please enter a valid {prompt.ToLower()}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while (true);
        } 

        public static int GetWordsCount(string sentence)
        {
            // returnerar antalet ord i en mening

            return sentence.Split(' ').Length;
        }
    }
}
