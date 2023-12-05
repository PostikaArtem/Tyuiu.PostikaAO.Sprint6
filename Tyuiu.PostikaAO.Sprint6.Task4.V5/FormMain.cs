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
using Tyuiu.PostikaAO.Sprint6.Task4.V5.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBoxStop_PAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_PAO_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_PAO.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " успешно сохранен! \nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelStart_PAO_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_PAO_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_PAO.Text);
                int stopValue = Convert.ToInt32(textBoxStop_PAO.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_PAO.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PAO.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_PAO.Text = "";

                chartFunction_PAO.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_PAO.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxResult_PAO.AppendText(valueArray[i] + Environment.NewLine);
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
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-1 Постика Артем Олегович", "Сообщение");
        }

        private void buttonDone_PAO_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            buttonDone_PAO.BackColor = Color.Chartreuse;
        }

        private void buttonSave_PAO_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSave_PAO.BackColor = Color.Blue;
        }

        private void buttonSave_PAO_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_PAO.BackColor = Color.Red;
        }

        private void buttonSave_PAO_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_PAO.BackColor = Color.Gray;
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
