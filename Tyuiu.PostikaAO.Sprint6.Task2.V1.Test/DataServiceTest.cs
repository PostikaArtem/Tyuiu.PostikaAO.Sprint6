using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PostikaAO.Sprint6.Task2.V1.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -1;
            int stopValue = 1;

            int len = stopValue - startValue + 1;

            double[] valieWaitArray;
            valieWaitArray = new double[len];

            valieWaitArray[0] = 4.33;
            valieWaitArray[1] = 1;
            valieWaitArray[2] = 0;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valieWaitArray, res);

        }
    }
}
