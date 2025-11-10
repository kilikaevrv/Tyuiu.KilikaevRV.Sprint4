using System;
using Tyuiu.KilikaevRV.Sprint4.Task7.V7.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кликаев Р. В. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка строковых данных                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Кликаев Р. В. | АСОиУб-23-3                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Преобразовать строку '31415926' в матрицу 4x2 и подсчитать нечетные.   *");
            Console.WriteLine("***************************************************************************");

            string value = "31415926";
            int n = 4, m = 2;

            Console.WriteLine($"Строка: {value}");
            Console.WriteLine($"Матрица: {n}x{m}");

            DataService ds = new DataService();
            int result = ds.Calculate(n, m, value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Нечетных чисел: {result}");

            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int num = int.Parse(value[i * m + j].ToString());
                    Console.Write(num + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}