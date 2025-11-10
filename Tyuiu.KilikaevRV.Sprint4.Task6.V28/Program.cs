using System;
using Tyuiu.KilikaevRV.Sprint4.Task6.V28.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Килия Р. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Килия Роман Владимирович | АСОиУб-23-3                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Рекa, Озеро, Болото, Океан, Лужа, Море],  *");
            Console.WriteLine("* используя класс Array, выведите элементы массива, длина которых        *");
            Console.WriteLine("* равна 4 символам.                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Рекa", "Озеро", "Болото", "Океан", "Лужа", "Море" };

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string[] result = ds.Calculate(array);

            Console.WriteLine("Элементы массива с длиной 4 символа:");
            Console.WriteLine(string.Join(", ", result));

            Console.ReadKey();
        }
    }
}