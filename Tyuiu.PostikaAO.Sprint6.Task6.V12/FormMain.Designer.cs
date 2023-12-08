
namespace Tyuiu.PostikaAO.Sprint6.Task6.V12
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_PAO = new System.Windows.Forms.Panel();
            this.buttonHelp_PAO = new System.Windows.Forms.Button();
            this.buttonDone_PAO = new System.Windows.Forms.Button();
            this.buttonOpenFile_PAO = new System.Windows.Forms.Button();
            this.groupBoxCondition_PAO = new System.Windows.Forms.GroupBox();
            this.textBoxTask6_PAO = new System.Windows.Forms.TextBox();
            this.panelLeft_PAO = new System.Windows.Forms.Panel();
            this.groupBoxInPutData_PAO = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_PAO = new System.Windows.Forms.TextBox();
            this.panelFill_PAO = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_PAO = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_PAO = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask6_PAO = new System.Windows.Forms.OpenFileDialog();
            this.toolTipHint_PAO = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_PAO.SuspendLayout();
            this.groupBoxCondition_PAO.SuspendLayout();
            this.panelLeft_PAO.SuspendLayout();
            this.groupBoxInPutData_PAO.SuspendLayout();
            this.panelFill_PAO.SuspendLayout();
            this.groupBoxOutPutData_PAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_PAO
            // 
            this.panelTop_PAO.Controls.Add(this.buttonHelp_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonDone_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonOpenFile_PAO);
            this.panelTop_PAO.Controls.Add(this.groupBoxCondition_PAO);
            this.panelTop_PAO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PAO.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PAO.Name = "panelTop_PAO";
            this.panelTop_PAO.Size = new System.Drawing.Size(800, 160);
            this.panelTop_PAO.TabIndex = 0;
            // 
            // buttonHelp_PAO
            // 
            this.buttonHelp_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PAO.Image = global::Tyuiu.PostikaAO.Sprint6.Task6.V12.Properties.Resources.help;
            this.buttonHelp_PAO.Location = new System.Drawing.Point(715, 12);
            this.buttonHelp_PAO.Name = "buttonHelp_PAO";
            this.buttonHelp_PAO.Size = new System.Drawing.Size(73, 57);
            this.buttonHelp_PAO.TabIndex = 3;
            this.toolTipHint_PAO.SetToolTip(this.buttonHelp_PAO, "Сведение о программе ");
            this.buttonHelp_PAO.UseVisualStyleBackColor = true;
            this.buttonHelp_PAO.Click += new System.EventHandler(this.buttonHelp_PAO_Click);
            // 
            // buttonDone_PAO
            // 
            this.buttonDone_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PAO.Image = global::Tyuiu.PostikaAO.Sprint6.Task6.V12.Properties.Resources.page_go;
            this.buttonDone_PAO.Location = new System.Drawing.Point(103, 12);
            this.buttonDone_PAO.Name = "buttonDone_PAO";
            this.buttonDone_PAO.Size = new System.Drawing.Size(95, 57);
            this.buttonDone_PAO.TabIndex = 2;
            this.toolTipHint_PAO.SetToolTip(this.buttonDone_PAO, "Производит поиск в файле вхождений символов \"w\"\r\nи конкатенирует строки в которых" +
        " находятся эти символы");
            this.buttonDone_PAO.UseVisualStyleBackColor = true;
            this.buttonDone_PAO.Click += new System.EventHandler(this.buttonDone_PAO_Click);
            // 
            // buttonOpenFile_PAO
            // 
            this.buttonOpenFile_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_PAO.Image = global::Tyuiu.PostikaAO.Sprint6.Task6.V12.Properties.Resources.folder_page_white;
            this.buttonOpenFile_PAO.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_PAO.Name = "buttonOpenFile_PAO";
            this.buttonOpenFile_PAO.Size = new System.Drawing.Size(85, 57);
            this.buttonOpenFile_PAO.TabIndex = 1;
            this.toolTipHint_PAO.SetToolTip(this.buttonOpenFile_PAO, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_PAO.UseVisualStyleBackColor = true;
            this.buttonOpenFile_PAO.Click += new System.EventHandler(this.buttonOpenFile_PAO_Click);
            // 
            // groupBoxCondition_PAO
            // 
            this.groupBoxCondition_PAO.Controls.Add(this.textBoxTask6_PAO);
            this.groupBoxCondition_PAO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxCondition_PAO.Location = new System.Drawing.Point(0, 75);
            this.groupBoxCondition_PAO.Name = "groupBoxCondition_PAO";
            this.groupBoxCondition_PAO.Size = new System.Drawing.Size(800, 85);
            this.groupBoxCondition_PAO.TabIndex = 0;
            this.groupBoxCondition_PAO.TabStop = false;
            this.groupBoxCondition_PAO.Text = "Условие:";
            // 
            // textBoxTask6_PAO
            // 
            this.textBoxTask6_PAO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask6_PAO.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTask6_PAO.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask6_PAO.Multiline = true;
            this.textBoxTask6_PAO.Name = "textBoxTask6_PAO";
            this.textBoxTask6_PAO.Size = new System.Drawing.Size(794, 56);
            this.textBoxTask6_PAO.TabIndex = 0;
            this.textBoxTask6_PAO.Text = resources.GetString("textBoxTask6_PAO.Text");
            // 
            // panelLeft_PAO
            // 
            this.panelLeft_PAO.Controls.Add(this.groupBoxInPutData_PAO);
            this.panelLeft_PAO.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PAO.Location = new System.Drawing.Point(0, 160);
            this.panelLeft_PAO.Name = "panelLeft_PAO";
            this.panelLeft_PAO.Size = new System.Drawing.Size(393, 290);
            this.panelLeft_PAO.TabIndex = 1;
            // 
            // groupBoxInPutData_PAO
            // 
            this.groupBoxInPutData_PAO.Controls.Add(this.textBoxInPutData_PAO);
            this.groupBoxInPutData_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_PAO.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_PAO.Name = "groupBoxInPutData_PAO";
            this.groupBoxInPutData_PAO.Size = new System.Drawing.Size(393, 290);
            this.groupBoxInPutData_PAO.TabIndex = 0;
            this.groupBoxInPutData_PAO.TabStop = false;
            this.groupBoxInPutData_PAO.Text = "Ввод:";
            // 
            // textBoxInPutData_PAO
            // 
            this.textBoxInPutData_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPutData_PAO.Location = new System.Drawing.Point(3, 18);
            this.textBoxInPutData_PAO.Multiline = true;
            this.textBoxInPutData_PAO.Name = "textBoxInPutData_PAO";
            this.textBoxInPutData_PAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPutData_PAO.Size = new System.Drawing.Size(387, 269);
            this.textBoxInPutData_PAO.TabIndex = 0;
            // 
            // panelFill_PAO
            // 
            this.panelFill_PAO.Controls.Add(this.groupBoxOutPutData_PAO);
            this.panelFill_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PAO.Location = new System.Drawing.Point(393, 160);
            this.panelFill_PAO.Name = "panelFill_PAO";
            this.panelFill_PAO.Size = new System.Drawing.Size(407, 290);
            this.panelFill_PAO.TabIndex = 2;
            // 
            // groupBoxOutPutData_PAO
            // 
            this.groupBoxOutPutData_PAO.Controls.Add(this.textBoxOutPutData_PAO);
            this.groupBoxOutPutData_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_PAO.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_PAO.Name = "groupBoxOutPutData_PAO";
            this.groupBoxOutPutData_PAO.Size = new System.Drawing.Size(407, 290);
            this.groupBoxOutPutData_PAO.TabIndex = 0;
            this.groupBoxOutPutData_PAO.TabStop = false;
            this.groupBoxOutPutData_PAO.Text = "Вывод:";
            // 
            // textBoxOutPutData_PAO
            // 
            this.textBoxOutPutData_PAO.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxOutPutData_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPutData_PAO.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutPutData_PAO.Multiline = true;
            this.textBoxOutPutData_PAO.Name = "textBoxOutPutData_PAO";
            this.textBoxOutPutData_PAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_PAO.Size = new System.Drawing.Size(401, 269);
            this.textBoxOutPutData_PAO.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(393, 160);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 290);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // openFileDialogTask6_PAO
            // 
            this.openFileDialogTask6_PAO.FileName = "openFileDialog1";
            // 
            // toolTipHint_PAO
            // 
            this.toolTipHint_PAO.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHint_PAO.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelFill_PAO);
            this.Controls.Add(this.panelLeft_PAO);
            this.Controls.Add(this.panelTop_PAO);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 12 | Постика А.О";
            this.panelTop_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.PerformLayout();
            this.panelLeft_PAO.ResumeLayout(false);
            this.groupBoxInPutData_PAO.ResumeLayout(false);
            this.groupBoxInPutData_PAO.PerformLayout();
            this.panelFill_PAO.ResumeLayout(false);
            this.groupBoxOutPutData_PAO.ResumeLayout(false);
            this.groupBoxOutPutData_PAO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PAO;
        private System.Windows.Forms.GroupBox groupBoxCondition_PAO;
        private System.Windows.Forms.TextBox textBoxTask6_PAO;
        private System.Windows.Forms.Panel panelLeft_PAO;
        private System.Windows.Forms.Panel panelFill_PAO;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxInPutData_PAO;
        private System.Windows.Forms.TextBox textBoxInPutData_PAO;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_PAO;
        private System.Windows.Forms.TextBox textBoxOutPutData_PAO;
        private System.Windows.Forms.Button buttonHelp_PAO;
        private System.Windows.Forms.Button buttonDone_PAO;
        private System.Windows.Forms.Button buttonOpenFile_PAO;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask6_PAO;
        private System.Windows.Forms.ToolTip toolTipHint_PAO;
    }
}

