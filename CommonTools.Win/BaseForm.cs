﻿using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace CommonTools.Win
{
    public partial class BaseForm : XtraForm
    {

        private readonly static DefaultLookAndFeel DefaultLook = new DefaultLookAndFeel();

        /// <summary>
        ///  应用皮肤
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 15:08:45
        protected static void ApplySkin(string skinName)
        {
            DefaultLook.LookAndFeel.SkinName = skinName;
        }



    }
}
