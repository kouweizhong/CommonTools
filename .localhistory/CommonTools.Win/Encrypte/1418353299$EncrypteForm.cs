
using System;
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
            LoadForm();
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

        /// <summary>
        ///  加载基本信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 14:11:55
        private void LoadForm()
        {

            #region MD5

            TxtNumber.Text = PublicFields.Md5Number.ToString("D");
            labelControl3.Text = string.Format("(默认加密{0}次)", PublicFields.Md5Number);
            TxtCiphertext1.Text = PublicFields.Md5StartNumber.ToString("D");
            TxtCiphertext2.Text = PublicFields.Md5EndNumber.ToString("D");
            labelControl5.Text = string.Format("(最高为{0}位密文,只能填写数字)", PublicFields.Md5EndNumber);

            #endregion

            #region SHA1

            TxtSha1Number.Text = PublicFields.Sha1Number.ToString("D");
            labelControl17.Text = string.Format("(默认加密{0}次)", PublicFields.Sha1Number);
            TxtSha1Ciphertext1.Text = PublicFields.Sha1StartNumber.ToString("D");
            TxtSha1Ciphertext2.Text = PublicFields.Sha1EndNumber.ToString("D");
            labelControl19.Text = string.Format("(最高为{0}位密文,只能填写数字)", PublicFields.Sha1EndNumber);

            #endregion

            #region DES

            TxtDesNumber.Text = PublicFields.DesNumber.ToString("D");
            labelControl12.Text = string.Format("(默认加/解密{0}次)", PublicFields.DesNumber);

            #endregion

            #region DES3

            TxtDes3Number.Text = PublicFields.Des3Number.ToString("D");
            labelControl35.Text = string.Format("(默认加/解密{0}次)", PublicFields.Des3Number);

            #endregion

            #region RC2

            TxtRc2Number.Text = PublicFields.Rc2Number.ToString("D");
            labelControl23.Text = string.Format("(默认加/解密{0}次)", PublicFields.Rc2Number);

            #endregion

            #region AES

            TxtAesNumber.Text = PublicFields.AesNumber.ToString("D");
            labelControl29.Text = string.Format("(默认加/解密{0}次)", PublicFields.AesNumber);

            #endregion

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
                    case "TabMd5":
                        LblMd5Replace.Visible = LblMd5Replaces.Visible = TxtMd5Replace.Visible = !LblMd5Replace.Visible;
                        break;
                    case "TabSha1":
                        LblSha1Replace.Visible = LblSha1Replaces.Visible = TxtSha1Replace.Visible = !LblSha1Replace.Visible;
                        break;
                }
            }
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
            //获取替换字符
            PublicFields.Md5Replace = TxtMd5Replace.Text.Trim();
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
            //获取替换字符
            PublicFields.Sha1Replace = TxtSha1Replace.Text.Trim();
            //循环加密
            for (int i = 0; i < txtnumber; i++)
            {
                plaintext = plaintext.GetSha1();
            }
            //获取指定的长度密文
            TxtSha1Ciphertext.Text = plaintext.SubstringValue(ciphertext1, ciphertext2 - ciphertext1);
        }

        /// <summary>
        ///  DES加解密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 15:22:23
        private void PicSubmitDes_Click(object sender, System.EventArgs e)
        {
            string desPlaintext = TxtDesPlaintext.Text.Trim();
            string desCiphertext = TxtDesCiphertext.Text.Trim();
            int desNumber = TxtDesNumber.Text.Trim().ConvertToInt();
            string desLength = TxtDesLength.Text.Trim();
            if (string.IsNullOrEmpty(desPlaintext) && string.IsNullOrEmpty(desCiphertext))
            {
                MessageBox.Show("请填写明文或密文中一个！");
                return;
            }
            if (desNumber == -2)
            {
                MessageBox.Show("加/解密次数只能是数字！");
                return;
            }
            if (desNumber < PublicFields.DesNumber)
            {
                MessageBox.Show(string.Format("次数必须是大于等于{0}的整数！", PublicFields.DesNumber));
                return;
            }
            if (string.IsNullOrEmpty(desLength))
            {
                MessageBox.Show("密钥必须填写！");
                return;
            }
            if (desLength.Length != 8)
            {
                MessageBox.Show("密钥只能是八位的字符串！");
                return;
            }
            if (!string.IsNullOrEmpty(desPlaintext))
            {
                for (int i = 0; i < desNumber; i++)
                {
                    desPlaintext = desPlaintext.EncrypteDes(desLength);
                }
                TxtDesCiphertext.Text = desPlaintext;
                return;
            }
            if (!string.IsNullOrEmpty(desCiphertext))
            {
                for (int i = 0; i < desNumber; i++)
                {
                    desCiphertext = desCiphertext.DecrypteDes(desLength);
                }
                TxtDesPlaintext.Text = desCiphertext;
            }
        }

        /// <summary>
        ///  RC2加解密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 16:20:53
        private void PicSubmitRc2_Click(object sender, System.EventArgs e)
        {
            string rc2Plaintext = TxtRc2Plaintext.Text.Trim();
            string rc2Ciphertext = TxtRc2Ciphertext.Text.Trim();
            int rc2Number = TxtRc2Number.Text.Trim().ConvertToInt();
            string rc2Length = TxtRc2Length.Text.Trim();
            if (string.IsNullOrEmpty(rc2Plaintext) && string.IsNullOrEmpty(rc2Ciphertext))
            {
                MessageBox.Show("请填写明文或密文中一个！");
                return;
            }
            if (rc2Number == -2)
            {
                MessageBox.Show("加/解密次数只能是数字！");
                return;
            }
            if (rc2Number < PublicFields.Rc2Number)
            {
                MessageBox.Show(string.Format("次数必须是大于等于{0}的整数！", PublicFields.Rc2Number));
                return;
            }
            if (string.IsNullOrEmpty(rc2Length))
            {
                MessageBox.Show("密钥必须填写！");
                return;
            }
            if (rc2Length.Length != 8)
            {
                MessageBox.Show("密钥只能是八位的字符串！");
                return;
            }
            if (!string.IsNullOrEmpty(rc2Plaintext))
            {
                for (int i = 0; i < rc2Number; i++)
                {
                    rc2Plaintext = rc2Plaintext.EncrypteRc2(rc2Length);
                }
                TxtRc2Ciphertext.Text = rc2Plaintext;
                return;
            }
            if (!string.IsNullOrEmpty(rc2Ciphertext))
            {
                for (int i = 0; i < rc2Number; i++)
                {
                    rc2Ciphertext = rc2Ciphertext.DecrypteRc2(rc2Length);
                }
                TxtRc2Plaintext.Text = rc2Ciphertext;
            }
        }

        /// <summary>
        ///  AES加解密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 16:36:25
        private void PicSubmitAes_Click(object sender, System.EventArgs e)
        {
            string aesPlaintext = TxtAesPlaintext.Text.Trim();
            string aesCiphertext = TxtAesCiphertext.Text.Trim();
            int aesNumber = TxtAesNumber.Text.Trim().ConvertToInt();
            string aesLength = TxtAesLength.Text.Trim();
            if (string.IsNullOrEmpty(aesPlaintext) && string.IsNullOrEmpty(aesCiphertext))
            {
                MessageBox.Show("请填写明文或密文中一个！");
                return;
            }
            if (aesNumber == -2)
            {
                MessageBox.Show("加/解密次数只能是数字！");
                return;
            }
            if (aesNumber < PublicFields.AesNumber)
            {
                MessageBox.Show(string.Format("次数必须是大于等于{0}的整数！", PublicFields.AesNumber));
                return;
            }
            if (string.IsNullOrEmpty(aesLength))
            {
                MessageBox.Show("密钥必须填写！");
                return;
            }
            if (aesLength.Length != 8)
            {
                MessageBox.Show("密钥只能是八位的字符串！");
                return;
            }
            if (!string.IsNullOrEmpty(aesPlaintext))
            {
                for (int i = 0; i < aesNumber; i++)
                {
                    aesPlaintext = aesPlaintext.EncrypteAes(aesLength);
                }
                TxtAesCiphertext.Text = aesPlaintext;
                return;
            }
            if (!string.IsNullOrEmpty(aesCiphertext))
            {
                for (int i = 0; i < aesNumber; i++)
                {
                    aesCiphertext = aesCiphertext.DecrypteAes(aesLength);
                }
                TxtAesPlaintext.Text = aesCiphertext;
            }
        }

        /// <summary>
        ///  DES加解密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 16:45:55
        private void PicSubmitDes3_Click(object sender, System.EventArgs e)
        {
            string des3Plaintext = TxtDes3Plaintext.Text.Trim();
            string des3Ciphertext = TxtDes3Ciphertext.Text.Trim();
            int des3Number = TxtDes3Number.Text.Trim().ConvertToInt();
            string des3Length1 = TxtDes3Length1.Text.Trim();
            string des3Length2 = TxtDes3Length2.Text.Trim();
            string des3Length3 = TxtDes3Length3.Text.Trim();
            if (string.IsNullOrEmpty(des3Plaintext) && string.IsNullOrEmpty(des3Ciphertext))
            {
                MessageBox.Show("请填写明文或密文中一个！");
                return;
            }
            if (des3Number == -2)
            {
                MessageBox.Show("加/解密次数只能是数字！");
                return;
            }
            if (des3Number < PublicFields.Des3Number)
            {
                MessageBox.Show(string.Format("次数必须是大于等于{0}的整数！", PublicFields.Des3Number));
                return;
            }
            if (string.IsNullOrEmpty(des3Length1) && string.IsNullOrEmpty(des3Length2) && string.IsNullOrEmpty(des3Length3))
            {
                MessageBox.Show("密钥必须填写！");
                return;
            }
            if (des3Length1.Length != 8 || des3Length2.Length != 8 || des3Length3.Length != 8)
            {
                MessageBox.Show("密钥只能是八位的字符串！");
                return;
            }
            if (!string.IsNullOrEmpty(des3Plaintext))
            {
                for (int i = 0; i < des3Number; i++)
                {
                    des3Plaintext = des3Plaintext.EncrypteDes(des3Length1);
                    des3Plaintext = des3Plaintext.EncrypteDes(des3Length2);
                    des3Plaintext = des3Plaintext.EncrypteDes(des3Length3);
                }
                TxtDes3Ciphertext.Text = des3Plaintext;
                return;
            }
            if (!string.IsNullOrEmpty(des3Ciphertext))
            {
                for (int i = 0; i < des3Number; i++)
                {
                    des3Ciphertext = des3Ciphertext.DecrypteDes(des3Length3);
                    des3Ciphertext = des3Ciphertext.DecrypteDes(des3Length2);
                    des3Ciphertext = des3Ciphertext.DecrypteDes(des3Length1);
                }
                TxtDes3Plaintext.Text = des3Ciphertext;
            }
        }

        /// <summary>
        ///  图片浏览
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-12 09:02:55
        private void BtnBrowser_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                float i = dialog.OpenFile().Length;
                if (i / 1024 > 120)
                {
                    MessageBox.Show("图片太大，请选择小图片！");
                    return;
                }
                TxtBrowser.Text = dialog.FileName;
            }
        }

        /// <summary>
        ///  Base64和Image之间的转换
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-12 09:30:38
        private void PicSubmitBase64_Click(object sender, EventArgs e)
        {
            string filename = TxtBrowser.Text.Trim();
            string base64 = TxtBase64.Text.Trim();
            Image image;
            if (string.IsNullOrEmpty(filename) && string.IsNullOrEmpty(base64))
            {
                MessageBox.Show("请选择图片或者输入Base64！");
                return;
            }
            //Image转Base64
            if (!string.IsNullOrEmpty(filename))
            {
                try
                {
                    image = Image.FromFile(filename);
                    TxtBase64.Text = image.ImageToBase64(image.RawFormat);
                }
                catch (Exception)
                {
                    MessageBox.Show("请选择正确的图片！");
                    return;
                }
            }
            //Base64转Image
            if (!string.IsNullOrEmpty(base64))
            {
                try
                {
                    image = base64.Base64ToImage();
                    PicImage.Image = image;
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入正确的Base64！");
                }
            }
        }

        /// <summary>
        ///  清除图片路径
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-12 09:56:10
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBrowser.Text = "";
        }

    }
}
