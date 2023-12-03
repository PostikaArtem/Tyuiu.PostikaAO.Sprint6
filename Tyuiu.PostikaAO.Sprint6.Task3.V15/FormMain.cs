using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Tyuiu.PostikaAO.Sprint6.Task3.V15.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task3.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 33, 28, 31, 19, 4 }, { 1, 32, -3, -17, -12 }, { 24, -19, 26, 31, -3 }, { 30, -16, 29, 28, 8 }, { 30, 5, 11, 7, 32 } };
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_PAO_Click(object sender, EventArgs e)
        {
            int[,] mtrx2 = ds.Calculate(mtrx);

            int rows = mtrx2.GetUpperBound(0) + 1;
            int columns = mtrx2.Length / rows;

            dataGridViewResuld_PAO.ColumnCount = columns;
            dataGridViewResuld_PAO.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResuld_PAO.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResuld_PAO.Rows[i].Cells[j].Value = Convert.ToString(mtrx2[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_PAO.ColumnCount = columns;
            dataGridViewMatrix_PAO.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_PAO.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_PAO.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }



        }

        private void buttonHelp_PAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-1 Постика Артем Олегович", "Сообщение");
        }

        private void dataGridViewResuld_PAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
