using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint4.Task3.V27.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = {
                {4, 3, 5, 5, 3},
                {6, 7, 4, 4, 3},
                {3, 3, 7, 3, 6},
                {3, 4, 3, 7, 7},
                {3, 5, 6, 3, 6}
            };

            int wait = 8; // Исправлено с 9 на 8
            int result = ds.Calculate(array);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithOnlyOddNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                {3, 5, 7},
                {5, 3, 7},
                {7, 3, 5}
            };

            int wait = 0;
            int result = ds.Calculate(array);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithOnlyEvenNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                {4, 6, 8},
                {6, 4, 8},
                {8, 6, 4}
            };

            int wait = 9;
            int result = ds.Calculate(array);

            Assert.AreEqual(wait, result);
        }
    }
}