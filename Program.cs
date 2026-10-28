using System;
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Питання до користувача
            int n = 0;
            while (true)
            {
                Console.Write("Введіть натуральне число n: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Помилка! Введіть коректне натуральне число.");
            }

            //Рівень А
            int pairCount = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{i} * {n / i} = {n}");
                    pairCount++;
                }
            }
            Console.WriteLine($"Кількість таких пар: {pairCount}");

            int root = (int)Math.Sqrt(n);
            if (root * root == n)
            {
                Console.WriteLine($"Число {n} є повним квадратом.");
            }
            else
            {
                Console.WriteLine($"Число {n} не є повним квадратом.");
            }

            //Рівень Б
            if (n >= 3 && n <= 20)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        char symbol = ' ';
                        if (i == j || i + j == n - 1)
                        {
                            symbol = '#';
                        }
                        else if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                        {
                            symbol = '*';
                        }
                        else
                        {
                            symbol = ' ';
                        }
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Для побудови квадрата (Рівень Б) значення n має бути в межах від 3 до 20.");
            }
        }
    }
}