using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint4.Task0.V2.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VAlidGetSumOddArrEl()
        {
            DataService ds = new DataService(); 

            int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetSumOddArrEl(numsArray);
            int numsWaitArray = 44;

            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
