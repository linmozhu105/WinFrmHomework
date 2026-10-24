namespace WindowsFormsLibrarySystem
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReader = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReaderFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReaderLoss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrowIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrowOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrowOverdue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBookIn = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrow = new System.Windows.Forms.ToolStripButton();
            this.tsbReturn = new System.Windows.Forms.ToolStripButton();
            this.tsbReader = new System.Windows.Forms.ToolStripButton();
            this.tsbStat = new System.Windows.Forms.ToolStripButton();
            this.tsbSetting = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNavBook = new System.Windows.Forms.Button();
            this.btnNavReader = new System.Windows.Forms.Button();
            this.btnNavBorrow = new System.Windows.Forms.Button();
            this.btnNavReturn = new System.Windows.Forms.Button();
            this.btnNavSearch = new System.Windows.Forms.Button();
            this.btnNavSetting = new System.Windows.Forms.Button();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.tlpQuery = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.tlpList = new System.Windows.Forms.TableLayoutPanel();
            this.pnlListTool = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.flpListTool = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpPager = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tlpRoot.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowNav.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.tlpRight.SuspendLayout();
            this.gbQuery.SuspendLayout();
            this.tlpQuery.SuspendLayout();
            this.gbList.SuspendLayout();
            this.tlpList.SuspendLayout();
            this.pnlListTool.SuspendLayout();
            this.flpListTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.flpPager.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.menuStrip1, 0, 0);
            this.tlpRoot.Controls.Add(this.toolStrip1, 0, 1);
            this.tlpRoot.Controls.Add(this.splitContainer1, 0, 2);
            this.tlpRoot.Controls.Add(this.statusStrip1, 0, 3);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 4;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpRoot.Size = new System.Drawing.Size(1080, 720);
            this.tlpRoot.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuBook,
            this.mnuReader,
            this.mnuBorrow,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserManage,
            this.mnuChangePwd,
            this.mnuExit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(72, 28);
            this.mnuSystem.Text = "系统(&S)";
            // 
            // mnuUserManage
            // 
            this.mnuUserManage.Name = "mnuUserManage";
            this.mnuUserManage.Size = new System.Drawing.Size(173, 26);
            this.mnuUserManage.Text = "用户管理(&U)";
            // 
            // mnuChangePwd
            // 
            this.mnuChangePwd.Name = "mnuChangePwd";
            this.mnuChangePwd.Size = new System.Drawing.Size(173, 26);
            this.mnuChangePwd.Text = "修改密码(&P)";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(173, 26);
            this.mnuExit.Text = "退出(&X)";
            // 
            // mnuBook
            // 
            this.mnuBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookIn,
            this.mnuBookCategory,
            this.mnuBookCheck});
            this.mnuBook.Name = "mnuBook";
            this.mnuBook.Size = new System.Drawing.Size(102, 28);
            this.mnuBook.Text = "图书管理(&B)";
            // 
            // mnuBookIn
            // 
            this.mnuBookIn.Name = "mnuBookIn";
            this.mnuBookIn.Size = new System.Drawing.Size(172, 26);
            this.mnuBookIn.Text = "图书入库(&I)";
            // 
            // mnuBookCategory
            // 
            this.mnuBookCategory.Name = "mnuBookCategory";
            this.mnuBookCategory.Size = new System.Drawing.Size(172, 26);
            this.mnuBookCategory.Text = "图书分类(&C)";
            // 
            // mnuBookCheck
            // 
            this.mnuBookCheck.Name = "mnuBookCheck";
            this.mnuBookCheck.Size = new System.Drawing.Size(172, 26);
            this.mnuBookCheck.Text = "图书盘点(&S)";
            // 
            // mnuReader
            // 
            this.mnuReader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReaderFile,
            this.mnuReaderLoss});
            this.mnuReader.Name = "mnuReader";
            this.mnuReader.Size = new System.Drawing.Size(103, 28);
            this.mnuReader.Text = "读者管理(&R)";
            // 
            // mnuReaderFile
            // 
            this.mnuReaderFile.Name = "mnuReaderFile";
            this.mnuReaderFile.Size = new System.Drawing.Size(173, 26);
            this.mnuReaderFile.Text = "读者档案(&A)";
            // 
            // mnuReaderLoss
            // 
            this.mnuReaderLoss.Name = "mnuReaderLoss";
            this.mnuReaderLoss.Size = new System.Drawing.Size(173, 26);
            this.mnuReaderLoss.Text = "读者挂失(&L)";
            // 
            // mnuBorrow
            // 
            this.mnuBorrow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBorrowIn,
            this.mnuBorrowOut,
            this.mnuBorrowOverdue});
            this.mnuBorrow.Name = "mnuBorrow";
            this.mnuBorrow.Size = new System.Drawing.Size(101, 28);
            this.mnuBorrow.Text = "借阅管理(&L)";
            // 
            // mnuBorrowIn
            // 
            this.mnuBorrowIn.Name = "mnuBorrowIn";
            this.mnuBorrowIn.Size = new System.Drawing.Size(174, 26);
            this.mnuBorrowIn.Text = "借书登记(&B)";
            // 
            // mnuBorrowOut
            // 
            this.mnuBorrowOut.Name = "mnuBorrowOut";
            this.mnuBorrowOut.Size = new System.Drawing.Size(174, 26);
            this.mnuBorrowOut.Text = "还书登记(&R)";
            // 
            // mnuBorrowOverdue
            // 
            this.mnuBorrowOverdue.Name = "mnuBorrowOverdue";
            this.mnuBorrowOverdue.Size = new System.Drawing.Size(174, 26);
            this.mnuBorrowOverdue.Text = "逾期催还(&O)";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(75, 28);
            this.mnuHelp.Text = "帮助(&H)";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(173, 26);
            this.mnuAbout.Text = "关于系统(&A)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBookIn,
            this.tsbBorrow,
            this.tsbReturn,
            this.tsbReader,
            this.tsbStat,
            this.tsbSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.toolStrip1.Size = new System.Drawing.Size(1080, 36);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBookIn
            // 
            this.tsbBookIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBookIn.Name = "tsbBookIn";
            this.tsbBookIn.Size = new System.Drawing.Size(73, 29);
            this.tsbBookIn.Text = "图书入库";
            // 
            // tsbBorrow
            // 
            this.tsbBorrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBorrow.Name = "tsbBorrow";
            this.tsbBorrow.Size = new System.Drawing.Size(73, 29);
            this.tsbBorrow.Text = "借书登记";
            // 
            // tsbReturn
            // 
            this.tsbReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReturn.Name = "tsbReturn";
            this.tsbReturn.Size = new System.Drawing.Size(73, 29);
            this.tsbReturn.Text = "还书登记";
            // 
            // tsbReader
            // 
            this.tsbReader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReader.Name = "tsbReader";
            this.tsbReader.Size = new System.Drawing.Size(73, 29);
            this.tsbReader.Text = "读者管理";
            // 
            // tsbStat
            // 
            this.tsbStat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStat.Name = "tsbStat";
            this.tsbStat.Size = new System.Drawing.Size(73, 29);
            this.tsbStat.Text = "数据统计";
            // 
            // tsbSetting
            // 
            this.tsbSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSetting.Name = "tsbSetting";
            this.tsbSetting.Size = new System.Drawing.Size(73, 29);
            this.tsbSetting.Text = "系统设置";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 71);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowNav);
            this.splitContainer1.Panel1.Controls.Add(this.gbUser);
            this.splitContainer1.Panel1MinSize = 170;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tlpRight);
            this.splitContainer1.Size = new System.Drawing.Size(1074, 620);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowNav
            // 
            this.flowNav.AutoScroll = true;
            this.flowNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.flowNav.Controls.Add(this.btnNavBook);
            this.flowNav.Controls.Add(this.btnNavReader);
            this.flowNav.Controls.Add(this.btnNavBorrow);
            this.flowNav.Controls.Add(this.btnNavReturn);
            this.flowNav.Controls.Add(this.btnNavSearch);
            this.flowNav.Controls.Add(this.btnNavSetting);
            this.flowNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNav.Location = new System.Drawing.Point(0, 0);
            this.flowNav.Name = "flowNav";
            this.flowNav.Padding = new System.Windows.Forms.Padding(12, 14, 12, 12);
            this.flowNav.Size = new System.Drawing.Size(200, 524);
            this.flowNav.TabIndex = 0;
            this.flowNav.WrapContents = false;
            // 
            // btnNavBook
            // 
            this.btnNavBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavBook.Location = new System.Drawing.Point(15, 17);
            this.btnNavBook.Name = "btnNavBook";
            this.btnNavBook.Size = new System.Drawing.Size(176, 40);
            this.btnNavBook.TabIndex = 0;
            this.btnNavBook.Text = "图书管理";
            this.btnNavBook.UseVisualStyleBackColor = false;
            // 
            // btnNavReader
            // 
            this.btnNavReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavReader.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavReader.Location = new System.Drawing.Point(15, 63);
            this.btnNavReader.Name = "btnNavReader";
            this.btnNavReader.Size = new System.Drawing.Size(176, 40);
            this.btnNavReader.TabIndex = 1;
            this.btnNavReader.Text = "读者管理";
            this.btnNavReader.UseVisualStyleBackColor = false;
            // 
            // btnNavBorrow
            // 
            this.btnNavBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavBorrow.Location = new System.Drawing.Point(15, 109);
            this.btnNavBorrow.Name = "btnNavBorrow";
            this.btnNavBorrow.Size = new System.Drawing.Size(176, 40);
            this.btnNavBorrow.TabIndex = 2;
            this.btnNavBorrow.Text = "借书登记";
            this.btnNavBorrow.UseVisualStyleBackColor = false;
            // 
            // btnNavReturn
            // 
            this.btnNavReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavReturn.Location = new System.Drawing.Point(15, 155);
            this.btnNavReturn.Name = "btnNavReturn";
            this.btnNavReturn.Size = new System.Drawing.Size(176, 40);
            this.btnNavReturn.TabIndex = 3;
            this.btnNavReturn.Text = "还书登记";
            this.btnNavReturn.UseVisualStyleBackColor = false;
            // 
            // btnNavSearch
            // 
            this.btnNavSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavSearch.Location = new System.Drawing.Point(15, 201);
            this.btnNavSearch.Name = "btnNavSearch";
            this.btnNavSearch.Size = new System.Drawing.Size(176, 40);
            this.btnNavSearch.TabIndex = 4;
            this.btnNavSearch.Text = "图书查询";
            this.btnNavSearch.UseVisualStyleBackColor = false;
            // 
            // btnNavSetting
            // 
            this.btnNavSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavSetting.Location = new System.Drawing.Point(15, 247);
            this.btnNavSetting.Name = "btnNavSetting";
            this.btnNavSetting.Size = new System.Drawing.Size(176, 40);
            this.btnNavSetting.TabIndex = 5;
            this.btnNavSetting.Text = "系统设置";
            this.btnNavSetting.UseVisualStyleBackColor = false;
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.White;
            this.gbUser.Controls.Add(this.lblUserInfo);
            this.gbUser.Controls.Add(this.picAvatar);
            this.gbUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbUser.Location = new System.Drawing.Point(0, 524);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbUser.Size = new System.Drawing.Size(200, 96);
            this.gbUser.TabIndex = 1;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "当前用户";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Location = new System.Drawing.Point(74, 28);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(116, 52);
            this.lblUserInfo.TabIndex = 0;
            this.lblUserInfo.Text = "管理员：admin\r\n角色：系统管理员";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(14, 26);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(52, 52);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // tlpRight
            // 
            this.tlpRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.gbQuery, 0, 0);
            this.tlpRight.Controls.Add(this.gbList, 0, 1);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(0, 0);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.tlpRight.RowCount = 2;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Size = new System.Drawing.Size(870, 620);
            this.tlpRight.TabIndex = 0;
            // 
            // gbQuery
            // 
            this.gbQuery.BackColor = System.Drawing.Color.White;
            this.gbQuery.Controls.Add(this.tlpQuery);
            this.gbQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQuery.Location = new System.Drawing.Point(13, 11);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(844, 110);
            this.gbQuery.TabIndex = 0;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "查询条件";
            // 
            // tlpQuery
            // 
            this.tlpQuery.ColumnCount = 6;
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpQuery.Controls.Add(this.lblBookName, 0, 0);
            this.tlpQuery.Controls.Add(this.txtBookName, 1, 0);
            this.tlpQuery.Controls.Add(this.lblCategory, 2, 0);
            this.tlpQuery.Controls.Add(this.cboCategory, 3, 0);
            this.tlpQuery.Controls.Add(this.btnQuery, 4, 0);
            this.tlpQuery.Controls.Add(this.btnReset, 5, 0);
            this.tlpQuery.Controls.Add(this.lblAuthor, 0, 1);
            this.tlpQuery.Controls.Add(this.txtAuthor, 1, 1);
            this.tlpQuery.Controls.Add(this.lblPublisher, 2, 1);
            this.tlpQuery.Controls.Add(this.cboPublisher, 3, 1);
            this.tlpQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuery.Location = new System.Drawing.Point(3, 23);
            this.tlpQuery.Name = "tlpQuery";
            this.tlpQuery.Padding = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.tlpQuery.RowCount = 2;
            this.tlpQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuery.Size = new System.Drawing.Size(838, 84);
            this.tlpQuery.TabIndex = 0;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookName.Location = new System.Drawing.Point(14, 15);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(56, 20);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "书名：";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.Location = new System.Drawing.Point(81, 12);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(224, 27);
            this.txtBookName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategory.Location = new System.Drawing.Point(316, 15);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(56, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "分类：";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(383, 11);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(224, 28);
            this.cboCategory.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuery.Location = new System.Drawing.Point(613, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(66, 28);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnReset.Location = new System.Drawing.Point(685, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 28);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAuthor.Location = new System.Drawing.Point(14, 50);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(56, 20);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "作者：";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.Location = new System.Drawing.Point(81, 47);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(224, 27);
            this.txtAuthor.TabIndex = 7;
            // 
            // lblPublisher
            // 
            this.lblPublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPublisher.Location = new System.Drawing.Point(311, 50);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(66, 20);
            this.lblPublisher.TabIndex = 8;
            this.lblPublisher.Text = "出版社：";
            this.lblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPublisher
            // 
            this.cboPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.Location = new System.Drawing.Point(383, 46);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(224, 28);
            this.cboPublisher.TabIndex = 9;
            // 
            // gbList
            // 
            this.gbList.BackColor = System.Drawing.Color.White;
            this.gbList.Controls.Add(this.tlpList);
            this.gbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbList.Location = new System.Drawing.Point(13, 127);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(844, 482);
            this.gbList.TabIndex = 1;
            this.gbList.TabStop = false;
            this.gbList.Text = "图书列表";
            // 
            // tlpList
            // 
            this.tlpList.ColumnCount = 1;
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.Controls.Add(this.pnlListTool, 0, 0);
            this.tlpList.Controls.Add(this.dgvBooks, 0, 1);
            this.tlpList.Controls.Add(this.flpPager, 0, 2);
            this.tlpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpList.Location = new System.Drawing.Point(3, 23);
            this.tlpList.Name = "tlpList";
            this.tlpList.Padding = new System.Windows.Forms.Padding(4);
            this.tlpList.RowCount = 3;
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpList.Size = new System.Drawing.Size(838, 456);
            this.tlpList.TabIndex = 0;
            // 
            // pnlListTool
            // 
            this.pnlListTool.Controls.Add(this.btnExport);
            this.pnlListTool.Controls.Add(this.flpListTool);
            this.pnlListTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListTool.Location = new System.Drawing.Point(7, 7);
            this.pnlListTool.Name = "pnlListTool";
            this.pnlListTool.Size = new System.Drawing.Size(824, 36);
            this.pnlListTool.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExport.Location = new System.Drawing.Point(712, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 36);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "⤓  导出Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // flpListTool
            // 
            this.flpListTool.Controls.Add(this.btnAdd);
            this.flpListTool.Controls.Add(this.btnEdit);
            this.flpListTool.Controls.Add(this.btnDelete);
            this.flpListTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListTool.Location = new System.Drawing.Point(0, 0);
            this.flpListTool.Name = "flpListTool";
            this.flpListTool.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.flpListTool.Size = new System.Drawing.Size(824, 36);
            this.flpListTool.TabIndex = 0;
            this.flpListTool.WrapContents = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(164)))), ((int)(((byte)(93)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(5, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "＋  新增图书";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.Location = new System.Drawing.Point(123, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✎  修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(217, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "✕  删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAuthor,
            this.colPublisher,
            this.colCategory,
            this.colPrice,
            this.colTotal,
            this.colAvail});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.EnableHeadersVisualStyles = false;
            this.dgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.dgvBooks.Location = new System.Drawing.Point(7, 49);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 34;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(824, 360);
            this.dgvBooks.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.FillWeight = 88F;
            this.colId.HeaderText = "图书编号";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 88;
            // 
            // colName
            // 
            this.colName.FillWeight = 140F;
            this.colName.HeaderText = "书名";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 130;
            // 
            // colAuthor
            // 
            this.colAuthor.FillWeight = 120F;
            this.colAuthor.HeaderText = "作者";
            this.colAuthor.MinimumWidth = 6;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 110;
            // 
            // colPublisher
            // 
            this.colPublisher.FillWeight = 130F;
            this.colPublisher.HeaderText = "出版社";
            this.colPublisher.MinimumWidth = 6;
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.ReadOnly = true;
            this.colPublisher.Width = 130;
            // 
            // colCategory
            // 
            this.colCategory.FillWeight = 72F;
            this.colCategory.HeaderText = "分类";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 72;
            // 
            // colPrice
            // 
            this.colPrice.FillWeight = 72F;
            this.colPrice.HeaderText = "单价(元)";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 112F;
            this.colTotal.HeaderText = "馆藏数量";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 95;
            // 
            // colAvail
            // 
            this.colAvail.FillWeight = 112F;
            this.colAvail.HeaderText = "可借数量";
            this.colAvail.MinimumWidth = 6;
            this.colAvail.Name = "colAvail";
            this.colAvail.ReadOnly = true;
            this.colAvail.Width = 95;
            // 
            // flpPager
            // 
            this.flpPager.Controls.Add(this.lblTotal);
            this.flpPager.Controls.Add(this.btnLast);
            this.flpPager.Controls.Add(this.btnNext);
            this.flpPager.Controls.Add(this.lblPage);
            this.flpPager.Controls.Add(this.btnPrev);
            this.flpPager.Controls.Add(this.btnFirst);
            this.flpPager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPager.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPager.Location = new System.Drawing.Point(7, 415);
            this.flpPager.Name = "flpPager";
            this.flpPager.Padding = new System.Windows.Forms.Padding(4);
            this.flpPager.Size = new System.Drawing.Size(824, 34);
            this.flpPager.TabIndex = 2;
            this.flpPager.WrapContents = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(727, 4);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "共 0 条记录";
            // 
            // btnLast
            // 
            this.btnLast.AutoSize = true;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(665, 7);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(56, 32);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "末页";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(593, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(66, 32);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(509, 9);
            this.lblPage.Margin = new System.Windows.Forms.Padding(10, 5, 10, 3);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(71, 20);
            this.lblPage.TabIndex = 2;
            this.lblPage.Text = "第 1/1 页";
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSize = true;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(430, 7);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(66, 32);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.AutoSize = true;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(368, 7);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(56, 32);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "首页";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslClock,
            this.tslVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslUser
            // 
            this.tslUser.Name = "tslUser";
            this.tslUser.Size = new System.Drawing.Size(129, 20);
            this.tslUser.Text = "当前登录：admin";
            // 
            // tslClock
            // 
            this.tslClock.Name = "tslClock";
            this.tslClock.Size = new System.Drawing.Size(801, 20);
            this.tslClock.Spring = true;
            this.tslClock.Text = "日期时间：";
            // 
            // tslVersion
            // 
            this.tslVersion.Name = "tslVersion";
            this.tslVersion.Size = new System.Drawing.Size(135, 20);
            this.tslVersion.Text = "图书管理系统 V1.0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统 - 主界面";
            this.tlpRoot.ResumeLayout(false);
            this.tlpRoot.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowNav.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.tlpRight.ResumeLayout(false);
            this.gbQuery.ResumeLayout(false);
            this.tlpQuery.ResumeLayout(false);
            this.tlpQuery.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.tlpList.ResumeLayout(false);
            this.pnlListTool.ResumeLayout(false);
            this.flpListTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.flpPager.ResumeLayout(false);
            this.flpPager.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuUserManage;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePwd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.ToolStripMenuItem mnuBookIn;
        private System.Windows.Forms.ToolStripMenuItem mnuBookCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuBookCheck;
        private System.Windows.Forms.ToolStripMenuItem mnuReader;
        private System.Windows.Forms.ToolStripMenuItem mnuReaderFile;
        private System.Windows.Forms.ToolStripMenuItem mnuReaderLoss;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrow;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrowIn;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrowOut;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrowOverdue;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBookIn;
        private System.Windows.Forms.ToolStripButton tsbBorrow;
        private System.Windows.Forms.ToolStripButton tsbReturn;
        private System.Windows.Forms.ToolStripButton tsbReader;
        private System.Windows.Forms.ToolStripButton tsbStat;
        private System.Windows.Forms.ToolStripButton tsbSetting;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowNav;
        private System.Windows.Forms.Button btnNavBook;
        private System.Windows.Forms.Button btnNavReader;
        private System.Windows.Forms.Button btnNavBorrow;
        private System.Windows.Forms.Button btnNavReturn;
        private System.Windows.Forms.Button btnNavSearch;
        private System.Windows.Forms.Button btnNavSetting;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.TableLayoutPanel tlpQuery;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.TableLayoutPanel tlpList;
        private System.Windows.Forms.Panel pnlListTool;
        private System.Windows.Forms.FlowLayoutPanel flpListTool;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvail;
        private System.Windows.Forms.FlowLayoutPanel flpPager;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslUser;
        private System.Windows.Forms.ToolStripStatusLabel tslClock;
        private System.Windows.Forms.ToolStripStatusLabel tslVersion;
        private System.Windows.Forms.Timer timer1;
    }
}
