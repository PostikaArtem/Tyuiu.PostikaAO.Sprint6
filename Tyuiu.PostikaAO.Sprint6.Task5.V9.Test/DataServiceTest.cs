using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.PostikaAO.Sprint6.Task5.V9.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\Users\sralr\source\repos\Tyuiu.PostikaAO.Sprint6\Tyuiu.PostikaAO.Sprint6.Task5.V9\bin\Debug\OutPutDataFileTask5V9.txt";;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
