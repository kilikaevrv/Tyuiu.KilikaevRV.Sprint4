using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint4.Task6.V28.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Рекa", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            string[] result = ds.Calculate(array);
            string[] wait = { "Рекa", "Лужа", "Море" };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}