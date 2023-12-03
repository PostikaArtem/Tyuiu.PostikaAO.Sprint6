
namespace Tyuiu.PostikaAO.Sprint6.Task1.V25
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
            this.groupBoxOutPutData_PAO = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_PAO = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_PAO = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_PAO = new System.Windows.Forms.TextBox();
            this.labelStartStep_PAO = new System.Windows.Forms.Label();
            this.labelStopStep_PAO = new System.Windows.Forms.Label();
            this.textBoxTask_PAO = new System.Windows.Forms.TextBox();
            this.buttonDone_PAO = new System.Windows.Forms.Button();
            this.buttonHelp_PAO = new System.Windows.Forms.Button();
            this.textBoxResult_PAO = new System.Windows.Forms.TextBox();
            this.labelResult_PAO = new System.Windows.Forms.Label();
            this.groupBoxCondition_PAO.SuspendLayout();
            this.groupBoxOutPutData_PAO.SuspendLayout();
            this.groupBoxInPutData_PAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PAO
            // 
            this.groupBoxCondition_PAO.Controls.Add(this.textBoxTask_PAO);
            this.groupBoxCondition_PAO.Location = new System.Drawing.Point(12, 23);
            this.groupBoxCondition_PAO.Name = "groupBoxCondition_PAO";
            this.groupBoxCondition_PAO.Size = new System.Drawing.Size(686, 248);
            this.groupBoxCondition_PAO.TabIndex = 0;
            this.groupBoxCondition_PAO.TabStop = false;
            this.groupBoxCondition_PAO.Text = "Условие";
            // 
            // groupBoxOutPutData_PAO
            // 
            this.groupBoxOutPutData_PAO.Controls.Add(this.labelResult_PAO);
            this.groupBoxOutPutData_PAO.Controls.Add(this.textBoxResult_PAO);
            this.groupBoxOutPutData_PAO.Location = new System.Drawing.Point(704, 27);
            this.groupBoxOutPutData_PAO.Name = "groupBoxOutPutData_PAO";
            this.groupBoxOutPutData_PAO.Size = new System.Drawing.Size(344, 348);
            this.groupBoxOutPutData_PAO.TabIndex = 1;
            this.groupBoxOutPutData_PAO.TabStop = false;
            this.groupBoxOutPutData_PAO.Text = "Вывод данных";
            // 
            // groupBoxInPutData_PAO
            // 
            this.groupBoxInPutData_PAO.Controls.Add(this.labelStopStep_PAO);
            this.groupBoxInPutData_PAO.Controls.Add(this.labelStartStep_PAO);
            this.groupBoxInPutData_PAO.Controls.Add(this.textBoxStopStep_PAO);
            this.groupBoxInPutData_PAO.Controls.Add(this.textBoxStartStep_PAO);
            this.groupBoxInPutData_PAO.Location = new System.Drawing.Point(12, 286);
            this.groupBoxInPutData_PAO.Name = "groupBoxInPutData_PAO";
            this.groupBoxInPutData_PAO.Size = new System.Drawing.Size(459, 85);
            this.groupBoxInPutData_PAO.TabIndex = 2;
            this.groupBoxInPutData_PAO.TabStop = false;
            this.groupBoxInPutData_PAO.Text = "Ввод данных";
            // 
            // textBoxStartStep_PAO
            // 
            this.textBoxStartStep_PAO.Location = new System.Drawing.Point(9, 49);
            this.textBoxStartStep_PAO.Name = "textBoxStartStep_PAO";
            this.textBoxStartStep_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartStep_PAO.TabIndex = 0;
            this.textBoxStartStep_PAO.TextChanged += new System.EventHandler(this.textBoxStart_PAO_TextChanged);
            // 
            // textBoxStopStep_PAO
            // 
            this.textBoxStopStep_PAO.Location = new System.Drawing.Point(131, 49);
            this.textBoxStopStep_PAO.Name = "textBoxStopStep_PAO";
            this.textBoxStopStep_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopStep_PAO.TabIndex = 1;
            // 
            // labelStartStep_PAO
            // 
            this.labelStartStep_PAO.AutoSize = true;
            this.labelStartStep_PAO.Location = new System.Drawing.Point(6, 29);
            this.labelStartStep_PAO.Name = "labelStartStep_PAO";
            this.labelStartStep_PAO.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_PAO.TabIndex = 2;
            this.labelStartStep_PAO.Text = "Старт шага:";
            this.labelStartStep_PAO.Click += new System.EventHandler(this.labelStart_PAO_Click);
            // 
            // labelStopStep_PAO
            // 
            this.labelStopStep_PAO.AutoSize = true;
            this.labelStopStep_PAO.Location = new System.Drawing.Point(128, 29);
            this.labelStopStep_PAO.Name = "labelStopStep_PAO";
            this.labelStopStep_PAO.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_PAO.TabIndex = 3;
            this.labelStopStep_PAO.Text = "Конец шага:";
            // 
            // textBoxTask_PAO
            // 
            this.textBoxTask_PAO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_PAO.Location = new System.Drawing.Point(9, 33);
            this.textBoxTask_PAO.Multiline = true;
            this.textBoxTask_PAO.Name = "textBoxTask_PAO";
            this.textBoxTask_PAO.ReadOnly = true;
            this.textBoxTask_PAO.Size = new System.Drawing.Size(421, 193);
            this.textBoxTask_PAO.TabIndex = 0;
            this.textBoxTask_PAO.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в виде т" +
    "аблицы.\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // buttonDone_PAO
            // 
            this.buttonDone_PAO.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonDone_PAO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_PAO.Location = new System.Drawing.Point(575, 290);
            this.buttonDone_PAO.Name = "buttonDone_PAO";
            this.buttonDone_PAO.Size = new System.Drawing.Size(123, 85);
            this.buttonDone_PAO.TabIndex = 3;
            this.buttonDone_PAO.Text = "Выполнить";
            this.buttonDone_PAO.UseVisualStyleBackColor = false;
            this.buttonDone_PAO.Click += new System.EventHandler(this.buttonDone_PAO_Click);
            // 
            // buttonHelp_PAO
            // 
            this.buttonHelp_PAO.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_PAO.Location = new System.Drawing.Point(486, 290);
            this.buttonHelp_PAO.Name = "buttonHelp_PAO";
            this.buttonHelp_PAO.Size = new System.Drawing.Size(83, 85);
            this.buttonHelp_PAO.TabIndex = 4;
            this.buttonHelp_PAO.Text = "?";
            this.buttonHelp_PAO.UseVisualStyleBackColor = false;
            this.buttonHelp_PAO.Click += new System.EventHandler(this.buttonHelp_PAO_Click);
            // 
            // textBoxResult_PAO
            // 
            this.textBoxResult_PAO.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_PAO.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_PAO.Location = new System.Drawing.Point(6, 49);
            this.textBoxResult_PAO.Multiline = true;
            this.textBoxResult_PAO.Name = "textBoxResult_PAO";
            this.textBoxResult_PAO.ReadOnly = true;
            this.textBoxResult_PAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PAO.Size = new System.Drawing.Size(299, 299);
            this.textBoxResult_PAO.TabIndex = 0;
            // 
            // labelResult_PAO
            // 
            this.labelResult_PAO.AutoSize = true;
            this.labelResult_PAO.Location = new System.Drawing.Point(6, 29);
            this.labelResult_PAO.Name = "labelResult_PAO";
            this.labelResult_PAO.Size = new System.Drawing.Size(80, 17);
            this.labelResult_PAO.TabIndex = 1;
            this.labelResult_PAO.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 387);
            this.Controls.Add(this.buttonHelp_PAO);
            this.Controls.Add(this.buttonDone_PAO);
            this.Controls.Add(this.groupBoxInPutData_PAO);
            this.Controls.Add(this.groupBoxOutPutData_PAO);
            this.Controls.Add(this.groupBoxCondition_PAO);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 25 | Постика А.О.";
            this.groupBoxCondition_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.PerformLayout();
            this.groupBoxOutPutData_PAO.ResumeLayout(false);
            this.groupBoxOutPutData_PAO.PerformLayout();
            this.groupBoxInPutData_PAO.ResumeLayout(false);
            this.groupBoxInPutData_PAO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PAO;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_PAO;
        private System.Windows.Forms.GroupBox groupBoxInPutData_PAO;
        private System.Windows.Forms.Label labelStartStep_PAO;
        private System.Windows.Forms.TextBox textBoxStopStep_PAO;
        private System.Windows.Forms.TextBox textBoxStartStep_PAO;
        private System.Windows.Forms.Label labelStopStep_PAO;
        internal System.Windows.Forms.TextBox textBoxTask_PAO;
        private System.Windows.Forms.Button buttonDone_PAO;
        private System.Windows.Forms.Button buttonHelp_PAO;
        private System.Windows.Forms.Label labelResult_PAO;
        private System.Windows.Forms.TextBox textBoxResult_PAO;
    }
}

