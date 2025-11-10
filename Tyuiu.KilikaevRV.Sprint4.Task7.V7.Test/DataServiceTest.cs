using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint4.Task7.V7.Lib;

namespace Tyuiu.KilikaevRV.Sprint4.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int result = ds.Calculate(4, 2, "31415926");
            Assert.AreEqual(5, result);
        }
    }
}