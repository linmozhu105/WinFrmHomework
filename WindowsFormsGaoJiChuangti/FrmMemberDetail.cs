using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsGaoJiChuangti
{
    /// <summary>
    /// 课堂练习三：会员详情功能。
    /// 结构与练习二一致，差别只有三处：
    /// 列数从 5 增到 7、不用 ImageList 图标、余额列右对齐。
    ///
    /// 数据流向同样是三段：静态集合 allMembers → 按条件筛选 → FillListView 画到控件上。
    /// </summary>
    public partial class FrmMemberDetail : Form
    {
        /// <summary>
        /// 保存全部会员记录。
        /// 查询只从里面挑选，不删除、不修改，所以反复查询结果始终正确。
        /// </summary>
        private List<MemberInfo> allMembers = new List<MemberInfo>();

        public FrmMemberDetail()
        {
            InitializeComponent();
        }

        #region 一、准备数据

        /// <summary>
        /// 课程阶段还没有数据库，先用代码把 6 条记录写死。
        /// 将来接数据库时只改这一个方法，填充与查询逻辑都不用动。
        /// </summary>
        private void InitMembers()
        {
            // Birthday 用 DateTime 类型而非字符串，需要时可以直接做日期计算
            // Balance 用 int 而非 string，因为余额是要参与运算的数值
            allMembers.Add(new MemberInfo { CardNo = "123456", Name = "梦圆", Gender = "女", Birthday = new DateTime(2021, 4, 10), Job = "学生", Balance = 940, Hobby = "弹琴" });
            allMembers.Add(new MemberInfo { CardNo = "345760", Name = "自由鱼儿", Gender = "女", Birthday = new DateTime(2007, 2, 16), Job = "自由职业", Balance = 2600, Hobby = "弹琴" });
            allMembers.Add(new MemberInfo { CardNo = "412007", Name = "津津", Gender = "男", Birthday = new DateTime(2007, 7, 13), Job = "自由职业", Balance = 500, Hobby = "篮球" });
            allMembers.Add(new MemberInfo { CardNo = "462884", Name = "林东东", Gender = "男", Birthday = new DateTime(2021, 4, 10), Job = "上班族", Balance = 1800, Hobby = "足球" });
            allMembers.Add(new MemberInfo { CardNo = "585711", Name = "Jack", Gender = "男", Birthday = new DateTime(2008, 2, 14), Job = "上班族", Balance = 900, Hobby = "足球" });
            allMembers.Add(new MemberInfo { CardNo = "667539", Name = "Lisa", Gender = "女", Birthday = new DateTime(2021, 4, 10), Job = "自由职业", Balance = 400, Hobby = "篮球" });
        }

        #endregion

        #region 二、把数据画到列表上

        /// <summary>
        /// 将会员集合逐行填入 ListView。
        /// 七列依次对应：卡号、姓名、性别、生日、职业、余额、爱好。
        /// 这里的顺序必须与设计器里 Columns 的添加顺序严格一致，
        /// 因为 ListView 靠位置对应列，不靠列名匹配。
        /// </summary>
        /// <param name="list">要显示的数据集合</param>
        private void FillListView(List<MemberInfo> list)
        {
            // 暂停重绘，批量添加时不闪烁；成对出现，且 EndUpdate 放在 finally 里兜底
            lvMember.BeginUpdate();
            try
            {
                // 不清空会与上次结果叠加，查询几次就重复几份
                lvMember.Items.Clear();

                foreach (MemberInfo member in list)
                {
                    // 第一列由构造函数给出
                    ListViewItem item = new ListViewItem(member.CardNo);

                    // 第二列起依次追加，共六次
                    item.SubItems.Add(member.Name);
                    item.SubItems.Add(member.Gender);
                    // 日期格式与练习二相同，输出形如 2021/4/10 0:00:00
                    item.SubItems.Add(member.Birthday.ToString("yyyy/M/d H:mm:ss"));
                    item.SubItems.Add(member.Job);
                    // Balance 是 int，而 SubItems.Add 只接受字符串或子项对象，
                    // 直接传 int 找不到匹配的重载，编译会报错，必须 ToString
                    item.SubItems.Add(member.Balance.ToString());
                    item.SubItems.Add(member.Hobby);

                    lvMember.Items.Add(item);
                }
            }
            finally
            {
                lvMember.EndUpdate();
            }
        }

        /// <summary>
        /// 窗体加载：先把 6 条记录装进集合，再一次性画到列表上。
        /// 这两行缺一不可——只定义 InitMembers 而不调用，集合始终是空的。
        /// </summary>
        private void FrmMemberDetail_Load(object sender, EventArgs e)
        {
            InitMembers();             // 第一步：集合里有数据
            FillListView(allMembers);  // 第二步：把全集显示出来
        }

        #endregion

        #region 三、按条件查询

        /// <summary>
        /// 点击查询：卡号与会员名都支持部分匹配。
        /// 输入框留空表示该项不限制，两个都空就显示全部。
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            // 去掉首尾空格，避免复制粘贴时带上空格导致查不到
            string cardNo = txtCard.Text.Trim();
            string name = txtName.Text.Trim();

            // 临时集合，只装本次命中的记录
            List<MemberInfo> result = new List<MemberInfo>();

            foreach (MemberInfo member in allMembers)
            {
                // 卡号：包含输入内容即命中，空串跳过不判断
                if (cardNo.Length > 0 && member.CardNo.IndexOf(cardNo) < 0)
                {
                    continue;
                }
                // 会员名：IndexOf 按字符比较，对中文同样有效，
                // 输入"鱼"能查到"自由鱼儿"
                if (name.Length > 0 && member.Name.IndexOf(name) < 0)
                {
                    continue;
                }
                result.Add(member);
            }

            // 交给同一个填充方法显示，查询逻辑不重复实现
            FillListView(result);

            // 无结果时提示，避免用户误以为程序卡住
            if (result.Count == 0)
            {
                MessageBox.Show("没有符合条件的会员。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
