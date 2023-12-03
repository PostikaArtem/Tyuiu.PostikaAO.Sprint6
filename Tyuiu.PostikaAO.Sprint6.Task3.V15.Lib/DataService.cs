using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PostikaAO.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int[] ler = new int[rows];
            int[,] result = matrix.Clone() as int[,];
            for (int i = 0; i < rows; i++)
            {
                ler[i] = matrix[i, 2];
            }
            Array.Sort(ler);

            for (int i = 0; i < rows; i++) result[i, 2] = ler[i];


            return result;











        }
    }
}
