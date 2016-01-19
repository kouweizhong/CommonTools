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
            this.XtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
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
            this.TabForms = new DevExpress.XtraTab.XtraTabPage();
            this.cobSelectColor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtFormText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFormDesp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFormAttaUrl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFormTitle = new DevExpress.XtraEditors.TextEdit();
            this.PicSubmitForm = new System.Windows.Forms.PictureBox();
            this.LblFormJson = new DevExpress.XtraEditors.LabelControl();
            this.TxtFormUrl = new DevExpress.XtraEditors.TextEdit();
            this.LblFormUrl = new DevExpress.XtraEditors.LabelControl();
            this.LoadingMsg = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CommonTools.Win.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).BeginInit();
            this.XtraTabControl1.SuspendLayout();
            this.TabCustomId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobSelectOrderBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitCustomId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGuid2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGuid1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTime.Properties)).BeginInit();
            this.TabForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobSelectColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormDesp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormAttaUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormUrl.Properties)).BeginInit();
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
            // XtraTabControl1
            // 
            this.XtraTabControl1.Location = new System.Drawing.Point(12, 31);
            this.XtraTabControl1.Name = "XtraTabControl1";
            this.XtraTabControl1.SelectedTabPage = this.TabCustomId;
            this.XtraTabControl1.Size = new System.Drawing.Size(1160, 611);
            this.XtraTabControl1.TabIndex = 2;
            this.XtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabCustomId,
            this.TabForms});
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
            this.PicSubmitCustomId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicSubmitMd5_MouseDown);
            this.PicSubmitCustomId.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicSubmitMd5_MouseUp);
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
            // TabForms
            // 
            this.TabForms.Controls.Add(this.cobSelectColor);
            this.TabForms.Controls.Add(this.TxtFormText);
            this.TabForms.Controls.Add(this.labelControl11);
            this.TabForms.Controls.Add(this.labelControl10);
            this.TabForms.Controls.Add(this.TxtFormDesp);
            this.TabForms.Controls.Add(this.labelControl9);
            this.TabForms.Controls.Add(this.TxtFormAttaUrl);
            this.TabForms.Controls.Add(this.labelControl8);
            this.TabForms.Controls.Add(this.TxtFormTitle);
            this.TabForms.Controls.Add(this.PicSubmitForm);
            this.TabForms.Controls.Add(this.LblFormJson);
            this.TabForms.Controls.Add(this.TxtFormUrl);
            this.TabForms.Controls.Add(this.LblFormUrl);
            this.TabForms.Name = "TabForms";
            this.TabForms.Size = new System.Drawing.Size(1154, 582);
            this.TabForms.Text = "瀑布IM推送";
            // 
            // cobSelectColor
            // 
            this.cobSelectColor.EditValue = "=====请选择颜色=====";
            this.cobSelectColor.Location = new System.Drawing.Point(752, 184);
            this.cobSelectColor.Name = "cobSelectColor";
            this.cobSelectColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cobSelectColor.Properties.Items.AddRange(new object[] {
            "warning",
            "info",
            "primary",
            "error",
            "muted",
            "success"});
            this.cobSelectColor.Properties.ReadOnly = true;
            this.cobSelectColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cobSelectColor.Size = new System.Drawing.Size(175, 20);
            this.cobSelectColor.TabIndex = 85;
            // 
            // TxtFormText
            // 
            this.TxtFormText.EditValue = "";
            this.TxtFormText.Location = new System.Drawing.Point(127, 118);
            this.TxtFormText.Name = "TxtFormText";
            this.TxtFormText.Size = new System.Drawing.Size(948, 20);
            this.TxtFormText.TabIndex = 84;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(69, 114);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(40, 24);
            this.labelControl11.TabIndex = 83;
            this.labelControl11.Text = "文本:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(666, 180);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 24);
            this.labelControl10.TabIndex = 81;
            this.labelControl10.Text = "颜色:";
            // 
            // TxtFormDesp
            // 
            this.TxtFormDesp.EditValue = "";
            this.TxtFormDesp.Location = new System.Drawing.Point(127, 334);
            this.TxtFormDesp.Name = "TxtFormDesp";
            this.TxtFormDesp.Properties.ReadOnly = true;
            this.TxtFormDesp.Size = new System.Drawing.Size(948, 20);
            this.TxtFormDesp.TabIndex = 80;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(69, 330);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 24);
            this.labelControl9.TabIndex = 79;
            this.labelControl9.Text = "描述:";
            // 
            // TxtFormAttaUrl
            // 
            this.TxtFormAttaUrl.EditValue = "";
            this.TxtFormAttaUrl.Location = new System.Drawing.Point(127, 256);
            this.TxtFormAttaUrl.Name = "TxtFormAttaUrl";
            this.TxtFormAttaUrl.Properties.ReadOnly = true;
            this.TxtFormAttaUrl.Size = new System.Drawing.Size(948, 20);
            this.TxtFormAttaUrl.TabIndex = 78;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(69, 252);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 24);
            this.labelControl8.TabIndex = 77;
            this.labelControl8.Text = "链接:";
            // 
            // TxtFormTitle
            // 
            this.TxtFormTitle.EditValue = "";
            this.TxtFormTitle.Location = new System.Drawing.Point(127, 184);
            this.TxtFormTitle.Name = "TxtFormTitle";
            this.TxtFormTitle.Properties.ReadOnly = true;
            this.TxtFormTitle.Size = new System.Drawing.Size(351, 20);
            this.TxtFormTitle.TabIndex = 76;
            // 
            // PicSubmitForm
            // 
            this.PicSubmitForm.BackColor = System.Drawing.Color.Transparent;
            this.PicSubmitForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSubmitForm.Image = global::CommonTools.Win.Properties.Resources.google_up;
            this.PicSubmitForm.Location = new System.Drawing.Point(500, 441);
            this.PicSubmitForm.Name = "PicSubmitForm";
            this.PicSubmitForm.Size = new System.Drawing.Size(64, 64);
            this.PicSubmitForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSubmitForm.TabIndex = 75;
            this.PicSubmitForm.TabStop = false;
            this.PicSubmitForm.Click += new System.EventHandler(this.PicSubmitForm_Click);
            this.PicSubmitForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicSubmitMd5_MouseDown);
            this.PicSubmitForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicSubmitMd5_MouseUp);
            // 
            // LblFormJson
            // 
            this.LblFormJson.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.LblFormJson.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblFormJson.Location = new System.Drawing.Point(69, 180);
            this.LblFormJson.Name = "LblFormJson";
            this.LblFormJson.Size = new System.Drawing.Size(52, 24);
            this.LblFormJson.TabIndex = 73;
            this.LblFormJson.Text = "标题:";
            // 
            // TxtFormUrl
            // 
            this.TxtFormUrl.EditValue = "https://hooks.pubu.im/services/w3p3m129r33nu9q";
            this.TxtFormUrl.Location = new System.Drawing.Point(127, 45);
            this.TxtFormUrl.Name = "TxtFormUrl";
            this.TxtFormUrl.Size = new System.Drawing.Size(948, 20);
            this.TxtFormUrl.TabIndex = 5;
            // 
            // LblFormUrl
            // 
            this.LblFormUrl.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.LblFormUrl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblFormUrl.Location = new System.Drawing.Point(69, 42);
            this.LblFormUrl.Name = "LblFormUrl";
            this.LblFormUrl.Size = new System.Drawing.Size(40, 24);
            this.LblFormUrl.TabIndex = 4;
            this.LblFormUrl.Text = "地址:";
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.XtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基本功能";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneralForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).EndInit();
            this.XtraTabControl1.ResumeLayout(false);
            this.TabCustomId.ResumeLayout(false);
            this.TabCustomId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobSelectOrderBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitCustomId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGuid2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGuid1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTime.Properties)).EndInit();
            this.TabForms.ResumeLayout(false);
            this.TabForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobSelectColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormDesp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormAttaUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSubmitForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormUrl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraTab.XtraTabControl XtraTabControl1;
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
        private DevExpress.XtraTab.XtraTabPage TabForms;
        private DevExpress.XtraEditors.TextEdit TxtFormUrl;
        private DevExpress.XtraEditors.LabelControl LblFormUrl;
        private DevExpress.XtraEditors.LabelControl LblFormJson;
        private System.Windows.Forms.PictureBox PicSubmitForm;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TxtFormDesp;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit TxtFormAttaUrl;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtFormTitle;
        private DevExpress.XtraEditors.TextEdit TxtFormText;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit cobSelectColor;
        private DevExpress.XtraSplashScreen.SplashScreenManager LoadingMsg;
    }
}