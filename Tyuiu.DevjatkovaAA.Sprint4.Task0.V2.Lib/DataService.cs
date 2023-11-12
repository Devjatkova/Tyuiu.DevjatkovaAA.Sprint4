using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task0.V2.Lib
{
    public class DataService : ISprint4Task0V2
    {
        public int GetSumOddArrEl(int[] array)
        {
            int S = 0;

            for (int i = 0; i <= array.Length - 1; i++) 
            {
                if (array[i] % 2 != 0)
                {
                    S += array[i];
                }
            }
            return S;
        }
    }
}
