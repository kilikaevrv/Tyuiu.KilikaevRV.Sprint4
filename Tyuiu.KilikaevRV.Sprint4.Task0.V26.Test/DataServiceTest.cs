using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint4.Task0.V26.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            int wait = 41; // 9+3+7+1+5+5+3+1+7 = 41
            int result = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumOddArrElWithOnlyEvenNumbers()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 6, 8, 0 };

            int wait = 0; // Все числа четные
            int result = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumOddArrElWithOnlyOddNumbers()
        {
            DataService ds = new DataService();

            int[] array = { 1, 3, 5, 7, 9 };

            int wait = 25; // 1+3+5+7+9 = 25
            int result = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumOddArrElEmptyArray()
        {
            DataService ds = new DataService();

            int[] array = new int[0];

            int wait = 0; // Пустой массив
            int result = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, result);
        }
    }
}