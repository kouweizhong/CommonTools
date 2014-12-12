namespace CommonTools.Win
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.PicEncrype = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicEncrype)).BeginInit();
            this.SuspendLayout();
            // 
            // PicEncrype
            // 
            this.PicEncrype.BackColor = System.Drawing.Color.White;
            this.PicEncrype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicEncrype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEncrype.Image = ((System.Drawing.Image)(resources.GetObject("PicEncrype.Image")));
            this.PicEncrype.Location = new System.Drawing.Point(70, 114);
            this.PicEncrype.Name = "PicEncrype";
            this.PicEncrype.Size = new System.Drawing.Size(68, 68);
            this.PicEncrype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicEncrype.TabIndex = 0;
            this.PicEncrype.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.PicEncrype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通用工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PicEncrype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicEncrype;






    }
}