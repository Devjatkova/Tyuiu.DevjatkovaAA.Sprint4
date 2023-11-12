﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint4.Task3.V23.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { 7, 5, 5, 6, 7 },
                                         { 8, 7, 8, 4, 3 },
                                         { 5, 6, 7, 6, 4 },
                                         { 4, 2, 3, 6, 4 },
                                         { 5, 2, 4, 2, 3 } };
            int res = ds.Calculate(mas);
            int wait = 14;

            Assert.AreEqual(wait, res);
        }
    }
}