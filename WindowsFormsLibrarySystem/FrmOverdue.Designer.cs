namespace WindowsFormsLibrarySystem
{
    partial class FrmOverdue
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.flpTool = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNotify = new System.Windows.Forms.Button();
            this.btnExportList = new System.Windows.Forms.Button();
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFilter.SuspendLayout();
            this.tlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.pnlTool.SuspendLayout();
            this.flpTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.Controls.Add(this.tlpFilter);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(10, 10);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbFilter.Size = new System.Drawing.Size(920, 92);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "催还条件";
            // 
            // tlpFilter
            // 
            this.tlpFilter.ColumnCount = 6;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Controls.Add(this.lblDays, 0, 0);
            this.tlpFilter.Controls.Add(this.numDays, 1, 0);
            this.tlpFilter.Controls.Add(this.lblType, 2, 0);
            this.tlpFilter.Controls.Add(this.cboType, 3, 0);
            this.tlpFilter.Controls.Add(this.btnQuery, 4, 0);
            this.tlpFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFilter.Location = new System.Drawing.Point(11, 24);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.Padding = new System.Windows.Forms.Padding(6, 10, 6, 6);
            this.tlpFilter.RowCount = 1;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFilter.Size = new System.Drawing.Size(898, 56);
            this.tlpFilter.TabIndex = 0;
            // 
            // lblDays
            // 
            this.lblDays.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(10, 29);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(98, 17);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "逾期天数≥：";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDays
            // 
            this.numDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numDays.Location = new System.Drawing.Point(115, 25);
            this.numDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(90, 25);
            this.numDays.TabIndex = 1;
            this.numDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(216, 29);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(80, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "读者类型：";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Location = new System.Drawing.Point(305, 25);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(164, 25);
            this.cboType.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(478, 21);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(90, 32);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.White;
            this.pnlTool.Controls.Add(this.flpTool);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(10, 102);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(920, 48);
            this.pnlTool.TabIndex = 1;
            // 
            // flpTool
            // 
            this.flpTool.Controls.Add(this.btnNotify);
            this.flpTool.Controls.Add(this.btnExportList);
            this.flpTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTool.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpTool.Location = new System.Drawing.Point(0, 0);
            this.flpTool.Name = "flpTool";
            this.flpTool.Padding = new System.Windows.Forms.Padding(2, 8, 2, 6);
            this.flpTool.Size = new System.Drawing.Size(920, 48);
            this.flpTool.TabIndex = 0;
            this.flpTool.WrapContents = false;
            // 
            // btnNotify
            // 
            this.btnNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnNotify.FlatAppearance.BorderSize = 0;
            this.btnNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotify.ForeColor = System.Drawing.Color.White;
            this.btnNotify.Location = new System.Drawing.Point(5, 11);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(140, 32);
            this.btnNotify.TabIndex = 0;
            this.btnNotify.Text = "发送催还通知";
            this.btnNotify.UseVisualStyleBackColor = false;
            // 
            // btnExportList
            // 
            this.btnExportList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnExportList.FlatAppearance.BorderSize = 0;
            this.btnExportList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportList.ForeColor = System.Drawing.Color.White;
            this.btnExportList.Location = new System.Drawing.Point(151, 11);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(148, 32);
            this.btnExportList.TabIndex = 1;
            this.btnExportList.Text = "导出催还名单";
            this.btnExportList.UseVisualStyleBackColor = false;
            // 
            // dgvOverdue
            // 
            this.dgvOverdue.AllowUserToAddRows = false;
            this.dgvOverdue.AllowUserToDeleteRows = false;
            this.dgvOverdue.AllowUserToResizeRows = false;
            this.dgvOverdue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOverdue.BackgroundColor = System.Drawing.Color.White;
            this.dgvOverdue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOverdue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOverdue.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dgvOverdue.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvOverdue.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvOverdue.ColumnHeadersHeight = 38;
            this.dgvOverdue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colCardNo,
            this.colName,
            this.colPhone,
            this.colTitle,
            this.colBorrowDate,
            this.colDueDate,
            this.colDays});
            this.dgvOverdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOverdue.EnableHeadersVisualStyles = false;
            this.dgvOverdue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.dgvOverdue.Location = new System.Drawing.Point(10, 150);
            this.dgvOverdue.MultiSelect = false;
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.RowHeadersVisible = false;
            this.dgvOverdue.RowTemplate.Height = 34;
            this.dgvOverdue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverdue.Size = new System.Drawing.Size(920, 450);
            this.dgvOverdue.TabIndex = 2;
            // 
            // colCheck
            // 
            this.colCheck.FillWeight = 40F;
            this.colCheck.HeaderText = "选择";
            this.colCheck.Name = "colCheck";
            // 
            // colCardNo
            // 
            this.colCardNo.FillWeight = 100F;
            this.colCardNo.HeaderText = "读者证号";
            this.colCardNo.Name = "colCardNo";
            this.colCardNo.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.FillWeight = 80F;
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.FillWeight = 110F;
            this.colPhone.HeaderText = "联系电话";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.FillWeight = 150F;
            this.colTitle.HeaderText = "书名";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colBorrowDate
            // 
            this.colBorrowDate.FillWeight = 100F;
            this.colBorrowDate.HeaderText = "借出日期";
            this.colBorrowDate.Name = "colBorrowDate";
            this.colBorrowDate.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.FillWeight = 100F;
            this.colDueDate.HeaderText = "应还日期";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colDays
            // 
            this.colDays.FillWeight = 80F;
            this.colDays.HeaderText = "逾期天数";
            this.colDays.Name = "colDays";
            this.colDays.ReadOnly = true;
            // 
            // FrmOverdue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.dgvOverdue);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.gbFilter);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 520);
            this.Name = "FrmOverdue";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "逾期催还";
            this.gbFilter.ResumeLayout(false);
            this.tlpFilter.ResumeLayout(false);
            this.tlpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.flpTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.FlowLayoutPanel flpTool;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.Button btnExportList;
        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDays;
    }
}
