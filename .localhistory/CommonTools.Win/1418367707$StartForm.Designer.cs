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
            this.PicEncrypte = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CommonTools.Win.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.PicEncrypte)).BeginInit();
            this.SuspendLayout();
            // 
            // PicEncrypte
            // 
            this.PicEncrypte.BackColor = System.Drawing.Color.Transparent;
            this.PicEncrypte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEncrypte.Image = ((System.Drawing.Image)(resources.GetObject("PicEncrypte.Image")));
            this.PicEncrypte.Location = new System.Drawing.Point(42, 34);
            this.PicEncrypte.Name = "PicEncrypte";
            this.PicEncrypte.Size = new System.Drawing.Size(128, 128);
            this.PicEncrypte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicEncrypte.TabIndex = 0;
            this.PicEncrypte.TabStop = false;
            this.PicEncrypte.Click += new System.EventHandler(this.PicEncrypte_Click);
            this.PicEncrypte.MouseEnter += new System.EventHandler(this.PicEncrypte_MouseEnter);
            this.PicEncrypte.MouseLeave += new System.EventHandler(this.PicEncrypte_MouseLeave);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(74, 170);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "加/解密";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PicEncrypte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通用工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PicEncrypte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicEncrypte;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;






    }
}