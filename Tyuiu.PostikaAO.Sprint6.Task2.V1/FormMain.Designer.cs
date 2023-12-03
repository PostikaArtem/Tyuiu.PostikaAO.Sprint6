
namespace Tyuiu.PostikaAO.Sprint6.Task2.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_PAO = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_PAO = new System.Windows.Forms.GroupBox();
            this.labelStopStep_PAO = new System.Windows.Forms.Label();
            this.labelStartStep_PAO = new System.Windows.Forms.Label();
            this.textBoxStopStep_PAO = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_PAO = new System.Windows.Forms.TextBox();
            this.buttonDone_PAO = new System.Windows.Forms.Button();
            this.buttonHelp_PAO = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_PAO = new System.Windows.Forms.GroupBox();
            this.chartFunction_PAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_PAO = new System.Windows.Forms.Label();
            this.dataGridViewFunction_PAO = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_PAO.SuspendLayout();
            this.groupBoxInPutData_PAO.SuspendLayout();
            this.groupBoxOutPutData_PAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PAO
            // 
            this.groupBoxCondition_PAO.Controls.Add(this.textBoxTask);
            this.groupBoxCondition_PAO.Location = new System.Drawing.Point(0, 12);
            this.groupBoxCondition_PAO.Name = "groupBoxCondition_PAO";
            this.groupBoxCondition_PAO.Size = new System.Drawing.Size(663, 242);
            this.groupBoxCondition_PAO.TabIndex = 0;
            this.groupBoxCondition_PAO.TabStop = false;
            this.groupBoxCondition_PAO.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxTask.Location = new System.Drawing.Point(3, 21);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(654, 207);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в DataGr" +
    "indView и построить график функции.";
            // 
            // groupBoxInPutData_PAO
            // 
            this.groupBoxInPutData_PAO.Controls.Add(this.labelStopStep_PAO);
            this.groupBoxInPutData_PAO.Controls.Add(this.labelStartStep_PAO);
            this.groupBoxInPutData_PAO.Controls.Add(this.textBoxStopStep_PAO);
            this.groupBoxInPutData_PAO.Controls.Add(this.textBoxStartStep_PAO);
            this.groupBoxInPutData_PAO.Location = new System.Drawing.Point(3, 283);
            this.groupBoxInPutData_PAO.Name = "groupBoxInPutData_PAO";
            this.groupBoxInPutData_PAO.Size = new System.Drawing.Size(454, 91);
            this.groupBoxInPutData_PAO.TabIndex = 1;
            this.groupBoxInPutData_PAO.TabStop = false;
            this.groupBoxInPutData_PAO.Text = "Ввод данных:";
            // 
            // labelStopStep_PAO
            // 
            this.labelStopStep_PAO.AutoSize = true;
            this.labelStopStep_PAO.Location = new System.Drawing.Point(149, 35);
            this.labelStopStep_PAO.Name = "labelStopStep_PAO";
            this.labelStopStep_PAO.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_PAO.TabIndex = 3;
            this.labelStopStep_PAO.Text = "Конец шага:";
            // 
            // labelStartStep_PAO
            // 
            this.labelStartStep_PAO.AutoSize = true;
            this.labelStartStep_PAO.Location = new System.Drawing.Point(6, 35);
            this.labelStartStep_PAO.Name = "labelStartStep_PAO";
            this.labelStartStep_PAO.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_PAO.TabIndex = 2;
            this.labelStartStep_PAO.Text = "Старт шага:";
            // 
            // textBoxStopStep_PAO
            // 
            this.textBoxStopStep_PAO.Location = new System.Drawing.Point(152, 55);
            this.textBoxStopStep_PAO.Name = "textBoxStopStep_PAO";
            this.textBoxStopStep_PAO.Size = new System.Drawing.Size(140, 22);
            this.textBoxStopStep_PAO.TabIndex = 1;
            // 
            // textBoxStartStep_PAO
            // 
            this.textBoxStartStep_PAO.Location = new System.Drawing.Point(6, 55);
            this.textBoxStartStep_PAO.Name = "textBoxStartStep_PAO";
            this.textBoxStartStep_PAO.Size = new System.Drawing.Size(140, 22);
            this.textBoxStartStep_PAO.TabIndex = 0;
            this.textBoxStartStep_PAO.TextChanged += new System.EventHandler(this.textBoxStartStep_PAO_TextChanged);
            // 
            // buttonDone_PAO
            // 
            this.buttonDone_PAO.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDone_PAO.Location = new System.Drawing.Point(548, 283);
            this.buttonDone_PAO.Name = "buttonDone_PAO";
            this.buttonDone_PAO.Size = new System.Drawing.Size(115, 91);
            this.buttonDone_PAO.TabIndex = 1;
            this.buttonDone_PAO.Text = "Выполнить";
            this.buttonDone_PAO.UseVisualStyleBackColor = false;
            this.buttonDone_PAO.Click += new System.EventHandler(this.buttonDone_PAO_Click);
            this.buttonDone_PAO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PAO_MouseDown);
            this.buttonDone_PAO.MouseEnter += new System.EventHandler(this.buttonDone_PAO_MouseEnter);
            this.buttonDone_PAO.MouseLeave += new System.EventHandler(this.buttonDone_PAO_MouseLeave);
            // 
            // buttonHelp_PAO
            // 
            this.buttonHelp_PAO.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelp_PAO.Location = new System.Drawing.Point(463, 283);
            this.buttonHelp_PAO.Name = "buttonHelp_PAO";
            this.buttonHelp_PAO.Size = new System.Drawing.Size(79, 91);
            this.buttonHelp_PAO.TabIndex = 2;
            this.buttonHelp_PAO.Text = "?";
            this.buttonHelp_PAO.UseVisualStyleBackColor = false;
            this.buttonHelp_PAO.Click += new System.EventHandler(this.buttonHelp_PAO_Click);
            // 
            // groupBoxOutPutData_PAO
            // 
            this.groupBoxOutPutData_PAO.Controls.Add(this.chartFunction_PAO);
            this.groupBoxOutPutData_PAO.Controls.Add(this.labelResult_PAO);
            this.groupBoxOutPutData_PAO.Controls.Add(this.dataGridViewFunction_PAO);
            this.groupBoxOutPutData_PAO.Location = new System.Drawing.Point(669, 12);
            this.groupBoxOutPutData_PAO.Name = "groupBoxOutPutData_PAO";
            this.groupBoxOutPutData_PAO.Size = new System.Drawing.Size(671, 362);
            this.groupBoxOutPutData_PAO.TabIndex = 3;
            this.groupBoxOutPutData_PAO.TabStop = false;
            this.groupBoxOutPutData_PAO.Text = "Вывод данных:";
            // 
            // chartFunction_PAO
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PAO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_PAO.Legends.Add(legend1);
            this.chartFunction_PAO.Location = new System.Drawing.Point(151, 53);
            this.chartFunction_PAO.Name = "chartFunction_PAO";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PAO.Series.Add(series1);
            this.chartFunction_PAO.Size = new System.Drawing.Size(491, 300);
            this.chartFunction_PAO.TabIndex = 2;
            this.chartFunction_PAO.Text = "chart1";
            this.chartFunction_PAO.Click += new System.EventHandler(this.chartFunction_PAO_Click);
            // 
            // labelResult_PAO
            // 
            this.labelResult_PAO.AutoSize = true;
            this.labelResult_PAO.Location = new System.Drawing.Point(6, 33);
            this.labelResult_PAO.Name = "labelResult_PAO";
            this.labelResult_PAO.Size = new System.Drawing.Size(80, 17);
            this.labelResult_PAO.TabIndex = 1;
            this.labelResult_PAO.Text = "Результат:";
            // 
            // dataGridViewFunction_PAO
            // 
            this.dataGridViewFunction_PAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_PAO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_PAO.Location = new System.Drawing.Point(6, 53);
            this.dataGridViewFunction_PAO.Name = "dataGridViewFunction_PAO";
            this.dataGridViewFunction_PAO.RowHeadersVisible = false;
            this.dataGridViewFunction_PAO.RowHeadersWidth = 51;
            this.dataGridViewFunction_PAO.RowTemplate.Height = 24;
            this.dataGridViewFunction_PAO.Size = new System.Drawing.Size(125, 303);
            this.dataGridViewFunction_PAO.TabIndex = 0;
            this.dataGridViewFunction_PAO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 380);
            this.Controls.Add(this.groupBoxOutPutData_PAO);
            this.Controls.Add(this.buttonHelp_PAO);
            this.Controls.Add(this.buttonDone_PAO);
            this.Controls.Add(this.groupBoxInPutData_PAO);
            this.Controls.Add(this.groupBoxCondition_PAO);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 1 | Постика А.О.";
            this.groupBoxCondition_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.PerformLayout();
            this.groupBoxInPutData_PAO.ResumeLayout(false);
            this.groupBoxInPutData_PAO.PerformLayout();
            this.groupBoxOutPutData_PAO.ResumeLayout(false);
            this.groupBoxOutPutData_PAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PAO;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInPutData_PAO;
        private System.Windows.Forms.Label labelStopStep_PAO;
        private System.Windows.Forms.Label labelStartStep_PAO;
        private System.Windows.Forms.TextBox textBoxStopStep_PAO;
        private System.Windows.Forms.TextBox textBoxStartStep_PAO;
        private System.Windows.Forms.Button buttonDone_PAO;
        private System.Windows.Forms.Button buttonHelp_PAO;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_PAO;
        private System.Windows.Forms.Label labelResult_PAO;
        private System.Windows.Forms.DataGridView dataGridViewFunction_PAO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

