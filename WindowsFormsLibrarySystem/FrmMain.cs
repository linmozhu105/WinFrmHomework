using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLibrarySystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 1. 分类下拉框预置 5 个分类
            cboCategory.Items.AddRange(new string[] { "计算机", "文学", "历史", "艺术", "教材" });

            // 2. 图书列表建立 8 列（列头按课件效果图）
            dgvBooks.Columns.Add("colId", "图书编号");
            dgvBooks.Columns.Add("colName", "书名");
            dgvBooks.Columns.Add("colAuthor", "作者");
            dgvBooks.Columns.Add("colPublisher", "出版社");
            dgvBooks.Columns.Add("colCategory", "分类");
            dgvBooks.Columns.Add("colPrice", "单价(元)");
            dgvBooks.Columns.Add("colTotal", "馆藏数量");
            dgvBooks.Columns.Add("colAvail", "可借数量");

            // 3. 添加 8 条模拟图书数据
            dgvBooks.Rows.Add("B001", "C#高级编程", "Christian Nagel", "清华大学出版社", "计算机", "128.00", 5, 3);
            dgvBooks.Rows.Add("B002", "Java核心技术", "Cay S. Horstmann", "机械工业出版社", "计算机", "119.00", 6, 4);
            dgvBooks.Rows.Add("B003", "深入理解计算机系统", "Randal E. Bryant", "机械工业出版社", "计算机", "139.00", 4, 2);
            dgvBooks.Rows.Add("B004", "平凡的世界", "路遥", "北京十月文艺出版社", "文学", "98.00", 8, 5);
            dgvBooks.Rows.Add("B005", "明朝那些事儿", "当年明月", "中国友谊出版公司", "历史", "128.00", 7, 3);
            dgvBooks.Rows.Add("B006", "中国美术史", "王宏建", "高等教育出版社", "艺术", "58.00", 3, 1);
            dgvBooks.Rows.Add("B007", "高等数学（第七版）", "同济大学数学系", "高等教育出版社", "教材", "56.00", 10, 6);
            dgvBooks.Rows.Add("B008", "百年孤独", "加西亚·马尔克斯", "南海出版公司", "文学", "55.00", 6, 4);

            // 4. 窗口刚打开时先显示一次当前时间（不等第 1 秒）
            tslClock.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // Timer 每 1 秒触发一次，刷新状态栏时钟
        private void timer1_Tick(object sender, EventArgs e)
        {
            tslClock.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
