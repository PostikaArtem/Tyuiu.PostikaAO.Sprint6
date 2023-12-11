using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.PostikaAO.Sprint6.Task5.V9.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\sralr\source\repos\Tyuiu.PostikaAO.Sprint6\Tyuiu.PostikaAO.Sprint6.Task5.V9\bin\Debug\OutPutDataFileTask5V9.txt";

        private void buttonDone_PAO_Click(object sender, EventArgs e)
        {
            dataGridViewNum_PAO.ColumnCount = 2;
            dataGridViewNum_PAO.Columns[0].Width = 20;
            dataGridViewNum_PAO.Columns[1].Width = 50;

            this.chartDiag_PAO.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_PAO.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_PAO.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for(int i=0; i < numsMass.Length; i++)
            {
                
                dataGridViewNum_PAO.Rows.Add(Convert.ToString(i+1), Convert.ToString(numsMass[i]));
                chartDiag_PAO.Series[0].Points.AddXY(i, numsMass[i]);
            }
            
        }

        private void dataGridViewNum_PAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpenFile_PAO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_PAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-1 Постика Артем Олегович", "Сообщение");
        }

        private void buttonDone_PAO_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PAO.BackColor = Color.Blue;
        }

        private void buttonDone_PAO_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PAO.BackColor = Color.Red;
        }

        private void buttonDone_PAO_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PAO.BackColor = Color.Green;
        }

        private void buttonOpenFile_PAO_MouseDown(object sender, MouseEventArgs e)
        {
            buttonOpenFile_PAO.BackColor = Color.Blue;
        }

        private void buttonOpenFile_PAO_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFile_PAO.BackColor = Color.Red;
        }

        private void buttonOpenFile_PAO_MouseLeave(object sender, EventArgs e)
        {
            buttonOpenFile_PAO.BackColor = Color.Orange;
        }

        private void buttonHelp_PAO_MouseDown(object sender, MouseEventArgs e)
        {
            buttonHelp_PAO.BackColor = Color.Blue;
        }

        private void buttonHelp_PAO_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp_PAO.BackColor = Color.Red;
        }

        private void buttonHelp_PAO_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_PAO.BackColor = Color.Yellow;
        }

        
        
    }
}
