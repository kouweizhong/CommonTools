
namespace CommonTools.Common
{
    public static class PublicFields
    {

        #region 基本信息

        /// <summary>
        ///  数据库文件名称
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-04 14:21:15
        public static string DbName = string.Format("");

        /// <summary>
        ///  图片大小，单位KB
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 16:49:13
        public static float ImageSize = 50;

        #endregion

        #region 加密信息

        #region MD5

        /// <summary>
        ///  MD5加密次数
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:01
        public static int Md5Number = 1;

        /// <summary>
        ///  MD5开始字符位置
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:09
        public static int Md5StartNumber = 0;

        /// <summary>
        ///  MD5字符长度
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:09
        public static int Md5EndNumber = 32;

        /// <summary>
        ///  MD5字符替换
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:56
        public static string Md5Replace = string.Format("");

        #endregion

        #region SHA1

        /// <summary>
        ///  SHA1加密次数
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:01
        public static int Sha1Number = 1;

        /// <summary>
        ///  SHA1开始字符位置
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:09
        public static int Sha1StartNumber = 0;

        /// <summary>
        ///  SHA1字符长度
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:09
        public static int Sha1EndNumber = 40;

        /// <summary>
        ///  SHA1字符替换
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:56
        public static string Sha1Replace = string.Format("");

        #endregion

        #region 常用密钥加密

        /// <summary>
        ///  DES加/解密次数
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:01
        public static int DesNumber = 1;

        /// <summary>
        ///  DES3加/解密次数
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:01
        public static int Des3Number = 1;

        /// <summary>
        ///  RC2加/解密次数
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:01
        public static int Rc2Number = 1;

        /// <summary>
        ///  AES加/解密次数
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 13:41:01
        public static int AesNumber = 1;

        #endregion


        /// <summary>
        ///  对称加密算法的初始化向量(IV)
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-11 14:46:59
        public static byte[] MbtIv = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };



        #endregion

    }
}
