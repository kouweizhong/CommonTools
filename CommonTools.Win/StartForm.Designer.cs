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
            this.PicCode = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PicGeneral = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PicEncrypte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // PicEncrypte
            // 
            this.PicEncrypte.BackColor = System.Drawing.Color.Transparent;
            this.PicEncrypte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEncrypte.Image = ((System.Drawing.Image)(resources.GetObject("PicEncrypte.Image")));
            this.PicEncrypte.Location = new System.Drawing.Point(650, 30);
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
            this.labelControl1.Location = new System.Drawing.Point(384, 164);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "编/解码";
            // 
            // PicCode
            // 
            this.PicCode.BackColor = System.Drawing.Color.Transparent;
            this.PicCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicCode.Image = ((System.Drawing.Image)(resources.GetObject("PicCode.Image")));
            this.PicCode.Location = new System.Drawing.Point(350, 30);
            this.PicCode.Name = "PicCode";
            this.PicCode.Size = new System.Drawing.Size(128, 128);
            this.PicCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicCode.TabIndex = 2;
            this.PicCode.TabStop = false;
            this.PicCode.Click += new System.EventHandler(this.PicBase_Click);
            this.PicCode.MouseEnter += new System.EventHandler(this.PicEncrypte_MouseEnter);
            this.PicCode.MouseLeave += new System.EventHandler(this.PicEncrypte_MouseLeave);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(689, 164);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "加/解密";
            // 
            // PicGeneral
            // 
            this.PicGeneral.BackColor = System.Drawing.Color.Transparent;
            this.PicGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicGeneral.Image = ((System.Drawing.Image)(resources.GetObject("PicGeneral.Image")));
            this.PicGeneral.Location = new System.Drawing.Point(50, 30);
            this.PicGeneral.Name = "PicGeneral";
            this.PicGeneral.Size = new System.Drawing.Size(128, 128);
            this.PicGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicGeneral.TabIndex = 5;
            this.PicGeneral.TabStop = false;
            this.PicGeneral.Click += new System.EventHandler(this.PicGeneral_Click);
            this.PicGeneral.MouseEnter += new System.EventHandler(this.PicEncrypte_MouseEnter);
            this.PicGeneral.MouseLeave += new System.EventHandler(this.PicEncrypte_MouseLeave);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(83, 165);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "基本功能";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.PicGeneral);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.PicCode);
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
            ((System.ComponentModel.ISupportInitialize)(this.PicCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicEncrypte;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox PicCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox PicGeneral;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraSplashScreen.SplashScreenManager LoadingForm;






    }
}