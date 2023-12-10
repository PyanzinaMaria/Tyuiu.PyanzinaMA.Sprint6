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
            int start = 0;
            int stop = 1;
            int len = 2;
            double[] array;
            array = new double[len];

            array[0] = 2;
            array[1] = -0.74;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(array, res);
        }
    }
}
