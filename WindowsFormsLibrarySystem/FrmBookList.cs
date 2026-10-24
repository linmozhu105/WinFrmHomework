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
    /// 图书查询页（原主界面右侧的查询条件 + 图书列表）。
    /// 主界面改成 MDI 父窗体后，这部分内容独立成子窗体，由「图书查询」入口打开。
    /// </summary>
    public partial class FrmBookList : Form
    {
        public FrmBookList()
        {
            InitializeComponent();
        }
    }
}
