using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PostikaAO.Sprint6.Task5.V9.Lib
{
    public class DataService : ISprint6Task5V9
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
           using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];
            
            
            int count = 0;
            double[] result;
            using (StreamReader reader = new StreamReader(path))
            {
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "0")
                    {
                        count++;
                    }
                    
                    
                }
                result = new double[count];

            }
            return result;
        }
    }
}
