using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyanzinaMA.Sprint6.Task3.V10.Lib
{
    public class DataService : ISprint6Task3V10
    {
        public int[,] Calculate(int[,] matrix)
        {
            int len = matrix.GetLength(0);
            int[] new_array = new int[len];


            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                new_array[j] = matrix[j, 0];
            }
            Array.Sort(new_array);

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[j, 0] = new_array[j];
            }
            return matrix;
        }
    }
}
