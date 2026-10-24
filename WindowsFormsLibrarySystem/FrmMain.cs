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
    /// 图书管理系统主界面（MDI 父窗体）。
    /// 界面布局已经搭好：菜单栏、工具栏、左侧导航、状态栏直接挂在窗体上，
    /// 中间客户区由 MdiClient 承载各功能子窗体。
    /// 本文件只保留空方法骨架，事件绑定已在设计器里接好，逐个填方法体即可。
    /// </summary>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            // 提示：MDI 客户区默认是深灰色，想改成浅色可以遍历 this.Controls 找到 MdiClient 再设 BackColor。
        }

        // ============================================================
        // 说明：下面每个方法的 Click 事件都已经在 FrmMain.Designer.cs 里绑定好了，
        // 不需要再去设计器重复绑定，只要在方法体里写“打开哪个子窗体”的逻辑。
        //
        // 建议先自己写一个统一的方法（名字随意，比如 OpenMdiChild），里面做三件事：
        //   1. 判断同类型子窗体是否已经打开，是就 Activate 并返回；
        //   2. child.MdiParent = this;
        //   3. child.WindowState = FormWindowState.Maximized; child.Show();
        // 然后下面每个方法写一行调用它。
        //
        // 注意：修改密码是对话框（FixedDialog），要用 ShowDialog，不能设 MdiParent。
        // ============================================================

        #region 系统菜单

        private void mnuUserManage_Click(object sender, EventArgs e)
        {
            // TODO: 打开用户管理窗体
        }

        private void mnuChangePwd_Click(object sender, EventArgs e)
        {
            // TODO: 打开修改密码对话框（ShowDialog）
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // TODO: 确认后退出程序
        }

        #endregion

        #region 图书管理

        private void mnuBookIn_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书入库窗体
        }

        private void mnuBookCategory_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书分类窗体
        }

        private void mnuBookCheck_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书盘点窗体
        }

        #endregion

        #region 读者管理

        private void mnuReaderFile_Click(object sender, EventArgs e)
        {
            // TODO: 打开读者档案窗体
        }

        private void mnuReaderLoss_Click(object sender, EventArgs e)
        {
            // TODO: 打开读者挂失窗体
        }

        #endregion

        #region 借阅管理

        private void mnuBorrowIn_Click(object sender, EventArgs e)
        {
            // TODO: 打开借书登记窗体
        }

        private void mnuBorrowOut_Click(object sender, EventArgs e)
        {
            // TODO: 打开还书登记窗体
        }

        private void mnuBorrowOverdue_Click(object sender, EventArgs e)
        {
            // TODO: 打开逾期催还窗体
        }

        #endregion

        #region 帮助

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            // TODO: 弹出关于对话框
        }

        #endregion

        #region 工具栏

        private void tsbBookIn_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书入库窗体
        }

        private void tsbBorrow_Click(object sender, EventArgs e)
        {
            // TODO: 打开借书登记窗体
        }

        private void tsbReturn_Click(object sender, EventArgs e)
        {
            // TODO: 打开还书登记窗体
        }

        private void tsbReader_Click(object sender, EventArgs e)
        {
            // TODO: 打开读者档案窗体
        }

        private void tsbStat_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书盘点窗体
        }

        private void tsbSetting_Click(object sender, EventArgs e)
        {
            // TODO: 打开用户管理窗体
        }

        #endregion

        #region 左侧导航

        private void btnNavBook_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书入库窗体
        }

        private void btnNavReader_Click(object sender, EventArgs e)
        {
            // TODO: 打开读者档案窗体
        }

        private void btnNavBorrow_Click(object sender, EventArgs e)
        {
            // TODO: 打开借书登记窗体
        }

        private void btnNavReturn_Click(object sender, EventArgs e)
        {
            // TODO: 打开还书登记窗体
        }

        private void btnNavSearch_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书查询窗体（FrmBookList）
        }

        private void btnNavSetting_Click(object sender, EventArgs e)
        {
            // TODO: 打开用户管理窗体
        }

        #endregion
    }
}
