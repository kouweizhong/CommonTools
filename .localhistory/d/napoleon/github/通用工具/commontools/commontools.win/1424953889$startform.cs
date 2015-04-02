
using System;
using System.Drawing;
using System.Windows.Forms;
using CommonTools.Win.Encrypte;
using DevExpress.XtraSplashScreen;

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

        #region 鼠标样式改变

        /// <summary>
        ///  鼠标停留控件
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-12-08 21:01:27
        private void PicEncrypte_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            ChangeBackColor(Color.SteelBlue, pictureBox);
        }

        /// <summary>
        ///  鼠标离开控件
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-12-08 21:05:52
        private void PicEncrypte_MouseLeave(object sender, EventArgs e)
        {
            ChangeBackColor(Color.Transparent, sender as PictureBox);
        }

        /// <summary>
        ///  设置按钮边框颜色
        /// </summary>
        /// <param name="color">颜色</param>
        /// <param name="pictureBox">按钮</param>
        /// Author  : Napoleon
        /// Created : 2014-12-08 21:01:07
        private void SetPicBoxColor(Color color, PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(color, 2);
            g.DrawRectangle(pen, pictureBox.ClientRectangle.X, pictureBox.ClientRectangle.Y,
                pictureBox.ClientRectangle.X + pictureBox.ClientRectangle.Width,
                pictureBox.ClientRectangle.Y + pictureBox.ClientRectangle.Height);
        }

        /// <summary>
        ///  改变背景色
        /// </summary>
        /// <param name="color">颜色</param>
        /// <param name="pictureBox">按钮</param>
        /// Author  : Napoleon
        /// Created : 2014-12-08 21:40:03
        private void ChangeBackColor(Color color, PictureBox pictureBox)
        {
            pictureBox.BackColor = color;
            pictureBox.Refresh();
        }

        #endregion

        #region 公共函数

        #region 公共函数

        /// <summary>
        ///  显示进度条
        /// </summary>
        /// <param name="manager">进度条</param>
        /// <param name="caption">标题</param>
        /// <param name="description">描述</param>
        /// Author  : Napoleon
        /// Created : 2015-02-26 20:30:27
        protected void ShowManager(SplashScreenManager manager, string caption, string description)
        {
            manager.ShowWaitForm();
            manager.SetWaitFormCaption(caption);
            manager.SetWaitFormDescription(description);
        }

        protected void HideManager(SplashScreenManager manager)
        {
            manager.CloseWaitForm();
        }

        #endregion

        #endregion


        /// <summary>
        ///  加解密
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-12-10 09:19:54
        private void PicEncrypte_Click(object sender, EventArgs e)
        {
            LoadingForm.ShowWaitForm();
            LoadingForm.SetWaitFormCaption("加载中......");
            LoadingForm.SetWaitFormDescription("");
            EncrypteForm encrypte = new EncrypteForm();
            Hide();
            LoadingForm.CloseWaitForm();
            encrypte.Show();
        }

        /// <summary>
        ///  基础
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-02-26 20:04:21
        private void PicBase_Click(object sender, EventArgs e)
        {
            //EncrypteForm encrypte = new EncrypteForm();
            SwitchForm(LoadingForm, "加载中......", "", new EncrypteForm(), this);
            /*ShowManager(LoadingForm, "加载中......", "");
            EncrypteForm encrypte = new EncrypteForm();
            Hide();
            HideManager(LoadingForm);
            encrypte.Show();*/
        }



    }
}
