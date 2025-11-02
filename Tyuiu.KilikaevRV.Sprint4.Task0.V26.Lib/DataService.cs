using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KilikaevRV.Sprint4.Task0.V26.Lib
{
    public class DataService : ISprint4Task0V26
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
            {
                // Проверяем, является ли число нечетным
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}                