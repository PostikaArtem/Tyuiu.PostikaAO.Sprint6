﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PostikaAO.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
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
                y = (2 * Math.Sin(x) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2;
                valueArray[count] = Math.Round(y, 2);
                count++;
            }
            return valueArray;
        }
    }
}
