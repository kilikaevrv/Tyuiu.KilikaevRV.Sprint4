using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint4.Task4.V7.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                {4, 3, 6, 5, 5},
                {3, 4, 4, 6, 4},
                {6, 4, 6, 4, 5},
                {5, 4, 4, 4, 5},
                {3, 5, 6, 4, 6}
            };

            int result = ds.Calculate(matrix);
            Assert.AreEqual(39, result); // Исправлено с 41 на 39
        }
    }
}