using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PostikaAO.Sprint6.Task0.V29.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task0.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelResult_PAO_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_PAO_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_PAO.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_PAO.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИППб-23-1 Постика Артем Олегович", "Сообщение");
        }
    }
}
