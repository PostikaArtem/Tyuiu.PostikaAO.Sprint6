using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PostikaAO.Sprint6.Task1.V25.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task1.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBoxStart_PAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelStart_PAO_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_PAO_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_PAO.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_PAO.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_PAO.Text = "";
                textBoxResult_PAO.AppendText("+----------+----------+"+Environment.NewLine);
                textBoxResult_PAO.AppendText("+    x     |   f(x)   +"+ Environment.NewLine);
                textBoxResult_PAO.AppendText("+----------+----------+"+ Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("| {0,5:d}    |  {1, 5:f2}   |", startValue, valueArray[i]);
                    textBoxResult_PAO.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_PAO.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-1 Постика Артем Олегович", "Сообщение");
        }
    }
}
