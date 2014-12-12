
using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Configuration;
using System.Web.Security;

namespace CommonTools.Common
{
    public static class PublicFunc
    {

        #region 基础

        /// <summary>
        ///  获取指定字符串的长度
        /// </summary>
        /// <param name="value">字符串</param>
        /// <param name="start">开始位置</param>
        /// <param name="length">长度</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 15:24:47
        public static string SubstringValue(this string value, int start, int length)
        {
            return value.Trim().Substring(start, length);
        }

        #endregion


        #region 类型转换

        /// <summary>
        ///  string转换成int,-2表示转换失败
        /// </summary>
        /// <param name="str">string</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 11:09:00
        public static int ConvertToInt(this string str)
        {
            int i;
            if (!int.TryParse(str, out i))
            {
                i = -2;
            }
            return i;
        }

        #endregion

        #region 加解密

        /// <summary>
        ///  MD5加密
        /// </summary>
        /// <param name="value">明文</param>
        /// <param name="replace">替换字符</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 11:29:05
        public static string GetMd5(this string value, string replace)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string bits = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(value)));
            return bits.Replace("-", replace);
        }

        /// <summary>
        ///  SHA1加密
        /// </summary>
        /// <param name="value">明文</param>
        /// <param name="replace">替换字符</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 15:25:52
        public static string GetSha1(this string value, string replace)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            string bits = BitConverter.ToString(sha1.ComputeHash(Encoding.Default.GetBytes(value)));
            return bits.Replace("-", replace);
        }

        #endregion



    }
}
