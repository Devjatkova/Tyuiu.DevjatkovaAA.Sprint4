using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint4.Task6.V2.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var array = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            
            string[] res = ds.Calculate(array);
            string[] wait = new string[] { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };
            
            CollectionAssert.AreEqual(wait, res); 
        }
    }
}
