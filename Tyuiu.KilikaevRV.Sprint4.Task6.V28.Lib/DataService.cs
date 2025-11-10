using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KilikaevRV.Sprint4.Task6.V28.Lib
{
    public class DataService : ISprint4Task6V28
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, element => element.Length == 4);
        }
    }
}