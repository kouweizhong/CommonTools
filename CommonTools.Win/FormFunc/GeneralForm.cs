
using System;
using System.Windows.Forms;
using CommonTools.Common;

namespace CommonTools.Win.FormFunc
{
    public partial class GeneralForm : BaseForm
    {



        public GeneralForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        /// <summary>
        ///  返回
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-25 14:33:15
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            Hide();
            start.Show();
        }

        /// <summary>
        ///  关闭页面
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-25 14:32:57
        private void GeneralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  生成自定义主键
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-25 15:07:01
        private void PicSubmitCustomId_Click(object sender, EventArgs e)
        {
            int guid1 = TxtGuid1.Text.ConvertToInt();
            int guid2 = TxtGuid2.Text.ConvertToInt();
            if (string.IsNullOrWhiteSpace(TxtDateTime.Text))
            {
                MessageBox.Show("请填写日期样式!");
                return;
            }
            if (guid1 == -2 || guid2 == -2 || guid1 > 32 || guid2 > 32)
            {
                MessageBox.Show("请填写Guid起始位置(0-32)!");
                return;
            }
            if (guid1 > guid2)
            {
                MessageBox.Show("Guid开始位置不能大于结束位置!");
                return;
            }
            if (cobSelectOrderBy.SelectedIndex == -1)
            {
                MessageBox.Show("请选择生成顺序!");
                return;
            }
            string datetime = DateTime.Now.ToString(TxtDateTime.Text);
            string guid = Guid.NewGuid().ToString().Replace("-", "").Substring(guid1, guid2 - guid1);
            switch (cobSelectOrderBy.SelectedIndex)
            {
                case 0://日期+Guid
                    TxtResult.Text = datetime + guid;
                    break;
                case 1://Guid+日期
                    TxtResult.Text = guid + datetime;
                    break;
            }
        }



    }
}
