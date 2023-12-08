
namespace Tyuiu.PostikaAO.Sprint6.Task7.V13
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
            this.panelLeft_PAO = new System.Windows.Forms.Panel();
            this.panelFill_PAO = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxCondition_PAO = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_PAO = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_PAO = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPutData_PAO = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutPutData_PAO = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask7_PAO = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_PAO = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_PAO = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_PAO = new System.Windows.Forms.Button();
            this.buttonSaveFile_PAO = new System.Windows.Forms.Button();
            this.buttonDone_PAO = new System.Windows.Forms.Button();
            this.buttonOpenFile_PAO = new System.Windows.Forms.Button();
            this.panelTop_PAO.SuspendLayout();
            this.panelLeft_PAO.SuspendLayout();
            this.panelFill_PAO.SuspendLayout();
            this.groupBoxCondition_PAO.SuspendLayout();
            this.groupBoxInPutData_PAO.SuspendLayout();
            this.groupBoxOutPutData_PAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_PAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_PAO
            // 
            this.panelTop_PAO.Controls.Add(this.buttonHelp_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonSaveFile_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonDone_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonOpenFile_PAO);
            this.panelTop_PAO.Controls.Add(this.groupBoxCondition_PAO);
            this.panelTop_PAO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PAO.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PAO.Name = "panelTop_PAO";
            this.panelTop_PAO.Size = new System.Drawing.Size(800, 168);
            this.panelTop_PAO.TabIndex = 0;
            // 
            // panelLeft_PAO
            // 
            this.panelLeft_PAO.Controls.Add(this.groupBoxInPutData_PAO);
            this.panelLeft_PAO.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PAO.Location = new System.Drawing.Point(0, 168);
            this.panelLeft_PAO.Name = "panelLeft_PAO";
            this.panelLeft_PAO.Size = new System.Drawing.Size(389, 282);
            this.panelLeft_PAO.TabIndex = 1;
            // 
            // panelFill_PAO
            // 
            this.panelFill_PAO.Controls.Add(this.groupBoxOutPutData_PAO);
            this.panelFill_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PAO.Location = new System.Drawing.Point(389, 168);
            this.panelFill_PAO.Name = "panelFill_PAO";
            this.panelFill_PAO.Size = new System.Drawing.Size(411, 282);
            this.panelFill_PAO.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(389, 168);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 282);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // groupBoxCondition_PAO
            // 
            this.groupBoxCondition_PAO.Controls.Add(this.textBox1);
            this.groupBoxCondition_PAO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxCondition_PAO.Location = new System.Drawing.Point(0, 78);
            this.groupBoxCondition_PAO.Name = "groupBoxCondition_PAO";
            this.groupBoxCondition_PAO.Size = new System.Drawing.Size(800, 90);
            this.groupBoxCondition_PAO.TabIndex = 0;
            this.groupBoxCondition_PAO.TabStop = false;
            this.groupBoxCondition_PAO.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(794, 69);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxInPutData_PAO
            // 
            this.groupBoxInPutData_PAO.Controls.Add(this.dataGridViewInPutData_PAO);
            this.groupBoxInPutData_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_PAO.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_PAO.Name = "groupBoxInPutData_PAO";
            this.groupBoxInPutData_PAO.Size = new System.Drawing.Size(389, 282);
            this.groupBoxInPutData_PAO.TabIndex = 0;
            this.groupBoxInPutData_PAO.TabStop = false;
            this.groupBoxInPutData_PAO.Text = "Ввод:";
            // 
            // groupBoxOutPutData_PAO
            // 
            this.groupBoxOutPutData_PAO.Controls.Add(this.dataGridViewOutPutData_PAO);
            this.groupBoxOutPutData_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_PAO.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_PAO.Name = "groupBoxOutPutData_PAO";
            this.groupBoxOutPutData_PAO.Size = new System.Drawing.Size(411, 282);
            this.groupBoxOutPutData_PAO.TabIndex = 0;
            this.groupBoxOutPutData_PAO.TabStop = false;
            this.groupBoxOutPutData_PAO.Text = "Вывод:";
            // 
            // dataGridViewInPutData_PAO
            // 
            this.dataGridViewInPutData_PAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_PAO.ColumnHeadersVisible = false;
            this.dataGridViewInPutData_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPutData_PAO.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInPutData_PAO.Name = "dataGridViewInPutData_PAO";
            this.dataGridViewInPutData_PAO.RowHeadersVisible = false;
            this.dataGridViewInPutData_PAO.RowHeadersWidth = 51;
            this.dataGridViewInPutData_PAO.RowTemplate.Height = 24;
            this.dataGridViewInPutData_PAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInPutData_PAO.Size = new System.Drawing.Size(383, 261);
            this.dataGridViewInPutData_PAO.TabIndex = 0;
            // 
            // dataGridViewOutPutData_PAO
            // 
            this.dataGridViewOutPutData_PAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_PAO.ColumnHeadersVisible = false;
            this.dataGridViewOutPutData_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPutData_PAO.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutPutData_PAO.Name = "dataGridViewOutPutData_PAO";
            this.dataGridViewOutPutData_PAO.RowHeadersVisible = false;
            this.dataGridViewOutPutData_PAO.RowHeadersWidth = 51;
            this.dataGridViewOutPutData_PAO.RowTemplate.Height = 24;
            this.dataGridViewOutPutData_PAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPutData_PAO.Size = new System.Drawing.Size(405, 261);
            this.dataGridViewOutPutData_PAO.TabIndex = 0;
            // 
            // openFileDialogTask7_PAO
            // 
            this.openFileDialogTask7_PAO.FileName = "openFileDialog1";
            // 
            // toolTipButton_PAO
            // 
            this.toolTipButton_PAO.IsBalloon = true;
            this.toolTipButton_PAO.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_PAO.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_PAO
            // 
            this.buttonHelp_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PAO.Image = global::Tyuiu.PostikaAO.Sprint6.Task7.V13.Properties.Resources.help;
            this.buttonHelp_PAO.Location = new System.Drawing.Point(714, 12);
            this.buttonHelp_PAO.Name = "buttonHelp_PAO";
            this.buttonHelp_PAO.Size = new System.Drawing.Size(74, 66);
            this.buttonHelp_PAO.TabIndex = 4;
            this.toolTipButton_PAO.SetToolTip(this.buttonHelp_PAO, "Сведение о программе");
            this.buttonHelp_PAO.UseVisualStyleBackColor = true;
            this.buttonHelp_PAO.Click += new System.EventHandler(this.buttonHelp_PAO_Click);
            this.buttonHelp_PAO.MouseEnter += new System.EventHandler(this.buttonHelp_PAO_MouseEnter);
            // 
            // buttonSaveFile_PAO
            // 
            this.buttonSaveFile_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_PAO.Enabled = false;
            this.buttonSaveFile_PAO.Image = global::Tyuiu.PostikaAO.Sprint6.Task7.V13.Properties.Resources.page_save;
            this.buttonSaveFile_PAO.Location = new System.Drawing.Point(171, 12);
            this.buttonSaveFile_PAO.Name = "buttonSaveFile_PAO";
            this.buttonSaveFile_PAO.Size = new System.Drawing.Size(84, 66);
            this.buttonSaveFile_PAO.TabIndex = 3;
            this.toolTipButton_PAO.SetToolTip(this.buttonSaveFile_PAO, "Сохранит обработанные данные в файл в формате CSV\r\n");
            this.buttonSaveFile_PAO.UseVisualStyleBackColor = true;
            this.buttonSaveFile_PAO.Click += new System.EventHandler(this.buttonSaveFile_PAO_Click);
            this.buttonSaveFile_PAO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSaveFile_PAO_MouseDown);
            this.buttonSaveFile_PAO.MouseEnter += new System.EventHandler(this.buttonSaveFile_PAO_MouseEnter);
            // 
            // buttonDone_PAO
            // 
            this.buttonDone_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PAO.Enabled = false;
            this.buttonDone_PAO.Image = global::Tyuiu.PostikaAO.Sprint6.Task7.V13.Properties.Resources.page_go;
            this.buttonDone_PAO.Location = new System.Drawing.Point(90, 12);
            this.buttonDone_PAO.Name = "buttonDone_PAO";
            this.buttonDone_PAO.Size = new System.Drawing.Size(75, 66);
            this.buttonDone_PAO.TabIndex = 2;
            this.toolTipButton_PAO.SetToolTip(this.buttonDone_PAO, "Выполнить обработку данных");
            this.buttonDone_PAO.UseVisualStyleBackColor = true;
            this.buttonDone_PAO.Click += new System.EventHandler(this.buttonDone_PAO_Click);
            this.buttonDone_PAO.MouseEnter += new System.EventHandler(this.buttonDone_PAO_MouseEnter);
            // 
            // buttonOpenFile_PAO
            // 
            this.buttonOpenFile_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_PAO.Image = global::Tyuiu.PostikaAO.Sprint6.Task7.V13.Properties.Resources.folder_page_white;
            this.buttonOpenFile_PAO.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_PAO.Name = "buttonOpenFile_PAO";
            this.buttonOpenFile_PAO.Size = new System.Drawing.Size(72, 66);
            this.buttonOpenFile_PAO.TabIndex = 1;
            this.toolTipButton_PAO.SetToolTip(this.buttonOpenFile_PAO, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_PAO.UseVisualStyleBackColor = true;
            this.buttonOpenFile_PAO.Click += new System.EventHandler(this.buttonOpenFile_PAO_Click);
            this.buttonOpenFile_PAO.MouseEnter += new System.EventHandler(this.buttonOpenFile_PAO_MouseEnter);
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
            this.Text = "Спринт 6 | Таск 7 | Вариант 13 | Постика А.О.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop_PAO.ResumeLayout(false);
            this.panelLeft_PAO.ResumeLayout(false);
            this.panelFill_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.ResumeLayout(false);
            this.groupBoxCondition_PAO.PerformLayout();
            this.groupBoxInPutData_PAO.ResumeLayout(false);
            this.groupBoxOutPutData_PAO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_PAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_PAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PAO;
        private System.Windows.Forms.Button buttonHelp_PAO;
        private System.Windows.Forms.Button buttonSaveFile_PAO;
        private System.Windows.Forms.Button buttonDone_PAO;
        private System.Windows.Forms.Button buttonOpenFile_PAO;
        private System.Windows.Forms.GroupBox groupBoxCondition_PAO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLeft_PAO;
        private System.Windows.Forms.GroupBox groupBoxInPutData_PAO;
        private System.Windows.Forms.Panel panelFill_PAO;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_PAO;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_PAO;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_PAO;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask7_PAO;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_PAO;
        private System.Windows.Forms.ToolTip toolTipButton_PAO;
    }
}

