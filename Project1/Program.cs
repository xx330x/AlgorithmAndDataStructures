using System;

namespace _1
{
    internal class Program
    {
        int min = 0;
        int max = 0;
        int totalAttempts = 0;
        int gamesCount = 0;
        int left = 0;
        int right = 100;
        int counter = 0;
        int number = 0;

        public int? GetNumber()
        {
            int attempt = 0;
            for (int i = 0; i < 3; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out attempt)
                     || attempt > right
                     || attempt < left)
                    Console.WriteLine($"Input number from [{left};{right}]");
                else break;
                if (i == 2)
                {
                    Console.WriteLine("You are stupid");
                    return null;
                }
            }
            return attempt;
        }

        public bool CompareNumber(int attempt, int number)
        {
            if (number < attempt)
                Console.WriteLine("Your number is greater");
            else if (number > attempt)
                Console.WriteLine("Your number is less");
            else
            {
                Console.WriteLine("You won!!!");
                return true;
            }

        }

        public void PlayGame(int number)
        {
            while (true)
            {
                Console.WriteLine($"Input number from [{left};{right}]");

                int? result = GetNumber();
                if (result = null)
                    return;

                int attempt = result.Value;
                bool flag = CompareNumber(attempt, number);
                if (flag == true)
                    break;
            }
        }


                // Запускает игру
        static void Main(string[] args)
        {
                    // Переменные

            Random rnd = new Random();
            char answer = 'Y';

            // Основной цикл игры
            do
            { 
                int number = rnd.Next(Program.left, Program.right);
                int attempt = 5;
                int counter = 0;
                Program.PlayGame(number);
                answer.ConvertToChar(Console.Read());
            } while (answer == 'Y');
        }
    }
}