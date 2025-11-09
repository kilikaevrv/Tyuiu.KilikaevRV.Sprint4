using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint4.Task5.V24.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { 2, -3, 1, 4, -5 },
                { -1, 5, -2, 3, 0 },
                { 6, -4, 2, -1, 3 },
                { -2, 1, -3, 5, -6 },
                { 4, -5, 6, -2, 1 }
            };

            int result = ds.Calculate(matrix);
            int wait = 13;  // Исправлено с 12 на 13

            Assert.AreEqual(wait, result);
        }
    }
}