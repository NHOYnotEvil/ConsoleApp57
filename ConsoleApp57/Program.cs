namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "secret";
            string userInput;

            Console.WriteLine("Когда посох - сильнее меча?");

            for (int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите парорль:");
                userInput = Console.ReadLine();

                if (password == userInput)
                {
                    Console.WriteLine("Ответ прост - когда он в умелых руках.");
                    break;
                }
                else
                {
                    Console.WriteLine("У вас осталось - " + (tryCount - i - 1) + " попыток.");
                }
            }
        }
    }
}