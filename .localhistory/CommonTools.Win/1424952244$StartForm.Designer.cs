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
            this.LoadingForm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CommonTools.Win.WaitForm1), true, true);
            this.PicEncrypte = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PicBase = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PicEncrypte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBase)).BeginInit();
            this.SuspendLayout();
            // 
            // PicEncrypte
            // 
            this.PicEncrypte.BackColor = System.Drawing.Color.Transparent;
            this.PicEncrypte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEncrypte.Image = ((System.Drawing.Image)(resources.GetObject("PicEncrypte.Image")));
            this.PicEncrypte.Location = new System.Drawing.Point(374, 34);
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
            this.labelControl1.Location = new System.Drawing.Point(92, 168);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "基 础";
            // 
            // PicBase
            // 
            this.PicBase.BackColor = System.Drawing.Color.Transparent;
            this.PicBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBase.Image = ((System.Drawing.Image)(resources.GetObject("PicBase.Image")));
            this.PicBase.Location = new System.Drawing.Point(50, 34);
            this.PicBase.Name = "PicBase";
            this.PicBase.Size = new System.Drawing.Size(128, 128);
            this.PicBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBase.TabIndex = 2;
            this.PicBase.TabStop = false;
            this.PicBase.Click += new System.EventHandler(this.PicEncrypte_Click);
            this.PicBase.MouseEnter += new System.EventHandler(this.PicEncrypte_MouseEnter);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(407, 168);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "加/解密";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.PicBase);
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
            ((System.ComponentModel.ISupportInitialize)(this.PicBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicEncrypte;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox PicBase;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraSplashScreen.SplashScreenManager LoadingForm;






    }
}