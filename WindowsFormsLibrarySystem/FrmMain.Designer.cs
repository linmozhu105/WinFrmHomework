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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书入库IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书分类CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书盘点SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者档案AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者挂失LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅管理LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书登记BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书登记RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.逾期催还OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于系统AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.tlpQuery = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.gbQuery.SuspendLayout();
            this.tlpQuery.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.图书管理BToolStripMenuItem,
            this.读者管理RToolStripMenuItem,
            this.借阅管理LToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理UToolStripMenuItem,
            this.修改密码PToolStripMenuItem,
            this.退出XToolStripMenuItem});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.系统SToolStripMenuItem.Text = "系统(&S)";
            // 
            // 用户管理UToolStripMenuItem
            // 
            this.用户管理UToolStripMenuItem.Name = "用户管理UToolStripMenuItem";
            this.用户管理UToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.用户管理UToolStripMenuItem.Text = "用户管理 (&U)";
            // 
            // 修改密码PToolStripMenuItem
            // 
            this.修改密码PToolStripMenuItem.Name = "修改密码PToolStripMenuItem";
            this.修改密码PToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.修改密码PToolStripMenuItem.Text = "修改密码 (&P)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.退出XToolStripMenuItem.Text = "退出 (&X)";
            // 
            // 图书管理BToolStripMenuItem
            // 
            this.图书管理BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书入库IToolStripMenuItem,
            this.图书分类CToolStripMenuItem,
            this.图书盘点SToolStripMenuItem});
            this.图书管理BToolStripMenuItem.Name = "图书管理BToolStripMenuItem";
            this.图书管理BToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.图书管理BToolStripMenuItem.Text = "图书管理(&B)";
            // 
            // 图书入库IToolStripMenuItem
            // 
            this.图书入库IToolStripMenuItem.Name = "图书入库IToolStripMenuItem";
            this.图书入库IToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.图书入库IToolStripMenuItem.Text = "图书入库 (&I)";
            // 
            // 图书分类CToolStripMenuItem
            // 
            this.图书分类CToolStripMenuItem.Name = "图书分类CToolStripMenuItem";
            this.图书分类CToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.图书分类CToolStripMenuItem.Text = "图书分类 (&C)";
            // 
            // 图书盘点SToolStripMenuItem
            // 
            this.图书盘点SToolStripMenuItem.Name = "图书盘点SToolStripMenuItem";
            this.图书盘点SToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.图书盘点SToolStripMenuItem.Text = "图书盘点 (&S)";
            // 
            // 读者管理RToolStripMenuItem
            // 
            this.读者管理RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者档案AToolStripMenuItem,
            this.读者挂失LToolStripMenuItem});
            this.读者管理RToolStripMenuItem.Name = "读者管理RToolStripMenuItem";
            this.读者管理RToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.读者管理RToolStripMenuItem.Text = "读者管理(&R)";
            // 
            // 读者档案AToolStripMenuItem
            // 
            this.读者档案AToolStripMenuItem.Name = "读者档案AToolStripMenuItem";
            this.读者档案AToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.读者档案AToolStripMenuItem.Text = "读者档案 (&A)";
            // 
            // 读者挂失LToolStripMenuItem
            // 
            this.读者挂失LToolStripMenuItem.Name = "读者挂失LToolStripMenuItem";
            this.读者挂失LToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.读者挂失LToolStripMenuItem.Text = "读者挂失 (&L)";
            // 
            // 借阅管理LToolStripMenuItem
            // 
            this.借阅管理LToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书登记BToolStripMenuItem,
            this.还书登记RToolStripMenuItem,
            this.逾期催还OToolStripMenuItem});
            this.借阅管理LToolStripMenuItem.Name = "借阅管理LToolStripMenuItem";
            this.借阅管理LToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.借阅管理LToolStripMenuItem.Text = "借阅管理(&L)";
            // 
            // 借书登记BToolStripMenuItem
            // 
            this.借书登记BToolStripMenuItem.Name = "借书登记BToolStripMenuItem";
            this.借书登记BToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.借书登记BToolStripMenuItem.Text = "借书登记 (&B)";
            // 
            // 还书登记RToolStripMenuItem
            // 
            this.还书登记RToolStripMenuItem.Name = "还书登记RToolStripMenuItem";
            this.还书登记RToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.还书登记RToolStripMenuItem.Text = "还书登记 (&R)";
            // 
            // 逾期催还OToolStripMenuItem
            // 
            this.逾期催还OToolStripMenuItem.Name = "逾期催还OToolStripMenuItem";
            this.逾期催还OToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.逾期催还OToolStripMenuItem.Text = "逾期催还 (&O)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于系统AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于系统AToolStripMenuItem
            // 
            this.关于系统AToolStripMenuItem.Name = "关于系统AToolStripMenuItem";
            this.关于系统AToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.关于系统AToolStripMenuItem.Text = "关于系统 (&A)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 24);
            this.toolStripButton1.Text = "图书入库";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(93, 24);
            this.toolStripButton2.Text = "借书登记";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(93, 24);
            this.toolStripButton3.Text = "还书登记";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(93, 24);
            this.toolStripButton4.Text = "读者管理";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(93, 24);
            this.toolStripButton5.Text = "数据统计";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(93, 24);
            this.toolStripButton6.Text = "系统设置";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 160;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvBooks);
            this.splitContainer1.Panel2.Controls.Add(this.gbQuery);
            this.splitContainer1.Size = new System.Drawing.Size(782, 498);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 498);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "图书管理";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "读者管理";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "借书登记";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "还书登记";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "图书查询";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "系统设置";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(0, 80);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(598, 418);
            this.dgvBooks.TabIndex = 0;
            // 
            // gbQuery
            // 
            this.gbQuery.Controls.Add(this.tlpQuery);
            this.gbQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQuery.Location = new System.Drawing.Point(0, 0);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(598, 110);
            this.gbQuery.TabIndex = 1;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "查询条件";
            // 
            // tlpQuery
            // 
            this.tlpQuery.ColumnCount = 6;
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuery.Controls.Add(this.lblBookName, 0, 0);
            this.tlpQuery.Controls.Add(this.txtBookName, 1, 0);
            this.tlpQuery.Controls.Add(this.lblAuthor, 2, 0);
            this.tlpQuery.Controls.Add(this.txtAuthor, 3, 0);
            this.tlpQuery.Controls.Add(this.lblCategory, 4, 0);
            this.tlpQuery.Controls.Add(this.cboCategory, 5, 0);
            this.tlpQuery.Controls.Add(this.lblPublisher, 0, 1);
            this.tlpQuery.Controls.Add(this.txtPublisher, 1, 1);
            this.tlpQuery.Controls.Add(this.lblDate, 2, 1);
            this.tlpQuery.Controls.Add(this.dtpDate, 3, 1);
            this.tlpQuery.Controls.Add(this.btnQuery, 4, 1);
            this.tlpQuery.Controls.Add(this.btnReset, 5, 1);
            this.tlpQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuery.Location = new System.Drawing.Point(3, 21);
            this.tlpQuery.Name = "tlpQuery";
            this.tlpQuery.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tlpQuery.RowCount = 2;
            this.tlpQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuery.Size = new System.Drawing.Size(592, 56);
            this.tlpQuery.TabIndex = 0;
            // 
            // lblBookName
            // 
            this.lblBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookName.Location = new System.Drawing.Point(11, 6);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(90, 22);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "书名：";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.Location = new System.Drawing.Point(107, 9);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(90, 25);
            this.txtBookName.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Location = new System.Drawing.Point(203, 6);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(90, 22);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "作者：";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.Location = new System.Drawing.Point(299, 9);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(90, 25);
            this.txtAuthor.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Location = new System.Drawing.Point(395, 6);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 22);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "分类：";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(491, 9);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(90, 23);
            this.cboCategory.TabIndex = 5;
            // 
            // lblPublisher
            // 
            this.lblPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublisher.Location = new System.Drawing.Point(11, 28);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(90, 22);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "出版社：";
            this.lblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisher.Location = new System.Drawing.Point(107, 31);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(90, 25);
            this.txtPublisher.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(203, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 22);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "入库日期：";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(299, 31);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(90, 25);
            this.dtpDate.TabIndex = 9;
            // 
            // btnQuery
            // 
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.Location = new System.Drawing.Point(395, 31);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(90, 16);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(491, 31);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 16);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "重置";
            //
            // statusStrip1
            //
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslClock,
            this.tslVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            //
            // tslUser
            //
            this.tslUser.Name = "tslUser";
            this.tslUser.Size = new System.Drawing.Size(110, 20);
            this.tslUser.Text = "当前用户：admin";
            //
            // tslClock
            //
            this.tslClock.Name = "tslClock";
            this.tslClock.Size = new System.Drawing.Size(570, 20);
            this.tslClock.Spring = true;
            this.tslClock.Text = "当前时间：";
            //
            // tslVersion
            //
            this.tslVersion.Name = "tslVersion";
            this.tslVersion.Size = new System.Drawing.Size(60, 20);
            this.tslVersion.Text = "V1.0";
            //
            // timer1
            //
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // FrmMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.gbQuery.ResumeLayout(false);
            this.tlpQuery.ResumeLayout(false);
            this.tlpQuery.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书管理BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书入库IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书分类CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书盘点SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者管理RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者档案AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者挂失LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅管理LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书登记BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书登记RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 逾期催还OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于系统AToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.TableLayoutPanel tlpQuery;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslUser;
        private System.Windows.Forms.ToolStripStatusLabel tslClock;
        private System.Windows.Forms.ToolStripStatusLabel tslVersion;
        private System.Windows.Forms.Timer timer1;
    }
}

