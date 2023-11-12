using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint4.Task1.V30.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7 };
             
            int res = ds.Calculate(array);
            int wait = 13824;

            Assert.AreEqual(wait, res);
        }
    }
}
