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
    /// <summary>
    /// 图书管理系统主界面（首页）。
    /// 布局自上而下分为六层：MenuStrip 菜单栏、ToolStrip 工具栏、
    /// SplitContainer 左右分栏、GroupBox + TableLayoutPanel 查询条件区、
    /// DataGridView 数据表、StatusStrip 状态栏。
    /// 根容器使用 TableLayoutPanel，窗口缩放时各行自动拉伸，控件不会错位。
    /// </summary>
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 模拟图书数据，每条记录依次为：编号、书名、作者、出版社、分类、单价、馆藏数量、可借数量。
        /// </summary>
        private string[,] bookData = new string[,]
        {
            { "B001", "C#高级编程", "Christian Nagel", "清华大学出版社", "计算机", "128.00", "5", "3" },
            { "B002", "Java核心技术", "Cay S. Horstmann", "机械工业出版社", "计算机", "119.00", "6", "4" },
            { "B003", "深入理解计算机系统", "Randal E. Bryant", "机械工业出版社", "计算机", "139.00", "4", "2" },
            { "B004", "平凡的世界", "路遥", "北京十月文艺出版社", "文学", "98.00", "8", "5" },
            { "B005", "明朝那些事儿", "当年明月", "中国友谊出版公司", "历史", "128.00", "7", "3" },
            { "B006", "中国美术史", "王宏建", "高等教育出版社", "艺术", "58.00", "3", "1" },
            { "B007", "高等数学（第七版）", "同济大学数学系", "高等教育出版社", "教材", "56.00", "10", "6" },
            { "B008", "百年孤独", "加西亚·马尔克斯", "南海出版公司", "文学", "55.00", "6", "4" }
        };

        /// <summary>
        /// 当前查询结果（保存全部记录的副本，查询时从中筛选）。
        /// </summary>
        private string[,] currentData;

        /// <summary>
        /// 当前页码，从 1 开始。
        /// </summary>
        private int currentPage = 1;

        /// <summary>
        /// 每页显示的记录条数。
        /// </summary>
        private int pageSize = 10;

        /// <summary>
        /// 查询结果的总记录数。
        /// </summary>
        private int totalCount = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载：初始化下拉框、建立表格列、载入模拟数据、启动时钟。
        /// </summary>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 1. 分类下拉框预置 5 个分类，与模拟数据中的分类一致
            cboCategory.Items.AddRange(new string[] { "计算机", "文学", "历史", "艺术", "教材" });
            cboCategory.SelectedIndex = 0;

            // 2. 出版社下拉框按模拟数据中的出版社预置
            cboPublisher.Items.AddRange(new string[] { "清华大学出版社", "机械工业出版社", "北京十月文艺出版社", "中国友谊出版公司", "高等教育出版社", "南海出版公司" });
            cboPublisher.SelectedIndex = 0;

            // 3. 图书列表建立 8 列
            dgvBooks.Columns.Add("colId", "图书编号");
            dgvBooks.Columns.Add("colName", "书名");
            dgvBooks.Columns.Add("colAuthor", "作者");
            dgvBooks.Columns.Add("colPublisher", "出版社");
            dgvBooks.Columns.Add("colCategory", "分类");
            dgvBooks.Columns.Add("colPrice", "单价(元)");
            dgvBooks.Columns.Add("colTotal", "馆藏数量");
            dgvBooks.Columns.Add("colAvail", "可借数量");

            // 4. 首次显示全部数据（先把全部模拟数据作为当前查询结果）
            currentData = bookData;
            totalCount = bookData.GetLength(0);
            ShowPage(1);

            // 5. 状态栏先立即显示一次当前时间，再由 Timer 每秒刷新
            tslClock.Text = "日期时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }

        /// <summary>
        /// Timer 每 1 秒触发一次，刷新状态栏时钟。
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            tslClock.Text = "日期时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 按条件筛选数据并显示第一页。
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string bookName = txtBookName.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string category = cboCategory.SelectedItem.ToString();
            string publisher = cboPublisher.SelectedItem.ToString();

            // 先把全部数据复制到查询结果中
            currentData = new string[bookData.GetLength(0), bookData.GetLength(1)];
            int count = 0;
            for (int i = 0; i < bookData.GetLength(0); i++)
            {
                // 四个条件同时成立才算命中，留空的条件不参与过滤
                bool matchName = bookName == "" || bookData[i, 1].Contains(bookName);
                bool matchAuthor = author == "" || bookData[i, 2].Contains(author);
                bool matchCategory = category == "" || bookData[i, 4] == category;
                bool matchPublisher = publisher == "" || bookData[i, 3] == publisher;

                if (matchName && matchAuthor && matchCategory && matchPublisher)
                {
                    for (int j = 0; j < bookData.GetLength(1); j++)
                    {
                        currentData[count, j] = bookData[i, j];
                    }
                    count++;
                }
            }

            // 收缩数组长度，只保留命中的记录
            string[,] result = new string[count, bookData.GetLength(1)];
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < bookData.GetLength(1); j++)
                {
                    result[i, j] = currentData[i, j];
                }
            }
            currentData = result;
            totalCount = count;

            ShowPage(1);
        }

        /// <summary>
        /// 重置查询条件并恢复显示全部数据。
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            cboCategory.SelectedIndex = 0;
            cboPublisher.SelectedIndex = 0;
            ShowPage(1);
        }

        /// <summary>
        /// 显示指定页的数据，同时更新分页条上的记录数与页码文字。
        /// </summary>
        private void ShowPage(int page)
        {
            // 1. 清空表格原有数据
            dgvBooks.Rows.Clear();

            // 2. 计算总页数，至少为 1 页
            int pageCount = totalCount == 0 ? 1 : (totalCount + pageSize - 1) / pageSize;
            if (page < 1) page = 1;
            if (page > pageCount) page = pageCount;
            currentPage = page;

            // 3. 计算当前页的起始行与结束行
            int start = (currentPage - 1) * pageSize;
            int end = start + pageSize;
            if (end > totalCount) end = totalCount;

            // 4. 把当前页的记录逐行填入表格
            for (int i = start; i < end; i++)
            {
                dgvBooks.Rows.Add(
                    currentData[i, 0],
                    currentData[i, 1],
                    currentData[i, 2],
                    currentData[i, 3],
                    currentData[i, 4],
                    currentData[i, 5],
                    currentData[i, 6],
                    currentData[i, 7]);
            }

            // 5. 刷新分页条文字
            lblTotal.Text = "共 " + totalCount + " 条记录";
            lblPage.Text = "第 " + currentPage + "/" + pageCount + " 页";
            lblCount.Text = "记录数：" + totalCount;
        }

        /// <summary>
        /// 跳转到首页。
        /// </summary>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            ShowPage(1);
        }

        /// <summary>
        /// 跳转到上一页。
        /// </summary>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            ShowPage(currentPage - 1);
        }

        /// <summary>
        /// 跳转到下一页。
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowPage(currentPage + 1);
        }

        /// <summary>
        /// 跳转到末页。
        /// </summary>
        private void btnLast_Click(object sender, EventArgs e)
        {
            int pageCount = totalCount == 0 ? 1 : (totalCount + pageSize - 1) / pageSize;
            ShowPage(pageCount);
        }

        /// <summary>
        /// 工具栏“图书入库”按钮：后续章节实现入库窗体，此处先给出提示。
        /// </summary>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowTip("图书入库", "该功能属于选做内容，后续章节实现“图书入库”子窗体。");
        }

        /// <summary>
        /// 左侧导航：图书管理。
        /// </summary>
        private void btnNavBook_Click(object sender, EventArgs e)
        {
            ShowTip("图书管理", "图书入库 / 图书分类 / 图书盘点 三个子窗体待实现。");
        }

        /// <summary>
        /// 左侧导航：读者管理。
        /// </summary>
        private void btnNavReader_Click(object sender, EventArgs e)
        {
            ShowTip("读者管理", "读者档案 / 读者挂失 两个子窗体待实现。");
        }

        /// <summary>
        /// 左侧导航：借书登记。
        /// </summary>
        private void btnNavBorrow_Click(object sender, EventArgs e)
        {
            ShowTip("借书登记", "借书台子窗体待实现。");
        }

        /// <summary>
        /// 左侧导航：还书登记。
        /// </summary>
        private void btnNavReturn_Click(object sender, EventArgs e)
        {
            ShowTip("还书登记", "还书台子窗体待实现。");
        }

        /// <summary>
        /// 左侧导航：图书查询（对应右侧查询条件区）。
        /// </summary>
        private void btnNavSearch_Click(object sender, EventArgs e)
        {
            txtBookName.Focus();
        }

        /// <summary>
        /// 左侧导航：系统设置。
        /// </summary>
        private void btnNavSetting_Click(object sender, EventArgs e)
        {
            ShowTip("系统设置", "用户管理 / 修改密码 两个窗体待实现。");
        }

        /// <summary>
        /// 表格工具条：新增图书。
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowTip("新增图书", "新增记录功能待实现。");
        }

        /// <summary>
        /// 表格工具条：修改。
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("请先在表格中选择要修改的记录。", "提示");
                return;
            }
            ShowTip("修改", "将修改图书编号为 " + dgvBooks.CurrentRow.Cells[0].Value + " 的记录。");
        }

        /// <summary>
        /// 表格工具条：删除。
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("请先在表格中选择要删除的记录。", "提示");
                return;
            }
            ShowTip("删除", "将删除图书编号为 " + dgvBooks.CurrentRow.Cells[0].Value + " 的记录。");
        }

        /// <summary>
        /// 表格工具条：导出 Excel。
        /// </summary>
        private void btnExport_Click(object sender, EventArgs e)
        {
            ShowTip("导出 Excel", "导出功能待实现（可选用 EPPlus 或 NPOI 第三方库）。");
        }

        /// <summary>
        /// 菜单“帮助 → 关于系统”：弹出关于对话框。
        /// </summary>
        private void 关于系统AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("图书管理系统 V1.0\r\n" +
                            "WinForms 容器控件与界面布局综合练习\r\n" +
                            "开发环境：VS2022 + .NET Framework 4.8",
                            "关于系统",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        /// <summary>
        /// 菜单“系统 → 退出”：关闭整个应用程序。
        /// </summary>
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 统一的提示信息方法。
        /// </summary>
        private void ShowTip(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
