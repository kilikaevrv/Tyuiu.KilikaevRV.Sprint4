using System;
using Tyuiu.KilikaevRV.Sprint4.Task0.V26.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task0.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кликаев Р. В. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Кликаев Роман Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                     *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9               *");
            Console.WriteLine("* подсчитать сумму нечетных элементов массива.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Исходный массив: {9, 3, 7, 1, 5, 5, 3, 2, 1, 7}                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            Console.WriteLine("Исходный массив:");
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.GetSumOddArrEl(array);

            Console.WriteLine($"Сумма нечетных элементов массива = {result}");

            Console.WriteLine();
            Console.WriteLine("Детальный расчет:");
            Console.WriteLine("-----------------");

            int sum = 0;
            string oddNumbers = "";
            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                    oddNumbers += number + " + ";
                }
            }

            if (oddNumbers.Length > 0)
            {
                oddNumbers = oddNumbers.Remove(oddNumbers.Length - 3); // Убираем последний " + "
                Console.WriteLine($"Нечетные элементы: {oddNumbers} = {result}");
            }
            else
            {
                Console.WriteLine("В массиве нет нечетных элементов");
            }

            Console.WriteLine();
            Console.WriteLine("Все элементы массива:");
            for (int i = 0; i < array.Length; i++)
            {
                string parity = (array[i] % 2 == 0) ? "четный" : "нечетный";
                Console.WriteLine($"Элемент [{i}] = {array[i]} ({parity})");
            }

            Console.ReadKey();
        }
    }
}