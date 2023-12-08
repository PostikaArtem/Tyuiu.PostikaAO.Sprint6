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

using Tyuiu.PostikaAO.Sprint6.Task7.V13.Lib;
namespace Tyuiu.PostikaAO.Sprint6.Task7.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask7_PAO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_PAO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        private void buttonOpenFile_PAO_Click(object sender, EventArgs e)
        {
            openFileDialogTask7_PAO.ShowDialog();
            openFilePath = openFileDialogTask7_PAO.FileName;

            string fileData = File.ReadAllText(openFilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] temp = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(temp[c]);
                }
            }

            dataGridViewInPutData_PAO.ColumnCount = colums;
            dataGridViewInPutData_PAO.RowCount = rows;
            dataGridViewOutPutData_PAO.ColumnCount = colums;
            dataGridViewOutPutData_PAO.RowCount = rows;

            for(int i=0; i < colums; i++)
            {
                dataGridViewInPutData_PAO.Columns[i].Width = 40;
                dataGridViewOutPutData_PAO.Columns[i].Width = 40;
            }

            for(int r=0; r < rows; r++)
            {
                for(int c =0; c<colums; c++)
                {
                    dataGridViewInPutData_PAO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            
            buttonDone_PAO.Enabled = true;
        }

        private void buttonDone_PAO_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for(int r=0; r < rows; r++)
            {
                for(int c =0; c< colums; c++)
                {
                    dataGridViewOutPutData_PAO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_PAO.Enabled = true;


        }

        private void buttonSaveFile_PAO_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PAO.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_PAO.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PAO.ShowDialog();

            string path = saveFileDialogMatrix_PAO.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutData_PAO.RowCount;
            int columns = dataGridViewOutPutData_PAO.ColumnCount;

            string str = "";

            for(int i=0; i<rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPutData_PAO.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPutData_PAO.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_PAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PAO.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_PAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PAO.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_PAO_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void buttonHelp_PAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PAO.ToolTipTitle = "Справка";
        }

        private void buttonSaveFile_PAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PAO.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_PAO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
