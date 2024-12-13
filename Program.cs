namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "1990";
            string userInput;

            int triesCount = 3;

            for (int i = 0; i < triesCount; i++)
            {
                Console.Write("Ваши попытки - "+ (triesCount -i) + "\nВведите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Доступ разрешен!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Неверный пароль!");
                }
            }
        }
    }
}
