using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyanzinaMA.Sprint6.Task1.V26.Lib
{
    public class DataService : ISprint6Task1V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) - 2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (5 * x + 2.5) / (Math.Sin(x) - 2) + 2;
                    y = Math.Round(y, 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
