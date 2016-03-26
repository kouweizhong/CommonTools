using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using CommonTools.Common;
using CommonTools.Win.Properties;
using DevExpress.XtraSplashScreen;
using Napoleon.PublicCommon.Cryptography;
using Napoleon.PublicCommon.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

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
            var start = new StartForm();
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

        #region 自定义主键

        /// <summary>
        ///  生成自定义主键
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
                default:
                    TxtResult.Text = datetime + guid;
                    break;
            }
            if (chkFocus.Checked)//选中并复制
            {
                TxtResult.Focus();
                TxtResult.SelectAll();
                Clipboard.SetDataObject(TxtResult.Text, true);
            }
        }

        #endregion

        #region BearyChat推送

        /// <summary>
        ///  表单提交
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2016-01-18 16:26:29
        private void PicSubmitForm_Click(object sender, EventArgs e)
        {
            string url = TxtFormUrl.Text,
                text = TxtFormText.Text,
                results,
                msg,
                title = TxtFormTitle.Text,
                dep = TxtFormDesp.Text,
                color = colSelect.Color.Name;
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请填写提交表单的详细信息!");
                return;
            }
            ShowManager(LoadingMsg, "正在推送中...", "");
            var json = "{\"text\":\"" + text + "\"";
            if (!string.IsNullOrEmpty(title) || !string.IsNullOrEmpty(dep))
            {
                json += "\"attachments\":[{\"title\":\"" + title + "\",\"text\":\"" + dep + "\",\"color\":\"#" + color +
                        "\"}]";
            }
            json += "}";
            try
            {
                results = url.PostJsonData(json, contentType: ContentTypes.JsonType);
                var objects = (JObject)JsonConvert.DeserializeObject(results);
                if ((objects["code"].ToString().Equals("0")))
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

        #endregion

        #region 生成条形码

        /// <summary>
        ///  生成一维码
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2016-01-25 14:19:01
        private void BtnCreateCode1_Click(object sender, EventArgs e)
        {
            //设置条形码规格
            EncodingOptions encodeOption = new EncodingOptions();
            encodeOption.Height = 150; //必须制定高度、宽度
            encodeOption.Width = 250;
            BarcodeWriter wr = new BarcodeWriter();
            wr.Options = encodeOption;
            wr.Format = BarcodeFormat.CODE_39; //EAN13表示有校验规则的13位数字,CODE_39表示无规则的
            Bitmap img = wr.Write(TxtCode.Text);
            PicCode.Image = img;
            if (!string.IsNullOrEmpty(TxtImgUrl.Text)) //地址不为空的话,需要将图片生成
            {
                string filePath = TxtImgUrl.Text + "\\" + TxtCode.Text + ".jpg";
                img.Save(filePath, ImageFormat.Jpeg);
                MessageBox.Show("一维码已经生成并保存成功!");
            }
        }

        /// <summary>
        ///  生成二维码
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2016-01-25 14:48:21
        private void BtnCreateCode2_Click(object sender, EventArgs e)
        {
            //设置QR二维码的规格
            QrCodeEncodingOptions qrEncodeOption = new QrCodeEncodingOptions();
            qrEncodeOption.CharacterSet = "UTF-8"; // 设置编码格式，否则读取'中文'乱码
            qrEncodeOption.Height = 200;
            qrEncodeOption.Width = 200;
            qrEncodeOption.Margin = 1; //设置周围空白边距
            BarcodeWriter wr = new BarcodeWriter();
            wr.Format = BarcodeFormat.QR_CODE; // 二维码
            wr.Options = qrEncodeOption;
            Bitmap img = wr.Write(TxtCode.Text);
            PicCode.Image = img;
            if (!string.IsNullOrEmpty(TxtImgUrl.Text)) //地址不为空的话,需要将图片生成
            {
                string filePath = TxtImgUrl.Text + "\\QR-" + TxtCode.Text + ".jpg";
                img.Save(filePath, ImageFormat.Jpeg);
                MessageBox.Show("二维码已经生成并保存成功!");
            }
        }

        /// <summary>
        ///  选择保存图片的地址
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2016-01-25 14:51:59
        private void BtnLoadImg_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择图片保存路径";
            folder.ShowDialog();
            TxtImgUrl.Text = folder.SelectedPath;
        }

        /// <summary>
        ///  选择Logo图片
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2016-01-25 14:52:19
        private void BtnLoadLogo_Click(object sender, EventArgs e)
        {
            FileDialog file = new OpenFileDialog();
            file.Filter = "图片|*.jpg;*.png;*.gif";
            file.Title = "选择logo";
            if (file.ShowDialog() == DialogResult.OK)
            {
                TxtLogoUrl.Text = file.FileName;
            }
        }

        /// <summary>
        ///  生成带logo的二维码
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2016-01-25 14:52:32
        private void BtnCreateLogoCode2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLogoUrl.Text))
            {
                MessageBox.Show("请选择logo图片!");
                return;
            }
            //设置QR二维码的规格
            QrCodeEncodingOptions qrEncodeOption = new QrCodeEncodingOptions();
            qrEncodeOption.CharacterSet = "UTF-8"; // 设置编码格式，否则读取'中文'乱码
            qrEncodeOption.Height = 200;
            qrEncodeOption.Width = 200;
            qrEncodeOption.Margin = 1; //设置周围空白边距
            BarcodeWriter wr = new BarcodeWriter();
            wr.Format = BarcodeFormat.QR_CODE; // 二维码
            wr.Options = qrEncodeOption;
            Bitmap img = wr.Write(TxtCode.Text);
            //在二维码的Bitmap对象上绘制logo图片
            Bitmap logoImg = Bitmap.FromFile(TxtLogoUrl.Text) as Bitmap;
            if (logoImg != null)
            {
                Graphics g = Graphics.FromImage(img);
                Rectangle logoRec = new Rectangle(); // 设置logo图片的大小和绘制位置
                logoRec.Width = img.Width / 6;
                logoRec.Height = img.Height / 6;
                logoRec.X = img.Width / 2 - logoRec.Width / 2; // 中心点
                logoRec.Y = img.Height / 2 - logoRec.Height / 2;
                g.DrawImage(logoImg, logoRec);
            }
            PicCode.Image = img;
            if (!string.IsNullOrEmpty(TxtImgUrl.Text)) //地址不为空的话,需要将图片生成
            {
                string filePath = TxtImgUrl.Text + "\\QR-" + TxtCode.Text + ".jpg";
                img.Save(filePath, ImageFormat.Jpeg);
                MessageBox.Show("二维码已经生成并保存成功!");
            }
        }

        #endregion

        #region 校验文件的Hash

        /// <summary>
        ///  选择需要校验的文件
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2016-01-28 20:53:53
        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            FileDialog file = new OpenFileDialog();
            file.Title = "选择校验文件";
            if (file.ShowDialog() == DialogResult.OK)
            {
                TxtFileUrl.Text = file.FileName;
            }
        }

        /// <summary>
        ///  生成文件的Hash值
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2016-01-28 21:11:29
        private void PicCheckHash_Click(object sender, EventArgs e)
        {
            string filename = TxtFileUrl.Text;
            MenoMd5.Text = filename.HashFile();
            MenoSha1.Text = filename.HashFile(HashType.Sha1);
        }

        #endregion

    }
}