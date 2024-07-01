using System;
using System.Collections.Generic;

namespace DinamicArrayAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSum = "sum";
            const string CommandExit = "exit";

            List<int> numbers = new List<int>();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Исходный массив:");

                foreach (int number in numbers)
                    Console.Write(number + " ");

                Console.WriteLine();

                Console.WriteLine("Введите число и оно добавится в массив.\n" +
                $"Введите {CommandSum}, чтобы вывести сумму всех чисел в массиве.\n" +
                $"Введите {CommandExit}, чтобы выйти из программы.");
                string userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {
                    case CommandSum:
                        CalculateTheAmount(ref numbers, userInput);
                        break;

                    case CommandExit:
                        isRunning = false;
                        break;

                    default:
                        ReadNumber(ref numbers, userInput);
                        break;
                }
            }

            Console.WriteLine("Вы вышли из программы.");
        }

        private static void CalculateTheAmount(ref List<int> numbers, string userInput)
        {
            int sum = 0;

            foreach (int number in numbers)
                sum += number;

            Console.WriteLine($"Сумма всех чисел массива равна {sum}");
        }

        private static void ReadNumber(ref List<int> numbers, string userInput)
        {
            int number;

            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
                numbers.Add(number);
            else
                Console.WriteLine($"{userInput} - не целочисленное число.");
        }
    }
}
