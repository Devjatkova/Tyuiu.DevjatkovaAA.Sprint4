using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint4.Task5.V18.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3] { { 3, -4, 6, }, 
                                            { 6, 7, -6, },
                                            { 5, -3, 5, } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 3, 0, 6, },
                            { 6, 7, 0, },
                            { 5, 0, 5, } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
