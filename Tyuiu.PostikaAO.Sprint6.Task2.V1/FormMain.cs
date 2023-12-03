using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PostikaAO.Sprint6.Task2.V1.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task2.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBoxStartStep_PAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_PAO_Click(object sender, EventArgs e)
        {

            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_PAO.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_PAO.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_PAO.Titles.Add("График функции sin(x)");
                this.chartFunction_PAO.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PAO.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_PAO.Rows.Add(Convert.ToInt32(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction_PAO.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }

        private void buttonHelp_PAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Постика Артем Олегович", "Сообщение");
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

        private void chartFunction_PAO_Click(object sender, EventArgs e)
        {

        }
    }
}
