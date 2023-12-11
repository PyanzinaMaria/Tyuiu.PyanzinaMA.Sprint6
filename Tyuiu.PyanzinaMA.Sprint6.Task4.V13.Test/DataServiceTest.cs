using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint6.Task4.V13.Lib;

namespace Tyuiu.PyanzinaMA.Sprint6.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int l = stopValue - startValue + 1;
            double[] num = new double[l];
            num[0] = -9.10;
            num[1] = 1.55;
            num[2] = 292.78;
            num[3] = -0.57;
            num[4] = -0.35;
            num[5] = 2.00;
            num[6] = 4.35;
            num[7] = 4.57;
            num[8] = -288.78;
            num[9] = 2.45;
            num[10] = 13.10;
            double[] res = new double[l];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(num, res);
        }
    }
}
