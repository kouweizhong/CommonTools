
using System.Web.Configuration;
using System.Web.Security;

namespace CommonTools.Common
{
    public static class PublicFunc
    {

        #region 基础

        public static string SubstringValue(string value, int start, int length)
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
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 11:29:05
        public static string GetMd5(this string value)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(value, FormsAuthPasswordFormat.MD5.ToString());
        }

        #endregion



    }
}
