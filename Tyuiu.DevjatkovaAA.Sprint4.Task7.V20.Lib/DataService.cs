using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mat = new int[n, m];
            int index = 0;

            for (int i=0; i<n; i++)
            {
                for (int j= 0; j<m; j++)
                {
                    mat[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                    //mat[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i,j] % 2 == 0)
                    {
                        count *= mat[i, j];
                    }
                }
            }
            return count;
        }
    }
}
