
namespace Tyuiu.PostikaAO.Sprint6.Task0.V29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_PAO = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_PAO = new System.Windows.Forms.PictureBox();
            this.textBoxTask_PAO = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInPutData_PAO = new System.Windows.Forms.GroupBox();
            this.labelVarX_PAO = new System.Windows.Forms.Label();
            this.textBoxVarX_PAO = new System.Windows.Forms.TextBox();
            this.textBoxResult_PAO = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_PAO = new System.Windows.Forms.GroupBox();
            this.labelResult_PAO = new System.Windows.Forms.Label();
            this.buttonDone_PAO = new System.Windows.Forms.Button();
            this.buttonHelp_PAO = new System.Windows.Forms.Button();
            this.groupBoxCondition_PAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PAO)).BeginInit();
            this.groupBoxInPutData_PAO.SuspendLayout();
            this.groupBoxOutPutData_PAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PAO
            // 
            this.groupBoxCondition_PAO.Controls.Add(this.pictureBoxFormula_PAO);
            this.groupBoxCondition_PAO.Controls.Add(this.textBoxTask_PAO);
            this.groupBoxCondition_PAO.Location = new System.Drawing.Point(12, 27);
            this.groupBoxCondition_PAO.Name = "groupBoxCondition_PAO";
            this.groupBoxCondition_PAO.Size = new System.Drawing.Size(649, 172);
            this.groupBoxCondition_PAO.TabIndex = 0;
            this.groupBoxCondition_PAO.TabStop = false;
            this.groupBoxCondition_PAO.Text = "Условие";
            // 
            // pictureBoxFormula_PAO
            // 
            this.pictureBoxFormula_PAO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_PAO.Image")));
            this.pictureBoxFormula_PAO.Location = new System.Drawing.Point(440, 21);
            this.pictureBoxFormula_PAO.Name = "pictureBoxFormula_PAO";
            this.pictureBoxFormula_PAO.Size = new System.Drawing.Size(186, 132);
            this.pictureBoxFormula_PAO.TabIndex = 1;
            this.pictureBoxFormula_PAO.TabStop = false;
            // 
            // textBoxTask_PAO
            // 
            this.textBoxTask_PAO.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_PAO.Location = new System.Drawing.Point(18, 21);
            this.textBoxTask_PAO.Multiline = true;
            this.textBoxTask_PAO.Name = "textBoxTask_PAO";
            this.textBoxTask_PAO.Size = new System.Drawing.Size(400, 132);
            this.textBoxTask_PAO.TabIndex = 0;
            this.textBoxTask_PAO.Text = "Вычислите выражение по формуле";
            // 
            // groupBoxInPutData_PAO
            // 
            this.groupBoxInPutData_PAO.Controls.Add(this.labelVarX_PAO);
            this.groupBoxInPutData_PAO.Controls.Add(this.textBoxVarX_PAO);
            this.groupBoxInPutData_PAO.Location = new System.Drawing.Point(12, 217);
            this.groupBoxInPutData_PAO.Name = "groupBoxInPutData_PAO";
            this.groupBoxInPutData_PAO.Size = new System.Drawing.Size(270, 191);
            this.groupBoxInPutData_PAO.TabIndex = 1;
            this.groupBoxInPutData_PAO.TabStop = false;
            this.groupBoxInPutData_PAO.Text = "Ввод данных";
            // 
            // labelVarX_PAO
            // 
            this.labelVarX_PAO.AutoSize = true;
            this.labelVarX_PAO.Location = new System.Drawing.Point(79, 66);
            this.labelVarX_PAO.Name = "labelVarX_PAO";
            this.labelVarX_PAO.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_PAO.TabIndex = 2;
            this.labelVarX_PAO.Text = "Переменная X:";
            // 
            // textBoxVarX_PAO
            // 
            this.textBoxVarX_PAO.Location = new System.Drawing.Point(60, 86);
            this.textBoxVarX_PAO.Name = "textBoxVarX_PAO";
            this.textBoxVarX_PAO.Size = new System.Drawing.Size(144, 22);
            this.textBoxVarX_PAO.TabIndex = 0;
            // 
            // textBoxResult_PAO
            // 
            this.textBoxResult_PAO.Location = new System.Drawing.Point(27, 75);
            this.textBoxResult_PAO.Name = "textBoxResult_PAO";
            this.textBoxResult_PAO.ReadOnly = true;
            this.textBoxResult_PAO.Size = new System.Drawing.Size(132, 22);
            this.textBoxResult_PAO.TabIndex = 2;
            // 
            // groupBoxOutPutData_PAO
            // 
            this.groupBoxOutPutData_PAO.Controls.Add(this.labelResult_PAO);
            this.groupBoxOutPutData_PAO.Controls.Add(this.textBoxResult_PAO);
            this.groupBoxOutPutData_PAO.Location = new System.Drawing.Point(334, 217);
            this.groupBoxOutPutData_PAO.Name = "groupBoxOutPutData_PAO";
            this.groupBoxOutPutData_PAO.Size = new System.Drawing.Size(200, 128);
            this.groupBoxOutPutData_PAO.TabIndex = 3;
            this.groupBoxOutPutData_PAO.TabStop = false;
            this.groupBoxOutPutData_PAO.Text = "Вывод данных";
            // 
            // labelResult_PAO
            // 
            this.labelResult_PAO.AutoSize = true;
            this.labelResult_PAO.Location = new System.Drawing.Point(52, 55);
            this.labelResult_PAO.Name = "labelResult_PAO";
            this.labelResult_PAO.Size = new System.Drawing.Size(80, 17);
            this.labelResult_PAO.TabIndex = 3;
            this.labelResult_PAO.Text = "Результат:";
            this.labelResult_PAO.Click += new System.EventHandler(this.labelResult_PAO_Click);
            // 
            // buttonDone_PAO
            // 
            this.buttonDone_PAO.Location = new System.Drawing.Point(510, 378);
            this.buttonDone_PAO.Name = "buttonDone_PAO";
            this.buttonDone_PAO.Size = new System.Drawing.Size(128, 60);
            this.buttonDone_PAO.TabIndex = 4;
            this.buttonDone_PAO.Text = "Выполнить";
            this.buttonDone_PAO.UseVisualStyleBackColor = true;
            this.buttonDone_PAO.Click += new System.EventHandler(this.buttonDone_PAO_Click);
            // 
            // buttonHelp_PAO
            // 
            this.buttonHelp_PAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PAO.Location = new System.Drawing.Point(440, 378);
            this.buttonHelp_PAO.Name = "buttonHelp_PAO";
            this.buttonHelp_PAO.Size = new System.Drawing.Size(64, 60);
            this.buttonHelp_PAO.TabIndex = 5;
            this.buttonHelp_PAO.Text = "?";
            this.buttonHelp_PAO.UseVisualStyleBackColor = true;
            this.buttonHelp_PAO.Click += new System.EventHandler(this.buttonHelp_PAO_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.buttonHelp_PAO);
            this.Controls.Add(this.buttonDone_PAO);
            this.Controls.Add(this.groupBoxOutPutData_PAO);
            this.Controls.Add(this.groupBoxInPutData_PAO);
            this.Controls.Add(this.groupBoxCondition_PAO);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 29 | Постика А.О.";
            this.groupBoxCondition_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PAO)).EndInit();
            this.groupBoxInPutData_PAO.ResumeLayout(false);
            this.groupBoxInPutData_PAO.PerformLayout();
            this.groupBoxOutPutData_PAO.ResumeLayout(false);
            this.groupBoxOutPutData_PAO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PAO;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PAO;
        private System.Windows.Forms.TextBox textBoxTask_PAO;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxInPutData_PAO;
        private System.Windows.Forms.Label labelVarX_PAO;
        private System.Windows.Forms.TextBox textBoxVarX_PAO;
        private System.Windows.Forms.TextBox textBoxResult_PAO;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_PAO;
        private System.Windows.Forms.Label labelResult_PAO;
        private System.Windows.Forms.Button buttonHelp_PAO;
        private System.Windows.Forms.Button buttonDone_PAO;
    }
}

