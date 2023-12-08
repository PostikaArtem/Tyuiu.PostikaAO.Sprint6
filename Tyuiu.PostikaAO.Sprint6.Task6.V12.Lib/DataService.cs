using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PostikaAO.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string[] temp;
                while ((line = reader.ReadLine()) != null)
                {
                    temp = line.Split(' ');
                    foreach (string item in temp)
                    {
                        if (item.ToLower().Contains('w')) resStr += item + Environment.NewLine;
                    }

                }
            }
            return resStr;
        }
    }
}
