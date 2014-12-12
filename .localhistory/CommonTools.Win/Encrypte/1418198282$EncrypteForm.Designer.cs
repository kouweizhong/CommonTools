namespace CommonTools.Win.Encrypte
{
    partial class EncrypteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncrypteForm));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabMd5 = new DevExpress.XtraTab.XtraTabPage();
            this.PicSubmitMd5 = new System.Windows.Forms.PictureBox();
            this.TxtCiphertext2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCiphertext1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCiphertext = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPlaintext = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabMd5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitMd5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCiphertext2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCiphertext1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCiphertext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlaintext.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 39);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabMd5;
            this.xtraTabControl1.Size = new System.Drawing.Size(1160, 611);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabMd5});
            // 
            // TabMd5
            // 
            this.TabMd5.Controls.Add(this.PicSubmitMd5);
            this.TabMd5.Controls.Add(this.TxtCiphertext2);
            this.TabMd5.Controls.Add(this.labelControl7);
            this.TabMd5.Controls.Add(this.labelControl5);
            this.TabMd5.Controls.Add(this.TxtCiphertext1);
            this.TabMd5.Controls.Add(this.labelControl6);
            this.TabMd5.Controls.Add(this.TxtCiphertext);
            this.TabMd5.Controls.Add(this.labelControl4);
            this.TabMd5.Controls.Add(this.labelControl3);
            this.TabMd5.Controls.Add(this.TxtNumber);
            this.TabMd5.Controls.Add(this.labelControl2);
            this.TabMd5.Controls.Add(this.TxtPlaintext);
            this.TabMd5.Controls.Add(this.labelControl1);
            this.TabMd5.Name = "TabMd5";
            this.TabMd5.Size = new System.Drawing.Size(1154, 582);
            this.TabMd5.Text = "MD5加密";
            // 
            // PicSubmitMd5
            // 
            this.PicSubmitMd5.BackColor = System.Drawing.Color.Transparent;
            this.PicSubmitMd5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSubmitMd5.Image = global::CommonTools.Win.Properties.Resources.google_up;
            this.PicSubmitMd5.Location = new System.Drawing.Point(466, 336);
            this.PicSubmitMd5.Name = "PicSubmitMd5";
            this.PicSubmitMd5.Size = new System.Drawing.Size(64, 64);
            this.PicSubmitMd5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSubmitMd5.TabIndex = 12;
            this.PicSubmitMd5.TabStop = false;
            this.PicSubmitMd5.Click += new System.EventHandler(this.PicSubmitMd5_Click);
            // 
            // TxtCiphertext2
            // 
            this.TxtCiphertext2.EditValue = "32";
            this.TxtCiphertext2.Location = new System.Drawing.Point(721, 122);
            this.TxtCiphertext2.Name = "TxtCiphertext2";
            this.TxtCiphertext2.Size = new System.Drawing.Size(93, 20);
            this.TxtCiphertext2.TabIndex = 11;
            this.TxtCiphertext2.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(674, 128);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 20);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "~";
            this.labelControl7.UseMnemonic = false;
            this.labelControl7.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(834, 117);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(230, 24);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "(最高为32位密文,只能填写数字)";
            this.labelControl5.Visible = false;
            // 
            // TxtCiphertext1
            // 
            this.TxtCiphertext1.EditValue = "0";
            this.TxtCiphertext1.Location = new System.Drawing.Point(549, 121);
            this.TxtCiphertext1.Name = "TxtCiphertext1";
            this.TxtCiphertext1.Size = new System.Drawing.Size(93, 20);
            this.TxtCiphertext1.TabIndex = 8;
            this.TxtCiphertext1.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(454, 118);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 24);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "密文长度:";
            this.labelControl6.Visible = false;
            // 
            // TxtCiphertext
            // 
            this.TxtCiphertext.Location = new System.Drawing.Point(134, 196);
            this.TxtCiphertext.Name = "TxtCiphertext";
            this.TxtCiphertext.Size = new System.Drawing.Size(930, 20);
            this.TxtCiphertext.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(79, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 24);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "密文:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(264, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "(默认加密1次)";
            this.labelControl3.Visible = false;
            // 
            // TxtNumber
            // 
            this.TxtNumber.EditValue = "1";
            this.TxtNumber.Location = new System.Drawing.Point(174, 121);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(64, 20);
            this.TxtNumber.TabIndex = 3;
            this.TxtNumber.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(79, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "加密次数:";
            this.labelControl2.Visible = false;
            // 
            // TxtPlaintext
            // 
            this.TxtPlaintext.Location = new System.Drawing.Point(134, 52);
            this.TxtPlaintext.Name = "TxtPlaintext";
            this.TxtPlaintext.Size = new System.Drawing.Size(930, 20);
            this.TxtPlaintext.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(79, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "明文:";
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(1092, 12);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 1;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // EncrypteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EncrypteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加/解密";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabMd5.ResumeLayout(false);
            this.TabMd5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitMd5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCiphertext2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCiphertext1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCiphertext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlaintext.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabMd5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtPlaintext;
        private DevExpress.XtraEditors.TextEdit TxtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtCiphertext;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtCiphertext1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtCiphertext2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.PictureBox PicSubmitMd5;
        private DevExpress.XtraEditors.SimpleButton BtnReturn;

    }
}