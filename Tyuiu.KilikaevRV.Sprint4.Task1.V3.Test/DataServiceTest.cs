using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilkaevRV.Sprint4.Task1.V3.Lib;

namespace Tyuiu.KilkaevRV.Sprint4.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };

            int result = ds.Calculate(array);
            int wait = 3072; // 4 × 8 × 8 × 6 × 2 = 3072

            Assert.AreEqual(wait, result);
        }
    }
}