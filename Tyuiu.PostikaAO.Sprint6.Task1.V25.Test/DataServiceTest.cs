using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PostikaAO.Sprint6.Task1.V25.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
           
            DataService ds = new DataService();

            int startValue = -1;
            int stopValue = 1;

            int len = stopValue - startValue + 1;

            double[] valieWaitArray;
            valieWaitArray = new double[len];

            valieWaitArray[0] = 2.88;
            valieWaitArray[1] = 0.75;
            valieWaitArray[2] = -4.47;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valieWaitArray, res);

        }
    }
}
