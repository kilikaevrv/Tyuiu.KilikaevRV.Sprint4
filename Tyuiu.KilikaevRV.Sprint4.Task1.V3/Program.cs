using System;
using Tyuiu.KilkaevRV.Sprint4.Task1.V3.Lib;

namespace Tyuiu.KilkaevRV.Sprint4.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Килькаев Р. В. | АСОиУб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Килькаев Ренат Валерьевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9. Подсчитать произведение *");
            Console.WriteLine("* чётных элементов массива.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Используем заданные значения для тестирования
            int[] array = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };

            Console.WriteLine("Массив: 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine($"Произведение чётных элементов массива = {result}");

            // Проверка вычислений
            Console.WriteLine();
            Console.WriteLine("Проверка вычислений:");
            Console.WriteLine("Чётные элементы: 4, 8, 8, 6, 2");
            Console.WriteLine("4 × 8 = 32");
            Console.WriteLine("32 × 8 = 256");
            Console.WriteLine("256 × 6 = 1536");
            Console.WriteLine("1536 × 2 = 3072");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ТЕСТИРОВАНИЕ:                                                           *");
            Console.WriteLine("* Ожидаемый результат: 3072                                               *");
            Console.WriteLine($"* Фактический результат: {result}                                           *");
            Console.WriteLine("* Тест " + (result == 3072 ? "ПРОЙДЕН" : "НЕ ПРОЙДЕН") + "                                                  *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}