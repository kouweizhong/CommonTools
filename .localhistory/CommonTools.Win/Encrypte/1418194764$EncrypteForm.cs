﻿
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
            string txtnumber = TxtNumber.Text.Trim();
            string ciphertext1 = TxtCiphertext1.Text.Trim();
            string ciphertext2 = TxtCiphertext2.Text.Trim();
            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("请填写明文！");
                return;
            }
            if (txtnumber.ConvertToInt() == -2 || ciphertext1.ConvertToInt() == -2 || ciphertext2.ConvertToInt() == -2)
            {
                MessageBox.Show("请正确填写数字！");
                return;
            }
            if (txtnumber.ConvertToInt() <= 0)
            {
                MessageBox.Show("次数必须是大于1的整数！");
                return;
            }
            if (ciphertext1.ConvertToInt() < 0 || ciphertext1.ConvertToInt() > 32 || ciphertext2.ConvertToInt() <= 0 ||
                ciphertext2.ConvertToInt() > 32)
            {
                MessageBox.Show("密文长度必须在0~32范围内!");
                return;
            }
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




    }
}