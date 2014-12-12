

namespace CommonTools.Common
{
    public class PublicFunc
    {

        #region 类型转换

        /// <summary>
        ///  string转换成int,-2表示转换失败
        /// </summary>
        /// <param name="str">string</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 11:09:00
        public int ConvertToInt(string str)
        {
            int i = 0;
            if (int.TryParse(str, out i))
            {

            }
        }

        #endregion


    }
}
