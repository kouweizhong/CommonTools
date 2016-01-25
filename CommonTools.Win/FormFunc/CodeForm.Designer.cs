namespace CommonTools.Win.FormFunc
{
    partial class CodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeForm));
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.PicSubmitCode = new System.Windows.Forms.PictureBox();
            this.memoEncode = new DevExpress.XtraEditors.MemoEdit();
            this.memoDecode = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cobSelectCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.LblMd5Replaces = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEncode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDecode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobSelectCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.Location = new System.Drawing.Point(1076, 19);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 2;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // PicSubmitCode
            // 
            this.PicSubmitCode.BackColor = System.Drawing.Color.Transparent;
            this.PicSubmitCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSubmitCode.Image = global::CommonTools.Win.Properties.Resources.google_up;
            this.PicSubmitCode.Location = new System.Drawing.Point(531, 529);
            this.PicSubmitCode.Name = "PicSubmitCode";
            this.PicSubmitCode.Size = new System.Drawing.Size(64, 64);
            this.PicSubmitCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSubmitCode.TabIndex = 13;
            this.PicSubmitCode.TabStop = false;
            this.PicSubmitCode.Click += new System.EventHandler(this.PicSubmitCode_Click);
            this.PicSubmitCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicSubmitMd5_MouseDown);
            this.PicSubmitCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicSubmitMd5_MouseUp);
            // 
            // memoEncode
            // 
            this.memoEncode.Location = new System.Drawing.Point(146, 71);
            this.memoEncode.Name = "memoEncode";
            this.memoEncode.Size = new System.Drawing.Size(933, 96);
            this.memoEncode.TabIndex = 14;
            this.memoEncode.UseOptimizedRendering = true;
            // 
            // memoDecode
            // 
            this.memoDecode.Location = new System.Drawing.Point(146, 373);
            this.memoDecode.Name = "memoDecode";
            this.memoDecode.Size = new System.Drawing.Size(933, 96);
            this.memoDecode.TabIndex = 15;
            this.memoDecode.UseOptimizedRendering = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(51, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 94);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "编码";
            this.labelControl1.UseMnemonic = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(41, 375);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 94);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "解码";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(220, 221);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 94);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "编码方式";
            this.labelControl3.UseMnemonic = false;
            // 
            // cobSelectCode
            // 
            this.cobSelectCode.EditValue = "===请选择编码方式===";
            this.cobSelectCode.Location = new System.Drawing.Point(345, 259);
            this.cobSelectCode.Name = "cobSelectCode";
            this.cobSelectCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cobSelectCode.Properties.Items.AddRange(new object[] {
            "Default",
            "GBK",
            "GB2312",
            "GB18030",
            "UTF32",
            "UTF8",
            "UTF7",
            "ASCII",
            "Base64",
            "Unicode",
            "escape",
            "encodeURI",
            "encodeURIComponent"});
            this.cobSelectCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cobSelectCode.Size = new System.Drawing.Size(170, 20);
            this.cobSelectCode.TabIndex = 19;
            this.cobSelectCode.SelectedIndexChanged += new System.EventHandler(this.cobSelectCode_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(643, 221);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 94);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "编码次数";
            this.labelControl4.UseMnemonic = false;
            // 
            // txtNumber
            // 
            this.txtNumber.EditValue = "1";
            this.txtNumber.Location = new System.Drawing.Point(784, 259);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(106, 20);
            this.txtNumber.TabIndex = 21;
            // 
            // LblMd5Replaces
            // 
            this.LblMd5Replaces.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.LblMd5Replaces.Appearance.ForeColor = System.Drawing.Color.Red;
            this.LblMd5Replaces.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblMd5Replaces.Location = new System.Drawing.Point(521, 258);
            this.LblMd5Replaces.Name = "LblMd5Replaces";
            this.LblMd5Replaces.Size = new System.Drawing.Size(19, 24);
            this.LblMd5Replaces.TabIndex = 22;
            this.LblMd5Replaces.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(896, 258);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(110, 24);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "次数不要过多";
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.LblMd5Replaces);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cobSelectCode);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoDecode);
            this.Controls.Add(this.memoEncode);
            this.Controls.Add(this.PicSubmitCode);
            this.Controls.Add(this.BtnReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编/解码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEncode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDecode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobSelectCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private System.Windows.Forms.PictureBox PicSubmitCode;
        private DevExpress.XtraEditors.MemoEdit memoEncode;
        private DevExpress.XtraEditors.MemoEdit memoDecode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cobSelectCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl LblMd5Replaces;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}