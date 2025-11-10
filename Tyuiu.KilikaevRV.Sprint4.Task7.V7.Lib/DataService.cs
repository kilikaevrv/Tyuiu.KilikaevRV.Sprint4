using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KilikaevRV.Sprint4.Task7.V7.Lib
{
    public class DataService : ISprint4Task7V7
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                int num = int.Parse(value[i].ToString());
                if (num % 2 != 0) count++;
            }
            return count;
        }
    }
}