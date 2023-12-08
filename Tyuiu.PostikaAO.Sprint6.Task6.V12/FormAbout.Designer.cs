
namespace Tyuiu.PostikaAO.Sprint6.Task6.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_PAO = new System.Windows.Forms.Label();
            this.buttonOK_PAO = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_PAO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_PAO
            // 
            this.labelInfo_PAO.AutoSize = true;
            this.labelInfo_PAO.Location = new System.Drawing.Point(180, 24);
            this.labelInfo_PAO.Name = "labelInfo_PAO";
            this.labelInfo_PAO.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_PAO.TabIndex = 1;
            this.labelInfo_PAO.Text = resources.GetString("labelInfo_PAO.Text");
            // 
            // buttonOK_PAO
            // 
            this.buttonOK_PAO.Location = new System.Drawing.Point(447, 197);
            this.buttonOK_PAO.Name = "buttonOK_PAO";
            this.buttonOK_PAO.Size = new System.Drawing.Size(108, 33);
            this.buttonOK_PAO.TabIndex = 2;
            this.buttonOK_PAO.Text = "OK";
            this.buttonOK_PAO.UseVisualStyleBackColor = true;
            this.buttonOK_PAO.Click += new System.EventHandler(this.buttonOK_PAO_Click);
            // 
            // pictureBoxAvatar_PAO
            // 
            this.pictureBoxAvatar_PAO.Image = global::Tyuiu.PostikaAO.Sprint6.Task6.V12.Properties.Resources.pngwing_com;
            this.pictureBoxAvatar_PAO.Location = new System.Drawing.Point(12, 24);
            this.pictureBoxAvatar_PAO.Name = "pictureBoxAvatar_PAO";
            this.pictureBoxAvatar_PAO.Size = new System.Drawing.Size(162, 182);
            this.pictureBoxAvatar_PAO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PAO.TabIndex = 0;
            this.pictureBoxAvatar_PAO.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 242);
            this.Controls.Add(this.buttonOK_PAO);
            this.Controls.Add(this.labelInfo_PAO);
            this.Controls.Add(this.pictureBoxAvatar_PAO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_PAO;
        private System.Windows.Forms.Label labelInfo_PAO;
        private System.Windows.Forms.Button buttonOK_PAO;
    }
}