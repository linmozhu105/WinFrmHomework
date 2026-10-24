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
    /// 菜单栏、工具栏、左侧导航、状态栏直接挂在窗体上，中间客户区由 MdiClient 承载各功能子窗体。
    /// 子窗体通过 OpenMdiChild 统一打开，同类型窗体已存在时直接激活，不重复创建。
    /// </summary>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            // MDI 客户区默认是深灰，改成与界面一致的浅蓝灰
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = System.Drawing.Color.FromArgb(238, 242, 248);
                }
            }
        }

        /// <summary>
        /// 打开 MDI 子窗体。
        /// 先检查是否已经打开同类型窗体，有就直接激活，避免开出多个实例。
        /// </summary>
        private void OpenMdiChild(Form child)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == child.GetType())
                {
                    f.Activate();
                    child.Dispose();      // 新实例用不上，及时释放
                    return;
                }
            }

            child.MdiParent = this;                          // 指定父窗体
            child.WindowState = FormWindowState.Maximized;   // 铺满客户区，避免层叠
            child.Show();                                    // 子窗体用 Show，不能用 ShowDialog
        }

        #region 系统菜单

        private void mnuUserManage_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmUserManage());
        }

        private void mnuChangePwd_Click(object sender, EventArgs e)
        {
            FrmChangePwd dlg = new FrmChangePwd();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("密码修改成功，请重新登录。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出系统吗？", "退出",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        #region 图书管理

        private void mnuBookIn_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBookIn());
        }

        private void mnuBookCategory_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBookCategory());
        }

        private void mnuBookCheck_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBookCheck());
        }

        #endregion

        #region 读者管理

        private void mnuReaderFile_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmReaderFile());
        }

        private void mnuReaderLoss_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmReaderLoss());
        }

        #endregion

        #region 借阅管理

        private void mnuBorrowIn_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBorrowRegister());
        }

        private void mnuBorrowOut_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmReturnBook());
        }

        private void mnuBorrowOverdue_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmOverdue());
        }

        #endregion

        #region 帮助

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("图书管理系统 V1.0\r\nWinForms 容器控件与界面布局综合练习",
                "关于系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region 工具栏

        private void tsbBookIn_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBookIn());
        }

        private void tsbBorrow_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBorrowRegister());
        }

        private void tsbReturn_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmReturnBook());
        }

        private void tsbReader_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmReaderFile());
        }

        private void tsbStat_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBookCheck());
        }

        private void tsbSetting_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmUserManage());
        }

        #endregion

        #region 左侧导航

        private void btnNavBook_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBookIn());
        }

        private void btnNavReader_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmReaderFile());
        }

        private void btnNavBorrow_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBorrowRegister());
        }

        private void btnNavReturn_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmReturnBook());
        }

        /// <summary>
        /// 图书查询：打开查询页（原主界面右侧的查询条件 + 图书列表）。
        /// </summary>
        private void btnNavSearch_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmBookList());
        }

        private void btnNavSetting_Click(object sender, EventArgs e)
        {
            OpenMdiChild(new FrmUserManage());
        }

        #endregion
    }
}
