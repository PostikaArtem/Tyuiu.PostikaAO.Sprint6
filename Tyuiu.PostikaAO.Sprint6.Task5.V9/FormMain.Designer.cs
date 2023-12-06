
namespace Tyuiu.PostikaAO.Sprint6.Task5.V9
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_PAO = new System.Windows.Forms.Panel();
            this.panelLeft_PAO = new System.Windows.Forms.Panel();
            this.panelFill_PAO = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxCondition_PAO = new System.Windows.Forms.GroupBox();
            this.textBoxTask5_PAO = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_PAO = new System.Windows.Forms.GroupBox();
            this.chartDiag_PAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_PAO = new System.Windows.Forms.Button();
            this.buttonOpenFile_PAO = new System.Windows.Forms.Button();
            this.buttonHelp_PAO = new System.Windows.Forms.Button();
            this.dataGridViewNum_PAO = new System.Windows.Forms.DataGridView();
            this.panelTop_PAO.SuspendLayout();
            this.panelLeft_PAO.SuspendLayout();
            this.panelFill_PAO.SuspendLayout();
            this.groupBoxCondition_PAO.SuspendLayout();
            this.groupBoxOutPutData_PAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_PAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNum_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_PAO
            // 
            this.panelTop_PAO.Controls.Add(this.buttonHelp_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonOpenFile_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonDone_PAO);
            this.panelTop_PAO.Controls.Add(this.groupBoxCondition_PAO);
            this.panelTop_PAO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PAO.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PAO.Name = "panelTop_PAO";
            this.panelTop_PAO.Size = new System.Drawing.Size(884, 100);
            this.panelTop_PAO.TabIndex = 0;
            // 
            // panelLeft_PAO
            // 
            this.panelLeft_PAO.Controls.Add(this.groupBoxOutPutData_PAO);
            this.panelLeft_PAO.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PAO.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_PAO.Name = "panelLeft_PAO";
            this.panelLeft_PAO.Size = new System.Drawing.Size(200, 350);
            this.panelLeft_PAO.TabIndex = 1;
            // 
            // panelFill_PAO
            // 
            this.panelFill_PAO.Controls.Add(this.chartDiag_PAO);
            this.panelFill_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PAO.Location = new System.Drawing.Point(200, 100);
            this.panelFill_PAO.Name = "panelFill_PAO";
            this.panelFill_PAO.Size = new System.Drawing.Size(684, 350);
            this.panelFill_PAO.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 350);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // groupBoxCondition_PAO
            // 
            this.groupBoxCondition_PAO.Controls.Add(this.textBoxTask5_PAO);
            this.groupBoxCondition_PAO.Location = new System.Drawing.Point(3, 6);
            this.groupBoxCondition_PAO.Name = "groupBoxCondition_PAO";
            this.groupBoxCondition_PAO.Size = new System.Drawing.Size(473, 88);
            this.groupBoxCondition_PAO.TabIndex = 0;
            this.groupBoxCondition_PAO.TabStop = false;
            this.groupBoxCondition_PAO.Text = "Условие:";
            // 
            // textBoxTask5_PAO
            // 
            this.textBoxTask5_PAO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask5_PAO.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask5_PAO.Multiline = true;
            this.textBoxTask5_PAO.Name = "textBoxTask5_PAO";
            this.textBoxTask5_PAO.Size = new System.Drawing.Size(461, 61);
            this.textBoxTask5_PAO.TabIndex = 0;
            this.textBoxTask5_PAO.Text = "Прочитать данные из файла InPutFileTask5V9.txt. Вывести в dataGridView.Дан список" +
    " из чисел. Вывести все элементы, равные 0. Построить диаграмму по этим значениям" +
    ".";
            // 
            // groupBoxOutPutData_PAO
            // 
            this.groupBoxOutPutData_PAO.Controls.Add(this.dataGridViewNum_PAO);
            this.groupBoxOutPutData_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_PAO.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_PAO.Name = "groupBoxOutPutData_PAO";
            this.groupBoxOutPutData_PAO.Size = new System.Drawing.Size(200, 350);
            this.groupBoxOutPutData_PAO.TabIndex = 0;
            this.groupBoxOutPutData_PAO.TabStop = false;
            this.groupBoxOutPutData_PAO.Text = "Вывод данных:";
            // 
            // chartDiag_PAO
            // 
            chartArea13.Name = "ChartArea1";
            this.chartDiag_PAO.ChartAreas.Add(chartArea13);
            this.chartDiag_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            legend13.Name = "Legend1";
            this.chartDiag_PAO.Legends.Add(legend13);
            this.chartDiag_PAO.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_PAO.Name = "chartDiag_PAO";
            series13.ChartArea = "ChartArea1";
            series13.IsVisibleInLegend = false;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chartDiag_PAO.Series.Add(series13);
            this.chartDiag_PAO.Size = new System.Drawing.Size(684, 350);
            this.chartDiag_PAO.TabIndex = 0;
            this.chartDiag_PAO.Text = "chart1";
            // 
            // buttonDone_PAO
            // 
            this.buttonDone_PAO.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PAO.Location = new System.Drawing.Point(482, 12);
            this.buttonDone_PAO.Name = "buttonDone_PAO";
            this.buttonDone_PAO.Size = new System.Drawing.Size(101, 76);
            this.buttonDone_PAO.TabIndex = 1;
            this.buttonDone_PAO.Text = "Выполнить";
            this.buttonDone_PAO.UseVisualStyleBackColor = false;
            this.buttonDone_PAO.Click += new System.EventHandler(this.buttonDone_PAO_Click);
            this.buttonDone_PAO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PAO_MouseDown);
            this.buttonDone_PAO.MouseEnter += new System.EventHandler(this.buttonDone_PAO_MouseEnter);
            this.buttonDone_PAO.MouseLeave += new System.EventHandler(this.buttonDone_PAO_MouseLeave);
            // 
            // buttonOpenFile_PAO
            // 
            this.buttonOpenFile_PAO.BackColor = System.Drawing.Color.Orange;
            this.buttonOpenFile_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_PAO.Location = new System.Drawing.Point(589, 12);
            this.buttonOpenFile_PAO.Name = "buttonOpenFile_PAO";
            this.buttonOpenFile_PAO.Size = new System.Drawing.Size(94, 76);
            this.buttonOpenFile_PAO.TabIndex = 2;
            this.buttonOpenFile_PAO.Text = "Открыть файл";
            this.buttonOpenFile_PAO.UseVisualStyleBackColor = false;
            this.buttonOpenFile_PAO.Click += new System.EventHandler(this.buttonOpenFile_PAO_Click);
            this.buttonOpenFile_PAO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_PAO_MouseDown);
            this.buttonOpenFile_PAO.MouseEnter += new System.EventHandler(this.buttonOpenFile_PAO_MouseEnter);
            this.buttonOpenFile_PAO.MouseLeave += new System.EventHandler(this.buttonOpenFile_PAO_MouseLeave);
            // 
            // buttonHelp_PAO
            // 
            this.buttonHelp_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PAO.BackColor = System.Drawing.Color.Yellow;
            this.buttonHelp_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PAO.Location = new System.Drawing.Point(798, 12);
            this.buttonHelp_PAO.Name = "buttonHelp_PAO";
            this.buttonHelp_PAO.Size = new System.Drawing.Size(74, 76);
            this.buttonHelp_PAO.TabIndex = 3;
            this.buttonHelp_PAO.Text = "?";
            this.buttonHelp_PAO.UseVisualStyleBackColor = false;
            this.buttonHelp_PAO.Click += new System.EventHandler(this.buttonHelp_PAO_Click);
            this.buttonHelp_PAO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonHelp_PAO_MouseDown);
            this.buttonHelp_PAO.MouseEnter += new System.EventHandler(this.buttonHelp_PAO_MouseEnter);
            this.buttonHelp_PAO.MouseLeave += new System.EventHandler(this.buttonHelp_PAO_MouseLeave);
            // 
            // dataGridViewNum_PAO
            // 
            this.dataGridViewNum_PAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNum_PAO.ColumnHeadersVisible = false;
            this.dataGridViewNum_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNum_PAO.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewNum_PAO.Name = "dataGridViewNum_PAO";
            this.dataGridViewNum_PAO.ReadOnly = true;
            this.dataGridViewNum_PAO.RowHeadersVisible = false;
            this.dataGridViewNum_PAO.RowHeadersWidth = 51;
            this.dataGridViewNum_PAO.RowTemplate.Height = 24;
            this.dataGridViewNum_PAO.Size = new System.Drawing.Size(194, 329);
            this.dataGridViewNum_PAO.TabIndex = 0;
            this.dataGridViewNum_PAO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNum_PAO_CellContentClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelFill_PAO);
            this.Controls.Add(this.panelLeft_PAO);
            this.Controls.Add(this.panelTop_PAO);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 9 | Постика А.О.";
            this.panelTop_PAO.ResumeLayout(false);
            this.panelLeft_PAO.ResumeLayout(false);
            this.panelFill_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.PerformLayout();
            this.groupBoxOutPutData_PAO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_PAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNum_PAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PAO;
        private System.Windows.Forms.Button buttonHelp_PAO;
        private System.Windows.Forms.Button buttonOpenFile_PAO;
        private System.Windows.Forms.Button buttonDone_PAO;
        private System.Windows.Forms.GroupBox groupBoxCondition_PAO;
        private System.Windows.Forms.TextBox textBoxTask5_PAO;
        private System.Windows.Forms.Panel panelLeft_PAO;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_PAO;
        private System.Windows.Forms.Panel panelFill_PAO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_PAO;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewNum_PAO;
    }
}

