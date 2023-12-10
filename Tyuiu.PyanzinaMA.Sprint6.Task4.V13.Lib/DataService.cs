﻿using System;
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
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + 1 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = 3 * x + 2 - ((2 * x - x) / (Math.Cos(x) + 1)) ;
                    y = Math.Round(y, 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}