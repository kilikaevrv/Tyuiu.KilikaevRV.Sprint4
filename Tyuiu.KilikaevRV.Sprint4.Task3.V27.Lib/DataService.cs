using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KilikaevRV.Sprint4.Task3.V27.Lib
{
    public class DataService : ISprint4Task3V27
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Проверяем, является ли элемент четным
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}