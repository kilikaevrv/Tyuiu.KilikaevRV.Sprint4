using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KilkaevRV.Sprint4.Task1.V3.Lib
{
    public class DataService : ISprint4Task1V3
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false;

            foreach (int number in array)
            {
                if (number % 2 == 0) // проверка на чётность
                {
                    product *= number;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0;
        }
    }
}