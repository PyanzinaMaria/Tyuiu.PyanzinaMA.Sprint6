using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyanzinaMA.Sprint6.Task0.V7.Lib
{
    public class DataService : ISprint6Task0V7
    {
        public double Calculate(int x)
        {
            double res = x / 2;
            return Math.Round(res, 3);
        }
    }
}
