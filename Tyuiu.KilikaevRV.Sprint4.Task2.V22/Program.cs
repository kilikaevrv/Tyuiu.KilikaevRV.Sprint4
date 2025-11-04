using System;
using Tyuiu.KilikaevRV.Sprint4.Task2.V22.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int len = 13;
            int[] array = new int[len];

            Console.WriteLine("Массив:");
            for (int i = 0; i < len; i++)
            {
                array[i] = rnd.Next(1, 7); // от 1 до 6 включительно
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine("Произведение нечётных элементов = " + result);
            Console.ReadKey();
        }
    }
}