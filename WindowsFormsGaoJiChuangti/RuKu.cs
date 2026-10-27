using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGaoJiChuangti
{
    /// <summary>
    /// 设备信息实体类：只描述一台机器有哪些属性，不含任何界面代码。
    /// </summary>
    public class DeviceInfo
    {
        /// <summary>机器编号，如 101</summary>
        public string Code { get; set; }

        /// <summary>机器品牌，如 联想、同方</summary>
        public string Brand { get; set; }

        /// <summary>所在区域，如 A区、Vip区</summary>
        public string Area { get; set; }

        /// <summary>使用情况，如 空闲、使用中</summary>
        public string State { get; set; }

        /// <summary>购置日期</summary>
        public DateTime BuyDate { get; set; }

    }

}
