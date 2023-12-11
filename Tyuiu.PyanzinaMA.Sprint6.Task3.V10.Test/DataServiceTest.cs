using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint6.Task3.V10.Lib;

namespace Tyuiu.PyanzinaMA.Sprint6.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { -17, 6, -19, 6, -13 },
                                           { -19, 3, 12, -11, 19 },
                                           { -20, 11, 9, 19, -19 },
                                           { -20, 10, -9, 17, 9 },
                                           { -4, 9, -8, 13, -8 } };

            int[,] waitarray = new int[5, 5] { { -17, 6, -19, 6, -13 },
                                           { -19, 3, 12, -11, 19 },
                                           { -20, 11, 9, 19, -19 },
                                           { -20, 10, -9, 17, 9 },
                                           { 0, 9, 0, 13, 0 } };

            int[,] resarray = ds.Calculate(array);
            CollectionAssert.AreEqual(waitarray, resarray);
        }
    }
}
