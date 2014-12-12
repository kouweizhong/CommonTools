
using System;
using System.Drawing;
using System.Windows.Forms;
using CommonTools.Win.Encrypte;

namespace CommonTools.Win
{
    public partial class StartForm : BaseForm
    {



        public StartForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  加解密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 09:19:54
        private void PicEncrypte_Click(object sender, EventArgs e)
        {
            EncrypteForm encrypte = new EncrypteForm();
            Hide();
            encrypte.ShowDialog();
        }

        


    }
}
