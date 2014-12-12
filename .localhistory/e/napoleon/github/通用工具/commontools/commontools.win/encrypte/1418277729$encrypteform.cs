
using System.Drawing;
using System.Windows.Forms;
using CommonTools.Common;
using CommonTools.Win.Properties;

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
            Application.Exit();
        }

        /// <summary>
        ///  返回按钮
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 15:47:26
        private void BtnReturn_Click(object sender, System.EventArgs e)
        {
            StartForm start = new StartForm();
            Hide();
            start.Show();
        }

        #region 按钮效果

        /// <summary>
        ///  按下事件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 13:44:01
        private void PicSubmitMd5_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            ChangePicboxImage(Resources.google_down, pictureBox);
        }

        /// <summary>
        ///  释放事件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 13:44:58
        private void PicSubmitMd5_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            ChangePicboxImage(Resources.google_up, pictureBox);
        }

        /// <summary>
        ///  改变控件的背景图片
        /// </summary>
        /// <param name="image">图片资源</param>
        /// <param name="pictureBox">控件</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 14:24:49
        private void ChangePicboxImage(Image image, PictureBox pictureBox)
        {
            pictureBox.Image = image;
            pictureBox.Refresh();
        }

        #endregion

        /// <summary>
        ///  MD5加密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 11:05:50
        private void PicSubmitMd5_Click(object sender, System.EventArgs e)
        {
            string plaintext = TxtPlaintext.Text.Trim();
            int txtnumber = TxtNumber.Text.Trim().ConvertToInt();
            int ciphertext1 = TxtCiphertext1.Text.Trim().ConvertToInt();
            int ciphertext2 = TxtCiphertext2.Text.Trim().ConvertToInt();
            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("请填写明文！");
                return;
            }
            if (txtnumber == -2 || ciphertext1 == -2 || ciphertext2 == -2)
            {
                MessageBox.Show("请正确填写数字！");
                return;
            }
            if (txtnumber < PublicFields.Md5Number)
            {
                MessageBox.Show(string.Format("次数必须是大于等于{0}的整数！", PublicFields.Md5Number));
                return;
            }
            if (ciphertext1 < PublicFields.Md5StartNumber || ciphertext1 > PublicFields.Md5EndNumber || ciphertext2 <= PublicFields.Md5StartNumber ||
                ciphertext2 > PublicFields.Md5EndNumber)
            {
                MessageBox.Show(string.Format("密文长度必须在{0}~{1}范围内!", PublicFields.Md5StartNumber, PublicFields.Md5EndNumber));
                return;
            }
            //循环加密
            for (int i = 0; i < txtnumber; i++)
            {
                plaintext = plaintext.GetMd5();
            }
            //获取指定的长度密文
            TxtCiphertext.Text = plaintext.SubstringValue(ciphertext1, ciphertext2 - ciphertext1);
        }

        /// <summary>
        ///  SHA1加密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:18:38
        private void PicSubmitSha_Click(object sender, System.EventArgs e)
        {
            string plaintext = TxtSha1Plaintext.Text.Trim();
            int txtnumber = TxtSha1Number.Text.Trim().ConvertToInt();
            int ciphertext1 = TxtSha1Ciphertext1.Text.Trim().ConvertToInt();
            int ciphertext2 = TxtSha1Ciphertext2.Text.Trim().ConvertToInt();
            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("请填写明文！");
                return;
            }
            if (txtnumber == -2 || ciphertext1 == -2 || ciphertext2 == -2)
            {
                MessageBox.Show("请正确填写数字！");
                return;
            }
            if (txtnumber < PublicFields.Sha1Number)
            {
                MessageBox.Show(string.Format("次数必须是大于等于{0}的整数！", PublicFields.Sha1Number));
                return;
            }
            if (ciphertext1 < PublicFields.Sha1StartNumber || ciphertext1 > PublicFields.Sha1EndNumber || ciphertext2 <= PublicFields.Sha1StartNumber ||
                ciphertext2 > PublicFields.Sha1EndNumber)
            {
                MessageBox.Show(string.Format("密文长度必须在{0}~{1}范围内!", PublicFields.Sha1StartNumber, PublicFields.Sha1EndNumber));
                return;
            }
            //循环加密
            for (int i = 0; i < txtnumber; i++)
            {
                plaintext = plaintext.GetSha1();
            }
            //获取指定的长度密文
            TxtSha1Ciphertext.Text = plaintext.SubstringValue(ciphertext1, ciphertext2 - ciphertext1);
        }

        /// <summary>
        ///  组合键
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:50:10
        private void EncrypteForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.Modifiers == ((int)Keys.Control + (int)Keys.Alt + (int)Keys.Shift))
            {
                string name = xtraTabControl1.SelectedTabPage.Name;
                switch (name)
                {
                    case "TabMD5"
                }
            }
        }



    }
}
