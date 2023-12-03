
namespace Tyuiu.PostikaAO.Sprint6.Task3.V15
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
            this.groupBoxCondition_PAO = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PAO = new System.Windows.Forms.TextBox();
            this.groupBoxOutOutData_PAO = new System.Windows.Forms.GroupBox();
            this.buttonDone_PAO = new System.Windows.Forms.Button();
            this.buttonHelp_PAO = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_PAO = new System.Windows.Forms.DataGridView();
            this.dataGridViewResuld_PAO = new System.Windows.Forms.DataGridView();
            this.labelResult_PAO = new System.Windows.Forms.Label();
            this.groupBoxCondition_PAO.SuspendLayout();
            this.groupBoxOutOutData_PAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResuld_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PAO
            // 
            this.groupBoxCondition_PAO.Controls.Add(this.textBoxTask_PAO);
            this.groupBoxCondition_PAO.Location = new System.Drawing.Point(12, 27);
            this.groupBoxCondition_PAO.Name = "groupBoxCondition_PAO";
            this.groupBoxCondition_PAO.Size = new System.Drawing.Size(414, 302);
            this.groupBoxCondition_PAO.TabIndex = 0;
            this.groupBoxCondition_PAO.TabStop = false;
            this.groupBoxCondition_PAO.Text = "Условие";
            // 
            // textBoxTask_PAO
            // 
            this.textBoxTask_PAO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_PAO.Location = new System.Drawing.Point(6, 32);
            this.textBoxTask_PAO.Multiline = true;
            this.textBoxTask_PAO.Name = "textBoxTask_PAO";
            this.textBoxTask_PAO.ReadOnly = true;
            this.textBoxTask_PAO.Size = new System.Drawing.Size(396, 252);
            this.textBoxTask_PAO.TabIndex = 0;
            this.textBoxTask_PAO.Text = "Дана матрица 5 на 5 \r\n33    28   31   19    4\r\n1      32   -3  -17  -12\r\n24  -19 " +
    "   26   31   -3\r\n30  -16    29   28     8\r\n30      5    11     7   32\r\ncортирова" +
    "ть по возрастанию в третьем столбце.\r\n";
            // 
            // groupBoxOutOutData_PAO
            // 
            this.groupBoxOutOutData_PAO.Controls.Add(this.labelResult_PAO);
            this.groupBoxOutOutData_PAO.Controls.Add(this.dataGridViewResuld_PAO);
            this.groupBoxOutOutData_PAO.Location = new System.Drawing.Point(651, 27);
            this.groupBoxOutOutData_PAO.Name = "groupBoxOutOutData_PAO";
            this.groupBoxOutOutData_PAO.Size = new System.Drawing.Size(317, 236);
            this.groupBoxOutOutData_PAO.TabIndex = 2;
            this.groupBoxOutOutData_PAO.TabStop = false;
            this.groupBoxOutOutData_PAO.Text = "Вывод данных";
            // 
            // buttonDone_PAO
            // 
            this.buttonDone_PAO.Location = new System.Drawing.Point(861, 286);
            this.buttonDone_PAO.Name = "buttonDone_PAO";
            this.buttonDone_PAO.Size = new System.Drawing.Size(123, 47);
            this.buttonDone_PAO.TabIndex = 3;
            this.buttonDone_PAO.Text = "Выполнить";
            this.buttonDone_PAO.UseVisualStyleBackColor = true;
            this.buttonDone_PAO.Click += new System.EventHandler(this.buttonDone_PAO_Click);
            // 
            // buttonHelp_PAO
            // 
            this.buttonHelp_PAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PAO.Location = new System.Drawing.Point(807, 288);
            this.buttonHelp_PAO.Name = "buttonHelp_PAO";
            this.buttonHelp_PAO.Size = new System.Drawing.Size(48, 43);
            this.buttonHelp_PAO.TabIndex = 4;
            this.buttonHelp_PAO.Text = "?";
            this.buttonHelp_PAO.UseVisualStyleBackColor = true;
            this.buttonHelp_PAO.Click += new System.EventHandler(this.buttonHelp_PAO_Click);
            // 
            // dataGridViewMatrix_PAO
            // 
            this.dataGridViewMatrix_PAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_PAO.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_PAO.Location = new System.Drawing.Point(453, 27);
            this.dataGridViewMatrix_PAO.Name = "dataGridViewMatrix_PAO";
            this.dataGridViewMatrix_PAO.ReadOnly = true;
            this.dataGridViewMatrix_PAO.RowHeadersVisible = false;
            this.dataGridViewMatrix_PAO.RowHeadersWidth = 51;
            this.dataGridViewMatrix_PAO.RowTemplate.Height = 24;
            this.dataGridViewMatrix_PAO.Size = new System.Drawing.Size(192, 302);
            this.dataGridViewMatrix_PAO.TabIndex = 5;
            // 
            // dataGridViewResuld_PAO
            // 
            this.dataGridViewResuld_PAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResuld_PAO.ColumnHeadersVisible = false;
            this.dataGridViewResuld_PAO.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewResuld_PAO.Name = "dataGridViewResuld_PAO";
            this.dataGridViewResuld_PAO.RowHeadersVisible = false;
            this.dataGridViewResuld_PAO.RowHeadersWidth = 51;
            this.dataGridViewResuld_PAO.RowTemplate.Height = 24;
            this.dataGridViewResuld_PAO.Size = new System.Drawing.Size(305, 182);
            this.dataGridViewResuld_PAO.TabIndex = 0;
            this.dataGridViewResuld_PAO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResuld_PAO_CellContentClick);
            // 
            // labelResult_PAO
            // 
            this.labelResult_PAO.AutoSize = true;
            this.labelResult_PAO.Location = new System.Drawing.Point(6, 28);
            this.labelResult_PAO.Name = "labelResult_PAO";
            this.labelResult_PAO.Size = new System.Drawing.Size(80, 17);
            this.labelResult_PAO.TabIndex = 1;
            this.labelResult_PAO.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 344);
            this.Controls.Add(this.dataGridViewMatrix_PAO);
            this.Controls.Add(this.buttonHelp_PAO);
            this.Controls.Add(this.buttonDone_PAO);
            this.Controls.Add(this.groupBoxOutOutData_PAO);
            this.Controls.Add(this.groupBoxCondition_PAO);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 15 | Постика А.О.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.PerformLayout();
            this.groupBoxOutOutData_PAO.ResumeLayout(false);
            this.groupBoxOutOutData_PAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResuld_PAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PAO;
        private System.Windows.Forms.TextBox textBoxTask_PAO;
        private System.Windows.Forms.GroupBox groupBoxOutOutData_PAO;
        private System.Windows.Forms.Button buttonDone_PAO;
        private System.Windows.Forms.Button buttonHelp_PAO;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_PAO;
        private System.Windows.Forms.DataGridView dataGridViewResuld_PAO;
        private System.Windows.Forms.Label labelResult_PAO;
    }
}

