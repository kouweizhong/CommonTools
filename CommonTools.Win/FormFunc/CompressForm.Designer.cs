namespace CommonTools.Win.FormFunc
{
    partial class CompressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompressForm));
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.TxtImport = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnImport = new DevExpress.XtraEditors.SimpleButton();
            this.BtnExport = new DevExpress.XtraEditors.SimpleButton();
            this.TxtExport = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ChkConfused = new DevExpress.XtraEditors.CheckEdit();
            this.ChkSemicolon = new DevExpress.XtraEditors.CheckEdit();
            this.ChkOptimization = new DevExpress.XtraEditors.CheckEdit();
            this.ChkRename = new DevExpress.XtraEditors.CheckEdit();
            this.ChkRetain = new DevExpress.XtraEditors.CheckEdit();
            this.toolStripStatus = new System.Windows.Forms.StatusStrip();
            this.FileTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CobFileType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CobFileCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnCompress = new DevExpress.XtraEditors.SimpleButton();
            this.loading = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CommonTools.Win.WaitForm1), true, true);
            this.RchExport = new System.Windows.Forms.RichTextBox();
            this.RchImport = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtExport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkConfused.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkSemicolon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkOptimization.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRetain.Properties)).BeginInit();
            this.toolStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobFileType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobFileCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.Location = new System.Drawing.Point(1076, 19);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 3;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // TxtImport
            // 
            this.TxtImport.EditValue = "";
            this.TxtImport.Location = new System.Drawing.Point(215, 55);
            this.TxtImport.Name = "TxtImport";
            this.TxtImport.Properties.ReadOnly = true;
            this.TxtImport.Size = new System.Drawing.Size(700, 20);
            this.TxtImport.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(113, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 22);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "输入路径：";
            this.labelControl4.UseMnemonic = false;
            // 
            // BtnImport
            // 
            this.BtnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImport.Location = new System.Drawing.Point(983, 52);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(75, 23);
            this.BtnImport.TabIndex = 24;
            this.BtnImport.Text = "选择";
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExport.Location = new System.Drawing.Point(983, 82);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 27;
            this.BtnExport.Text = "选择";
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // TxtExport
            // 
            this.TxtExport.EditValue = "";
            this.TxtExport.Location = new System.Drawing.Point(215, 85);
            this.TxtExport.Name = "TxtExport";
            this.TxtExport.Properties.ReadOnly = true;
            this.TxtExport.Size = new System.Drawing.Size(700, 20);
            this.TxtExport.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(113, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 22);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "输出路径：";
            this.labelControl1.UseMnemonic = false;
            // 
            // ChkConfused
            // 
            this.ChkConfused.Location = new System.Drawing.Point(173, 115);
            this.ChkConfused.Name = "ChkConfused";
            this.ChkConfused.Properties.Caption = "是否混淆(js有效)";
            this.ChkConfused.Size = new System.Drawing.Size(118, 19);
            this.ChkConfused.TabIndex = 29;
            // 
            // ChkSemicolon
            // 
            this.ChkSemicolon.Location = new System.Drawing.Point(461, 115);
            this.ChkSemicolon.Name = "ChkSemicolon";
            this.ChkSemicolon.Properties.Caption = "是否去分号(js有效)";
            this.ChkSemicolon.Size = new System.Drawing.Size(133, 19);
            this.ChkSemicolon.TabIndex = 30;
            // 
            // ChkOptimization
            // 
            this.ChkOptimization.Location = new System.Drawing.Point(769, 115);
            this.ChkOptimization.Name = "ChkOptimization";
            this.ChkOptimization.Properties.Caption = "是否优化脚本(js有效)";
            this.ChkOptimization.Size = new System.Drawing.Size(146, 19);
            this.ChkOptimization.TabIndex = 31;
            // 
            // ChkRename
            // 
            this.ChkRename.Location = new System.Drawing.Point(173, 149);
            this.ChkRename.Name = "ChkRename";
            this.ChkRename.Properties.Caption = "是否重命名(_main)";
            this.ChkRename.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ChkRename.Properties.RadioGroupIndex = 1;
            this.ChkRename.Size = new System.Drawing.Size(132, 19);
            this.ChkRename.TabIndex = 32;
            // 
            // ChkRetain
            // 
            this.ChkRetain.Location = new System.Drawing.Point(461, 149);
            this.ChkRetain.Name = "ChkRetain";
            this.ChkRetain.Properties.Caption = "是否原地保存";
            this.ChkRetain.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ChkRetain.Properties.RadioGroupIndex = 1;
            this.ChkRetain.Size = new System.Drawing.Size(138, 19);
            this.ChkRetain.TabIndex = 33;
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTotal});
            this.toolStripStatus.Location = new System.Drawing.Point(0, 636);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(1184, 26);
            this.toolStripStatus.TabIndex = 36;
            this.toolStripStatus.Text = "statusStrip1";
            // 
            // FileTotal
            // 
            this.FileTotal.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.FileTotal.Name = "FileTotal";
            this.FileTotal.Size = new System.Drawing.Size(79, 21);
            this.FileTotal.Text = "文件总数：0";
            this.FileTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CobFileType
            // 
            this.CobFileType.EditValue = "所有文件";
            this.CobFileType.Location = new System.Drawing.Point(215, 195);
            this.CobFileType.Name = "CobFileType";
            this.CobFileType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CobFileType.Properties.Items.AddRange(new object[] {
            "所有文件",
            "JS文件",
            "CSS文件"});
            this.CobFileType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CobFileType.Size = new System.Drawing.Size(154, 20);
            this.CobFileType.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(113, 193);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 22);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "文件类型：";
            this.labelControl2.UseMnemonic = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(498, 193);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 22);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "文件编码：";
            this.labelControl3.UseMnemonic = false;
            // 
            // CobFileCode
            // 
            this.CobFileCode.EditValue = "UTF-8";
            this.CobFileCode.Location = new System.Drawing.Point(600, 195);
            this.CobFileCode.Name = "CobFileCode";
            this.CobFileCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CobFileCode.Properties.Items.AddRange(new object[] {
            "UTF-8",
            "GB18030"});
            this.CobFileCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CobFileCode.Size = new System.Drawing.Size(154, 20);
            this.CobFileCode.TabIndex = 40;
            // 
            // BtnCompress
            // 
            this.BtnCompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompress.Location = new System.Drawing.Point(983, 135);
            this.BtnCompress.Name = "BtnCompress";
            this.BtnCompress.Size = new System.Drawing.Size(75, 47);
            this.BtnCompress.TabIndex = 41;
            this.BtnCompress.Text = "开始压缩";
            this.BtnCompress.Click += new System.EventHandler(this.BtnCompress_Click);
            // 
            // RchExport
            // 
            this.RchExport.Location = new System.Drawing.Point(0, 434);
            this.RchExport.Name = "RchExport";
            this.RchExport.Size = new System.Drawing.Size(1184, 199);
            this.RchExport.TabIndex = 42;
            this.RchExport.Text = "";
            // 
            // RchImport
            // 
            this.RchImport.Location = new System.Drawing.Point(0, 232);
            this.RchImport.Name = "RchImport";
            this.RchImport.Size = new System.Drawing.Size(1184, 196);
            this.RchImport.TabIndex = 43;
            this.RchImport.Text = "";
            // 
            // CompressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.RchImport);
            this.Controls.Add(this.RchExport);
            this.Controls.Add(this.BtnCompress);
            this.Controls.Add(this.CobFileCode);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.CobFileType);
            this.Controls.Add(this.toolStripStatus);
            this.Controls.Add(this.ChkRetain);
            this.Controls.Add(this.ChkRename);
            this.Controls.Add(this.ChkOptimization);
            this.Controls.Add(this.ChkSemicolon);
            this.Controls.Add(this.ChkConfused);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.TxtExport);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.TxtImport);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.BtnReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "压缩/打包";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompressForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TxtImport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtExport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkConfused.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkSemicolon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkOptimization.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRetain.Properties)).EndInit();
            this.toolStripStatus.ResumeLayout(false);
            this.toolStripStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobFileType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobFileCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraEditors.TextEdit TxtImport;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnImport;
        private DevExpress.XtraEditors.SimpleButton BtnExport;
        private DevExpress.XtraEditors.TextEdit TxtExport;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ChkConfused;
        private DevExpress.XtraEditors.CheckEdit ChkSemicolon;
        private DevExpress.XtraEditors.CheckEdit ChkOptimization;
        private DevExpress.XtraEditors.CheckEdit ChkRename;
        private DevExpress.XtraEditors.CheckEdit ChkRetain;
        private System.Windows.Forms.StatusStrip toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel FileTotal;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private DevExpress.XtraEditors.ComboBoxEdit CobFileType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit CobFileCode;
        private DevExpress.XtraEditors.SimpleButton BtnCompress;
        private System.Windows.Forms.RichTextBox RchExport;
        private System.Windows.Forms.RichTextBox RchImport;
        private DevExpress.XtraSplashScreen.SplashScreenManager loading;
    }
}