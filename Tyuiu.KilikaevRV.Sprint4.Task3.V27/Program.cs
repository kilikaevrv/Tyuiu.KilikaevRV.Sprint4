using System;
using Tyuiu.KilikaevRV.Sprint4.Task3.V27.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кликаев Р. В. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Кликаев Роман Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 3 до 7.              *");
            Console.WriteLine("* Подсчитайте количество четных элементов во всем массиве.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = {
                {4, 3, 5, 5, 3},
                {6, 7, 4, 4, 3},
                {3, 3, 7, 3, 6},
                {3, 4, 3, 7, 7},
                {3, 5, 6, 3, 6}
            };

            Console.WriteLine("Исходный массив 5x5:");
            Console.WriteLine();

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine($"Количество четных элементов в массиве = {result}");

            Console.WriteLine();
            Console.WriteLine("Детальный анализ четных элементов:");
            Console.WriteLine("----------------------------------");

            int evenCount = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string status = (array[i, j] % 2 == 0) ? "ЧЕТНЫЙ" : "нечетный";
                    if (array[i, j] % 2 == 0)
                    {
                        evenCount++;
                        Console.WriteLine($"array[{i},{j}] = {array[i, j]} - {status} ✓");
                    }
                    else
                    {
                        Console.WriteLine($"array[{i},{j}] = {array[i, j]} - {status}");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Итого четных элементов: {evenCount}");

            Console.ReadKey();
        }
    }
}