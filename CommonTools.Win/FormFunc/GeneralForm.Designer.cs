namespace CommonTools.Win.FormFunc
{
    partial class GeneralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabCustomId = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cobSelectOrderBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.PicSubmitCustomId = new System.Windows.Forms.PictureBox();
            this.TxtGuid2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtGuid1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtResult = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDateTime = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabCustomId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobSelectOrderBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitCustomId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGuid2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGuid1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.Location = new System.Drawing.Point(1092, 10);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 3;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 31);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabCustomId;
            this.xtraTabControl1.Size = new System.Drawing.Size(1160, 611);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabCustomId});
            // 
            // TabCustomId
            // 
            this.TabCustomId.Controls.Add(this.labelControl3);
            this.TabCustomId.Controls.Add(this.cobSelectOrderBy);
            this.TabCustomId.Controls.Add(this.labelControl1);
            this.TabCustomId.Controls.Add(this.labelControl5);
            this.TabCustomId.Controls.Add(this.PicSubmitCustomId);
            this.TabCustomId.Controls.Add(this.TxtGuid2);
            this.TabCustomId.Controls.Add(this.labelControl7);
            this.TabCustomId.Controls.Add(this.TxtGuid1);
            this.TabCustomId.Controls.Add(this.labelControl6);
            this.TabCustomId.Controls.Add(this.TxtResult);
            this.TabCustomId.Controls.Add(this.labelControl4);
            this.TabCustomId.Controls.Add(this.TxtDateTime);
            this.TabCustomId.Controls.Add(this.labelControl2);
            this.TabCustomId.Name = "TabCustomId";
            this.TabCustomId.Size = new System.Drawing.Size(1154, 582);
            this.TabCustomId.Text = "自定义主键";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(400, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(234, 24);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "默认使用yyyyMMddhhmmssfffffff";
            // 
            // cobSelectOrderBy
            // 
            this.cobSelectOrderBy.EditValue = "===请选择生成顺序===";
            this.cobSelectOrderBy.Location = new System.Drawing.Point(174, 215);
            this.cobSelectOrderBy.Name = "cobSelectOrderBy";
            this.cobSelectOrderBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cobSelectOrderBy.Properties.Items.AddRange(new object[] {
            "日期+Guid",
            "Guid+日期"});
            this.cobSelectOrderBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cobSelectOrderBy.Size = new System.Drawing.Size(170, 20);
            this.cobSelectOrderBy.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(79, 211);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 24);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "选择顺序:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(940, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(124, 24);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "最高32位";
            // 
            // PicSubmitCustomId
            // 
            this.PicSubmitCustomId.BackColor = System.Drawing.Color.Transparent;
            this.PicSubmitCustomId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSubmitCustomId.Image = global::CommonTools.Win.Properties.Resources.google_up;
            this.PicSubmitCustomId.Location = new System.Drawing.Point(500, 441);
            this.PicSubmitCustomId.Name = "PicSubmitCustomId";
            this.PicSubmitCustomId.Size = new System.Drawing.Size(64, 64);
            this.PicSubmitCustomId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSubmitCustomId.TabIndex = 12;
            this.PicSubmitCustomId.TabStop = false;
            this.PicSubmitCustomId.Click += new System.EventHandler(this.PicSubmitCustomId_Click);
            // 
            // TxtGuid2
            // 
            this.TxtGuid2.EditValue = "32";
            this.TxtGuid2.Location = new System.Drawing.Point(863, 105);
            this.TxtGuid2.Name = "TxtGuid2";
            this.TxtGuid2.Size = new System.Drawing.Size(60, 20);
            this.TxtGuid2.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(830, 108);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 20);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "~";
            this.labelControl7.UseMnemonic = false;
            // 
            // TxtGuid1
            // 
            this.TxtGuid1.EditValue = "0";
            this.TxtGuid1.Location = new System.Drawing.Point(751, 104);
            this.TxtGuid1.Name = "TxtGuid1";
            this.TxtGuid1.Size = new System.Drawing.Size(60, 20);
            this.TxtGuid1.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(656, 101);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 24);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Guid长度:";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(134, 340);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(930, 20);
            this.TxtResult.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(79, 337);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 24);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "结果:";
            // 
            // TxtDateTime
            // 
            this.TxtDateTime.EditValue = "yyyyMMddhhmmssfffffff";
            this.TxtDateTime.Location = new System.Drawing.Point(174, 104);
            this.TxtDateTime.Name = "TxtDateTime";
            this.TxtDateTime.Size = new System.Drawing.Size(216, 20);
            this.TxtDateTime.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(79, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "日期样式:";
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基本功能";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneralForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabCustomId.ResumeLayout(false);
            this.TabCustomId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobSelectOrderBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitCustomId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGuid2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGuid1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTime.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabCustomId;
        private System.Windows.Forms.PictureBox PicSubmitCustomId;
        private DevExpress.XtraEditors.TextEdit TxtGuid2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtGuid1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtResult;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtDateTime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cobSelectOrderBy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}