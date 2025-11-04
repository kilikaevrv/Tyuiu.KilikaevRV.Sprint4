namespace Tyuiu.KilikaevRV.Sprint4.Task2.V22.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;

    public class DataService : ISprint4Task2V22
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool foundOdd = false;

            foreach (int num in array)
            {
                if (num % 2 != 0) // проверка на нечётность
                {
                    product *= num;
                    foundOdd = true;
                }
            }

            return foundOdd ? product : 0; // если нечётных нет, вернём 0
        }
    }
