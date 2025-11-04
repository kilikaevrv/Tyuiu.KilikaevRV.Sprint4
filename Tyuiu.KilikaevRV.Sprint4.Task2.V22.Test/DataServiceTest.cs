using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint4.Task2.V22.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1 };
            int result = ds.Calculate(array);
            int wait = 1 * 3 * 5 * 1 * 3 * 5 * 1; // = 225
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateNoOdd()
        {
            DataService ds = new DataService();
            int[] array = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            int result = ds.Calculate(array);
            Assert.AreEqual(0, result);
        }
    }
}