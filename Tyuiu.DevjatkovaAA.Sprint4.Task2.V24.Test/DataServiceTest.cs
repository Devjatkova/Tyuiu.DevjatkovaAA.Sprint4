using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint4.Task2.V24.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 4, 6, 5, 7, 8, 8, 6, 4, 9, 6, 5 };

            int res = ds.Calculate(array);
            int wait = 26;

            Assert.AreEqual(wait, res);
        }
    }
}
