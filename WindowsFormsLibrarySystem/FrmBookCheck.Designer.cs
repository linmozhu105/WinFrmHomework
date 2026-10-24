namespace WindowsFormsLibrarySystem
{
    partial class FrmBookCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.tlpQuery = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvCheck = new System.Windows.Forms.DataGridView();
            this.colCheckId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStat = new System.Windows.Forms.Panel();
            this.flpStat = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSumBook = new System.Windows.Forms.Label();
            this.lblSumReal = new System.Windows.Forms.Label();
            this.lblSumLost = new System.Windows.Forms.Label();
            this.lblSumMore = new System.Windows.Forms.Label();
            this.gbQuery.SuspendLayout();
            this.tlpQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).BeginInit();
            this.pnlStat.SuspendLayout();
            this.flpStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQuery
            // 
            this.gbQuery.BackColor = System.Drawing.Color.White;
            this.gbQuery.Controls.Add(this.tlpQuery);
            this.gbQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQuery.Location = new System.Drawing.Point(10, 10);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbQuery.Size = new System.Drawing.Size(920, 86);
            this.gbQuery.TabIndex = 0;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "盘点条件";
            // 
            // tlpQuery
            // 
            this.tlpQuery.ColumnCount = 5;
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tlpQuery.Controls.Add(this.lblCategory, 0, 0);
            this.tlpQuery.Controls.Add(this.cboCategory, 1, 0);
            this.tlpQuery.Controls.Add(this.lblBookName, 2, 0);
            this.tlpQuery.Controls.Add(this.txtBookName, 3, 0);
            this.tlpQuery.Controls.Add(this.btnQuery, 4, 0);
            this.tlpQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpQuery.Location = new System.Drawing.Point(8, 26);
            this.tlpQuery.Name = "tlpQuery";
            this.tlpQuery.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.tlpQuery.RowCount = 1;
            this.tlpQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpQuery.Size = new System.Drawing.Size(904, 56);
            this.tlpQuery.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(21, 22);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "分类：";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(81, 20);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(265, 28);
            this.cboCategory.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(364, 22);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(54, 20);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "书名：";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.Location = new System.Drawing.Point(424, 18);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(369, 27);
            this.txtBookName.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(799, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(96, 32);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // dgvCheck
            // 
            this.dgvCheck.AllowUserToAddRows = false;
            this.dgvCheck.AllowUserToDeleteRows = false;
            this.dgvCheck.AllowUserToResizeRows = false;
            this.dgvCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheck.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCheck.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheck.ColumnHeadersHeight = 38;
            this.dgvCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckId,
            this.colCheckName,
            this.colCheckCategory,
            this.colCheckBook,
            this.colCheckReal,
            this.colCheckDiff});
            this.dgvCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheck.EnableHeadersVisualStyles = false;
            this.dgvCheck.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.dgvCheck.Location = new System.Drawing.Point(10, 96);
            this.dgvCheck.MultiSelect = false;
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.ReadOnly = true;
            this.dgvCheck.RowHeadersVisible = false;
            this.dgvCheck.RowHeadersWidth = 51;
            this.dgvCheck.RowTemplate.Height = 34;
            this.dgvCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheck.Size = new System.Drawing.Size(920, 452);
            this.dgvCheck.TabIndex = 1;
            // 
            // colCheckId
            // 
            this.colCheckId.FillWeight = 90F;
            this.colCheckId.HeaderText = "图书编号";
            this.colCheckId.MinimumWidth = 6;
            this.colCheckId.Name = "colCheckId";
            this.colCheckId.ReadOnly = true;
            // 
            // colCheckName
            // 
            this.colCheckName.FillWeight = 160F;
            this.colCheckName.HeaderText = "书名";
            this.colCheckName.MinimumWidth = 6;
            this.colCheckName.Name = "colCheckName";
            this.colCheckName.ReadOnly = true;
            // 
            // colCheckCategory
            // 
            this.colCheckCategory.FillWeight = 80F;
            this.colCheckCategory.HeaderText = "分类";
            this.colCheckCategory.MinimumWidth = 6;
            this.colCheckCategory.Name = "colCheckCategory";
            this.colCheckCategory.ReadOnly = true;
            // 
            // colCheckBook
            // 
            this.colCheckBook.FillWeight = 90F;
            this.colCheckBook.HeaderText = "账面数量";
            this.colCheckBook.MinimumWidth = 6;
            this.colCheckBook.Name = "colCheckBook";
            this.colCheckBook.ReadOnly = true;
            // 
            // colCheckReal
            // 
            this.colCheckReal.FillWeight = 90F;
            this.colCheckReal.HeaderText = "实盘数量";
            this.colCheckReal.MinimumWidth = 6;
            this.colCheckReal.Name = "colCheckReal";
            this.colCheckReal.ReadOnly = true;
            // 
            // colCheckDiff
            // 
            this.colCheckDiff.FillWeight = 80F;
            this.colCheckDiff.HeaderText = "差异";
            this.colCheckDiff.MinimumWidth = 6;
            this.colCheckDiff.Name = "colCheckDiff";
            this.colCheckDiff.ReadOnly = true;
            // 
            // pnlStat
            // 
            this.pnlStat.BackColor = System.Drawing.Color.White;
            this.pnlStat.Controls.Add(this.flpStat);
            this.pnlStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStat.Location = new System.Drawing.Point(10, 548);
            this.pnlStat.Name = "pnlStat";
            this.pnlStat.Size = new System.Drawing.Size(920, 62);
            this.pnlStat.TabIndex = 2;
            // 
            // flpStat
            // 
            this.flpStat.Controls.Add(this.lblSumBook);
            this.flpStat.Controls.Add(this.lblSumReal);
            this.flpStat.Controls.Add(this.lblSumLost);
            this.flpStat.Controls.Add(this.lblSumMore);
            this.flpStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStat.Location = new System.Drawing.Point(0, 0);
            this.flpStat.Name = "flpStat";
            this.flpStat.Padding = new System.Windows.Forms.Padding(18, 18, 12, 8);
            this.flpStat.Size = new System.Drawing.Size(920, 62);
            this.flpStat.TabIndex = 0;
            this.flpStat.WrapContents = false;
            // 
            // lblSumBook
            // 
            this.lblSumBook.AutoSize = true;
            this.lblSumBook.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSumBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSumBook.Location = new System.Drawing.Point(21, 21);
            this.lblSumBook.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.lblSumBook.Name = "lblSumBook";
            this.lblSumBook.Size = new System.Drawing.Size(105, 24);
            this.lblSumBook.TabIndex = 0;
            this.lblSumBook.Text = "账面总数：0";
            // 
            // lblSumReal
            // 
            this.lblSumReal.AutoSize = true;
            this.lblSumReal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSumReal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSumReal.Location = new System.Drawing.Point(169, 21);
            this.lblSumReal.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.lblSumReal.Name = "lblSumReal";
            this.lblSumReal.Size = new System.Drawing.Size(105, 24);
            this.lblSumReal.TabIndex = 1;
            this.lblSumReal.Text = "实盘总数：0";
            // 
            // lblSumLost
            // 
            this.lblSumLost.AutoSize = true;
            this.lblSumLost.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSumLost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.lblSumLost.Location = new System.Drawing.Point(317, 21);
            this.lblSumLost.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.lblSumLost.Name = "lblSumLost";
            this.lblSumLost.Size = new System.Drawing.Size(71, 24);
            this.lblSumLost.TabIndex = 2;
            this.lblSumLost.Text = "盘亏：0";
            // 
            // lblSumMore
            // 
            this.lblSumMore.AutoSize = true;
            this.lblSumMore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSumMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(164)))), ((int)(((byte)(93)))));
            this.lblSumMore.Location = new System.Drawing.Point(431, 21);
            this.lblSumMore.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.lblSumMore.Name = "lblSumMore";
            this.lblSumMore.Size = new System.Drawing.Size(71, 24);
            this.lblSumMore.TabIndex = 3;
            this.lblSumMore.Text = "盘盈：0";
            // 
            // FrmBookCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.dgvCheck);
            this.Controls.Add(this.pnlStat);
            this.Controls.Add(this.gbQuery);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "FrmBookCheck";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书盘点";
            this.gbQuery.ResumeLayout(false);
            this.tlpQuery.ResumeLayout(false);
            this.tlpQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).EndInit();
            this.pnlStat.ResumeLayout(false);
            this.flpStat.ResumeLayout(false);
            this.flpStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.TableLayoutPanel tlpQuery;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckDiff;
        private System.Windows.Forms.Panel pnlStat;
        private System.Windows.Forms.FlowLayoutPanel flpStat;
        private System.Windows.Forms.Label lblSumBook;
        private System.Windows.Forms.Label lblSumReal;
        private System.Windows.Forms.Label lblSumLost;
        private System.Windows.Forms.Label lblSumMore;
    }
}
