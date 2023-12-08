using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PostikaAO.Sprint6.Task7.V13.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n','\r');
            string[] lines = fileData.Split(new char[] { '\r' },StringSplitOptions.RemoveEmptyEntries);

            int rows=lines.Length;
            int colums = lines[0].Split(';').Length;

            int[,] result = new int[rows, colums];

            for(int r=0; r < rows; r++)
            {
                string[] temp = lines[r].Split(';');
                for(int c = 0; c < colums; c++)
                {
                    result[r, c] = Convert.ToInt32(temp[c]);
                }
            }

            for(int l=0;l<rows; l++)
            {
                if (result[l, 5] % 2 == 0 && result[l,5]>0)
                {
                    result[l, 5] = 111;
                }
            }
            return result;

        }
    }
}
