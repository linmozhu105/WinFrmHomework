namespace WindowsFormsLibrarySystem
{
    partial class FrmBookCategory
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbTree = new System.Windows.Forms.GroupBox();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryBookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.flpTool = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbTree.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.pnlTool.SuspendLayout();
            this.flpTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbTree);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbDetail);
            this.splitContainer1.Size = new System.Drawing.Size(900, 620);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbTree
            // 
            this.gbTree.BackColor = System.Drawing.Color.White;
            this.gbTree.Controls.Add(this.tvCategory);
            this.gbTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTree.Location = new System.Drawing.Point(0, 0);
            this.gbTree.Name = "gbTree";
            this.gbTree.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbTree.Size = new System.Drawing.Size(240, 620);
            this.gbTree.TabIndex = 0;
            this.gbTree.TabStop = false;
            this.gbTree.Text = "分类树";
            // 
            // tvCategory
            // 
            this.tvCategory.BackColor = System.Drawing.Color.White;
            this.tvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tvCategory.FullRowSelect = true;
            this.tvCategory.HideSelection = false;
            this.tvCategory.ItemHeight = 28;
            this.tvCategory.Location = new System.Drawing.Point(8, 24);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.ShowLines = false;
            this.tvCategory.ShowPlusMinus = true;
            this.tvCategory.ShowRootLines = false;
            this.tvCategory.Size = new System.Drawing.Size(224, 590);
            this.tvCategory.TabIndex = 0;
            // 
            // gbDetail
            // 
            this.gbDetail.BackColor = System.Drawing.Color.White;
            this.gbDetail.Controls.Add(this.dgvCategory);
            this.gbDetail.Controls.Add(this.pnlTool);
            this.gbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetail.Location = new System.Drawing.Point(0, 0);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbDetail.Size = new System.Drawing.Size(654, 620);
            this.gbDetail.TabIndex = 0;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "分类明细";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dgvCategory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvCategory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvCategory.ColumnHeadersHeight = 38;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategoryName,
            this.colCategoryCode,
            this.colCategoryParent,
            this.colCategoryBookCount});
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.dgvCategory.Location = new System.Drawing.Point(8, 72);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.RowTemplate.Height = 34;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(638, 542);
            this.dgvCategory.TabIndex = 1;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FillWeight = 120F;
            this.colCategoryName.HeaderText = "分类名称";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.ReadOnly = true;
            // 
            // colCategoryCode
            // 
            this.colCategoryCode.FillWeight = 80F;
            this.colCategoryCode.HeaderText = "分类编码";
            this.colCategoryCode.Name = "colCategoryCode";
            this.colCategoryCode.ReadOnly = true;
            // 
            // colCategoryParent
            // 
            this.colCategoryParent.FillWeight = 90F;
            this.colCategoryParent.HeaderText = "上级分类";
            this.colCategoryParent.Name = "colCategoryParent";
            this.colCategoryParent.ReadOnly = true;
            // 
            // colCategoryBookCount
            // 
            this.colCategoryBookCount.FillWeight = 80F;
            this.colCategoryBookCount.HeaderText = "图书数量";
            this.colCategoryBookCount.Name = "colCategoryBookCount";
            this.colCategoryBookCount.ReadOnly = true;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.White;
            this.pnlTool.Controls.Add(this.flpTool);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(8, 24);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(638, 48);
            this.pnlTool.TabIndex = 0;
            // 
            // flpTool
            // 
            this.flpTool.Controls.Add(this.btnAddCategory);
            this.flpTool.Controls.Add(this.btnEditCategory);
            this.flpTool.Controls.Add(this.btnDeleteCategory);
            this.flpTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTool.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpTool.Location = new System.Drawing.Point(0, 0);
            this.flpTool.Name = "flpTool";
            this.flpTool.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.flpTool.Size = new System.Drawing.Size(638, 48);
            this.flpTool.TabIndex = 0;
            this.flpTool.WrapContents = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(164)))), ((int)(((byte)(93)))));
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(3, 9);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(104, 32);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "＋  新增分类";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditCategory.Location = new System.Drawing.Point(113, 9);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(88, 32);
            this.btnEditCategory.TabIndex = 1;
            this.btnEditCategory.Text = "✎  修改";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(207, 9);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(88, 32);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "✕  删除";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // FrmBookCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.Padding = new System.Windows.Forms.Padding(10);
            this.MinimumSize = new System.Drawing.Size(760, 520);
            this.Name = "FrmBookCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书分类管理";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbTree.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.flpTool.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbTree;
        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryBookCount;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.FlowLayoutPanel flpTool;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
    }
}
