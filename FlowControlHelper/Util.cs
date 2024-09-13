namespace FlowControlHelper
{
    public class Util
    {
        public static string AskForString(string prompt)
        {
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
            return sentence.Split(' ').Length;
        }
    }
}
