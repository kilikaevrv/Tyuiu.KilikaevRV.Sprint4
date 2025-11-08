using System;
using Tyuiu.KilikaevRV.Sprint4.Task4.V7.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кликаев Р. В. | АСОиУб-23-3";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Кликаев Р. В. | АСОиУб-23-3                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти сумму нечетных элементов массива 5x5.                            *");
            Console.WriteLine("* Значения вводятся с клавиатуры в диапазоне от 3 до 6.                  *");
            Console.WriteLine("***************************************************************************");
            
            int[,] matrix = new int[5, 5];
            
            Console.WriteLine("Введите элементы массива 5x5 (числа от 3 до 6):");
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\nВведенный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            DataService ds = new DataService();
            int result = ds.Calculate(matrix);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма нечетных элементов = " + result);
            
            Console.ReadKey();
        }
    }
}