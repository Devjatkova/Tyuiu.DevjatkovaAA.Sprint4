using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task1.V30.Lib
{
    public class DataService : ISprint4Task1V30
    {
        public int Calculate(int[] array)
        {
            int P = 1;

            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i] % 2 == 0 )
                {
                    P *= array[i];
                }
            }
            return P;
        }
    }
}
