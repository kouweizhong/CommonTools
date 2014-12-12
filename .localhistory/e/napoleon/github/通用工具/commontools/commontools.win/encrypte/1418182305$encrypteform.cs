
using System.Windows.Forms;
using CommonTools.Common;
using DevExpress.Entity.ProjectModel;
using DevExpress.Utils.Menu;

namespace CommonTools.Win.Encrypte
{
    public partial class EncrypteForm : BaseForm
    {



        public EncrypteForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        private void EncrypteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm start = new StartForm();
            start.Show();
        }

        /// <summary>
        ///  MD5加密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 11:05:50
        private void PicSubmitMd5_Click(object sender, System.EventArgs e)
        {
            string plaintext = TxtPlaintext.Text.Trim();
            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("请填写明文！");
                return;
            }
            if (plaintext.ConvertToInt() == -2)
            {
                MessageBox.Show("正确填写数字！");
                return;
            }
        }



    }
}
