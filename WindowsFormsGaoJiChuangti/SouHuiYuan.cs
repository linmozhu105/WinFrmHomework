using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGaoJiChuangti
{
    /// <summary>
    /// 会员信息实体类，结构与设备类一致，只是属性换了业务含义。
    /// </summary>
    public class MemberInfo
    {
        /// <summary>会员卡号</summary>
        public string CardNo { get; set; }

        /// <summary>会员名</summary>
        public string Name { get; set; }

        /// <summary>性别</summary>
        public string Gender { get; set; }

        /// <summary>出生日期</summary>
        public DateTime Birthday { get; set; }

        /// <summary>职业</summary>
        public string Job { get; set; }

        /// <summary>余额</summary>
        public int Balance { get; set; }

        /// <summary>爱好</summary>
        public string Hobby { get; set; }
    }
}
