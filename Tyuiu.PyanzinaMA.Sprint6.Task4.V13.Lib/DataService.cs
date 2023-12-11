using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyanzinaMA.Sprint6.Task4.V13.Lib
{
    public class DataService : ISprint6Task4V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int l = stopValue - startValue + 1;
            double[] num = new double[l];
            double m; int r = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((Math.Cos(i) + 1) == 0) m = 0;
                else m = Math.Round(3 * i + 2 - i / (Math.Cos(i) + 1), 2);
                num[r] = m;
                r++;
            }
            return num;
        }
    }
}
