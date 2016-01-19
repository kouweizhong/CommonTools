using System;
using System.Drawing;
using System.Windows.Forms;
using CommonTools.Common;
using CommonTools.Win.Properties;
using DevExpress.XtraSplashScreen;
using Napoleon.PublicCommon.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        ///     返回
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-25 14:33:15
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            var start = new StartForm();
            Hide();
            start.Show();
        }

        /// <summary>
        ///     关闭页面
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-25 14:32:57
        private void GeneralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        #region 进度条

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

        /// <summary>
        ///  隐藏进度条
        /// </summary>
        /// <param name="manager">进度条</param>
        /// Author  : Napoleon
        /// Created : 2015-02-26 20:33:22
        protected void HideManager(SplashScreenManager manager)
        {
            manager.CloseWaitForm();
        }

        #endregion

        /// <summary>
        ///     生成自定义主键
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-25 15:07:01
        private void PicSubmitCustomId_Click(object sender, EventArgs e)
        {
            var guid1 = TxtGuid1.Text.ConvertToInt();
            var guid2 = TxtGuid2.Text.ConvertToInt();
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
            var datetime = DateTime.Now.ToString(TxtDateTime.Text);
            var guid = Guid.NewGuid().ToString().Replace("-", "").Substring(guid1, guid2 - guid1);
            switch (cobSelectOrderBy.SelectedIndex)
            {
                case 0: //日期+Guid
                    TxtResult.Text = datetime + guid;
                    break;
                case 1: //Guid+日期
                    TxtResult.Text = guid + datetime;
                    break;
            }
        }

        /// <summary>
        ///     表单提交
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2016-01-18 16:26:29
        private void PicSubmitForm_Click(object sender, EventArgs e)
        {
            string url = TxtFormUrl.Text, text = TxtFormText.Text, results, msg = "";
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请填写提交表单的详细信息!");
                return;
            }
            ShowManager(LoadingMsg,"正在推送中...","");
            var json = JsonConvert.SerializeObject(new
            {
                text,
                displayUser = new
                {
                    name = "瀑布IM"
                }
            });
            try
            {
                results = url.RequestUpDownData(json, HttpMethod.Post);
                var objects = (JObject)JsonConvert.DeserializeObject(results);
                if (objects["error"].ToString().Equals("0"))
                {
                    msg = "推送成功!";
                }
                else
                {
                    msg = "推送失败!";
                }
            }
            catch (Exception)
            {
                msg = "推送出错了!";
            }
            HideManager(LoadingMsg);
            MessageBox.Show(msg);
        }
    }
}