using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KilikaevRV.Sprint4.Task4.V7.Lib
{
    public class DataService : ISprint4Task4V7
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Проверяем, является ли элемент нечетным
                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}