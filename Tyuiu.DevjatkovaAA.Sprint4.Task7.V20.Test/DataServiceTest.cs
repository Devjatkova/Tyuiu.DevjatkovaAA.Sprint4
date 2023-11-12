using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint4.Task7.V20.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            int[,] matrix = new int[n, m];
            string value = "357951248632587";

            int res = ds.Calculate(n, m, value);
            int wait = 6144;

            Assert.AreEqual(wait, res);
        }
    }
}
