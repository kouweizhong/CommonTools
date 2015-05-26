
using System;
using System.Text;
using System.Web;
using System.Windows.Forms;
using CommonTools.Common;
using Microsoft.JScript;

namespace CommonTools.Win.FormFunc
{
    public partial class CodeForm : BaseForm
    {

        private string _encodeString = "";

        public CodeForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        private void CodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  返回按钮
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-26 14:14:50
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            Hide();
            start.Show();
        }

        /// <summary>
        ///  编/解码
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-26 14:17:28
        private void PicSubmitCode_Click(object sender, EventArgs e)
        {
            int number = txtNumber.Text.ConvertToInt();
            string result;
            if (string.IsNullOrWhiteSpace(_encodeString))
            {
                MessageBox.Show("请选择编码方式！");
                return;
            }
            if (number == -2)
            {
                MessageBox.Show("请输入编码次数！");
                return;
            }
            if (number > 5)
            {
                MessageBox.Show("编码次数不要过多！");
                return;
            }
            if (string.IsNullOrWhiteSpace(memoEncode.Text) && string.IsNullOrWhiteSpace(memoDecode.Text))
            {
                MessageBox.Show("编码或解码不能都为空！");
                return;
            }
            if (!string.IsNullOrWhiteSpace(memoEncode.Text))//编码
            {
                result = memoEncode.Text;
                for (int i = 0; i < number; i++)
                {
                    result = EncodeFunc(result, _encodeString);
                }
                memoDecode.Text = result;
            }
            if (!string.IsNullOrWhiteSpace(memoDecode.Text))//解码
            {
                result = memoDecode.Text;
                for (int i = 0; i < number; i++)
                {
                    result = DecodeFunc(result, _encodeString);
                }
                memoEncode.Text = result;
            }
        }

        /// <summary>
        ///  编码方式下拉框
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-26 14:54:55
        private void cobSelectCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _encodeString = cobSelectCode.SelectedItem.ToString();
        }

        /// <summary>
        ///  编码
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-26 15:07:25
        private string EncodeFunc(string encodeValue, string encodeFunc)
        {
            string result = "";
            try
            {
                switch (encodeFunc)
                {
                    case "Default":
                        result = HttpUtility.UrlEncode(encodeValue, Encoding.Default);
                        break;
                    case "UTF32":
                        result = HttpUtility.UrlEncode(encodeValue, Encoding.UTF32);
                        break;
                    case "UTF8":
                        result = HttpUtility.UrlEncode(encodeValue, Encoding.UTF8);
                        break;
                    case "UTF7":
                        result = HttpUtility.UrlEncode(encodeValue, Encoding.UTF7);
                        break;
                    case "Unicode":
                        result = HttpUtility.UrlEncode(encodeValue, Encoding.Unicode);
                        break;
                    case "ASCII":
                        result = HttpUtility.UrlEncode(encodeValue, Encoding.ASCII);
                        break;
                    case "GBK"://简体中文
                        result = HttpUtility.UrlEncode(encodeValue, Encoding.GetEncoding("GBK"));
                        break;
                    case "GB2312"://简体中文
                        result = HttpUtility.UrlEncode(encodeValue, Encoding.GetEncoding("GB2312"));
                        break;
                    case "GB18030"://繁体中文
                        result = HttpUtility.UrlEncode(encodeValue, Encoding.GetEncoding("GB18030"));
                        break;
                    case "escape"://js的编码
                        result = GlobalObject.escape(encodeValue);
                        break;
                    case "encodeURI":
                        result = GlobalObject.encodeURI(encodeValue);
                        break;
                    case "encodeURIComponent":
                        result = GlobalObject.encodeURIComponent(encodeValue);
                        break;
                }
            }
            catch (Exception exception)
            {
                result = exception.Message;
            }
            return result;
        }

        /// <summary>
        ///  编码
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-26 15:07:25
        private string DecodeFunc(string decodeValue, string decodeFunc)
        {
            string result = "";
            try
            {
                switch (decodeFunc)
                {
                    case "Default":
                        result = HttpUtility.UrlDecode(decodeValue, Encoding.Default);
                        break;
                    case "UTF32":
                        result = HttpUtility.UrlDecode(decodeValue, Encoding.UTF32);
                        break;
                    case "UTF8":
                        result = HttpUtility.UrlDecode(decodeValue, Encoding.UTF8);
                        break;
                    case "UTF7":
                        result = HttpUtility.UrlDecode(decodeValue, Encoding.UTF7);
                        break;
                    case "Unicode":
                        result = HttpUtility.UrlDecode(decodeValue, Encoding.Unicode);
                        break;
                    case "ASCII":
                        result = HttpUtility.UrlDecode(decodeValue, Encoding.ASCII);
                        break;
                    case "GBK"://简体中文
                        result = HttpUtility.UrlDecode(decodeValue, Encoding.GetEncoding("GBK"));
                        break;
                    case "GB2312"://简体中文
                        result = HttpUtility.UrlDecode(decodeValue, Encoding.GetEncoding("GB2312"));
                        break;
                    case "GB18030"://繁体中文
                        result = HttpUtility.UrlDecode(decodeValue, Encoding.GetEncoding("GB18030"));
                        break;
                    case "escape"://js的编码
                        result = GlobalObject.escape(decodeValue);
                        break;
                    case "encodeURI":
                        result = GlobalObject.decodeURI(decodeValue);
                        break;
                    case "encodeURIComponent":
                        result = GlobalObject.decodeURIComponent(decodeValue);
                        break;
                }
            }
            catch (Exception exception)
            {
                result = exception.Message;
            }
            return result;
        }

    }
}
