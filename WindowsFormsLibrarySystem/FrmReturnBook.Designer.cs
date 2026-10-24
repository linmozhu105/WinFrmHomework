namespace WindowsFormsLibrarySystem
{
    partial class FrmReturnBook
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
            this.gbReturn = new System.Windows.Forms.GroupBox();
            this.tlpReturn = new System.Windows.Forms.TableLayoutPanel();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnScanBook = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBorrower = new System.Windows.Forms.Label();
            this.txtBorrower = new System.Windows.Forms.TextBox();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.txtBorrowDate = new System.Windows.Forms.TextBox();
            this.gbOverdue = new System.Windows.Forms.GroupBox();
            this.flpOverdue = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblOverdueDays = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.colReturnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.gbReturn.SuspendLayout();
            this.tlpReturn.SuspendLayout();
            this.gbOverdue.SuspendLayout();
            this.flpOverdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReturn
            // 
            this.gbReturn.BackColor = System.Drawing.Color.White;
            this.gbReturn.Controls.Add(this.tlpReturn);
            this.gbReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbReturn.Location = new System.Drawing.Point(10, 10);
            this.gbReturn.Name = "gbReturn";
            this.gbReturn.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbReturn.Size = new System.Drawing.Size(960, 158);
            this.gbReturn.TabIndex = 0;
            this.gbReturn.TabStop = false;
            this.gbReturn.Text = "还书信息";
            // 
            // tlpReturn
            // 
            this.tlpReturn.ColumnCount = 4;
            this.tlpReturn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpReturn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReturn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpReturn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpReturn.Controls.Add(this.lblBarCode, 0, 0);
            this.tlpReturn.Controls.Add(this.txtBarCode, 1, 0);
            this.tlpReturn.Controls.Add(this.btnScanBook, 2, 0);
            this.tlpReturn.Controls.Add(this.lblBookName, 0, 1);
            this.tlpReturn.Controls.Add(this.txtBookName, 1, 1);
            this.tlpReturn.Controls.Add(this.lblBorrower, 0, 2);
            this.tlpReturn.Controls.Add(this.txtBorrower, 1, 2);
            this.tlpReturn.Controls.Add(this.lblBorrowDate, 2, 2);
            this.tlpReturn.Controls.Add(this.txtBorrowDate, 3, 2);
            this.tlpReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpReturn.Location = new System.Drawing.Point(11, 24);
            this.tlpReturn.Name = "tlpReturn";
            this.tlpReturn.Padding = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.tlpReturn.RowCount = 3;
            this.tlpReturn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpReturn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpReturn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpReturn.SetColumnSpan(this.txtBookName, 3);
            this.tlpReturn.SetColumnSpan(this.btnScanBook, 2);
            this.tlpReturn.Size = new System.Drawing.Size(938, 128);
            this.tlpReturn.TabIndex = 0;
            // 
            // lblBarCode
            // 
            this.lblBarCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(10, 18);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(80, 17);
            this.lblBarCode.TabIndex = 0;
            this.lblBarCode.Text = "图书条码：";
            this.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarCode.Location = new System.Drawing.Point(97, 14);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(564, 25);
            this.txtBarCode.TabIndex = 1;
            // 
            // btnScanBook
            // 
            this.btnScanBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnScanBook.FlatAppearance.BorderSize = 0;
            this.btnScanBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanBook.ForeColor = System.Drawing.Color.White;
            this.btnScanBook.Location = new System.Drawing.Point(667, 10);
            this.btnScanBook.Name = "btnScanBook";
            this.btnScanBook.Size = new System.Drawing.Size(256, 32);
            this.btnScanBook.TabIndex = 2;
            this.btnScanBook.Text = "扫条码查询借阅记录";
            this.btnScanBook.UseVisualStyleBackColor = false;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(54, 56);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(36, 17);
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Text = "书名:";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtBookName.Location = new System.Drawing.Point(97, 52);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(826, 25);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.TabStop = false;
            // 
            // lblBorrower
            // 
            this.lblBorrower.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBorrower.AutoSize = true;
            this.lblBorrower.Location = new System.Drawing.Point(34, 94);
            this.lblBorrower.Name = "lblBorrower";
            this.lblBorrower.Size = new System.Drawing.Size(56, 17);
            this.lblBorrower.TabIndex = 5;
            this.lblBorrower.Text = "借阅人：";
            this.lblBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBorrower
            // 
            this.txtBorrower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtBorrower.Location = new System.Drawing.Point(97, 90);
            this.txtBorrower.Name = "txtBorrower";
            this.txtBorrower.ReadOnly = true;
            this.txtBorrower.Size = new System.Drawing.Size(564, 25);
            this.txtBorrower.TabIndex = 6;
            this.txtBorrower.TabStop = false;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(675, 94);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(80, 17);
            this.lblBorrowDate.TabIndex = 7;
            this.lblBorrowDate.Text = "借出日期：";
            this.lblBorrowDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBorrowDate
            // 
            this.txtBorrowDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBorrowDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtBorrowDate.Location = new System.Drawing.Point(761, 90);
            this.txtBorrowDate.Name = "txtBorrowDate";
            this.txtBorrowDate.ReadOnly = true;
            this.txtBorrowDate.Size = new System.Drawing.Size(162, 25);
            this.txtBorrowDate.TabIndex = 8;
            this.txtBorrowDate.TabStop = false;
            // 
            // gbOverdue
            // 
            this.gbOverdue.BackColor = System.Drawing.Color.White;
            this.gbOverdue.Controls.Add(this.flpOverdue);
            this.gbOverdue.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOverdue.Location = new System.Drawing.Point(10, 168);
            this.gbOverdue.Name = "gbOverdue";
            this.gbOverdue.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbOverdue.Size = new System.Drawing.Size(960, 86);
            this.gbOverdue.TabIndex = 1;
            this.gbOverdue.TabStop = false;
            this.gbOverdue.Text = "逾期提示";
            // 
            // flpOverdue
            // 
            this.flpOverdue.Controls.Add(this.lblDueDate);
            this.flpOverdue.Controls.Add(this.lblOverdueDays);
            this.flpOverdue.Controls.Add(this.lblFine);
            this.flpOverdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOverdue.Location = new System.Drawing.Point(11, 24);
            this.flpOverdue.Name = "flpOverdue";
            this.flpOverdue.Padding = new System.Windows.Forms.Padding(8, 16, 8, 6);
            this.flpOverdue.Size = new System.Drawing.Size(938, 56);
            this.flpOverdue.TabIndex = 0;
            this.flpOverdue.WrapContents = false;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDueDate.Location = new System.Drawing.Point(11, 19);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(132, 19);
            this.lblDueDate.TabIndex = 0;
            this.lblDueDate.Text = "应还日期：--";
            // 
            // lblOverdueDays
            // 
            this.lblOverdueDays.AutoSize = true;
            this.lblOverdueDays.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOverdueDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.lblOverdueDays.Location = new System.Drawing.Point(186, 19);
            this.lblOverdueDays.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.lblOverdueDays.Name = "lblOverdueDays";
            this.lblOverdueDays.Size = new System.Drawing.Size(104, 19);
            this.lblOverdueDays.TabIndex = 1;
            this.lblOverdueDays.Text = "逾期天数：0 天";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.lblFine.Location = new System.Drawing.Point(333, 19);
            this.lblFine.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(146, 19);
            this.lblFine.TabIndex = 2;
            this.lblFine.Text = "逾期费用：0.00 元";
            // 
            // dgvRecent
            // 
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.AllowUserToResizeRows = false;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dgvRecent.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvRecent.ColumnHeadersHeight = 38;
            this.dgvRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReturnNo,
            this.colBarcode,
            this.colTitle,
            this.colBorrower,
            this.colReturnDate,
            this.colState});
            this.dgvRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecent.EnableHeadersVisualStyles = false;
            this.dgvRecent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.dgvRecent.Location = new System.Drawing.Point(10, 254);
            this.dgvRecent.MultiSelect = false;
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.RowTemplate.Height = 34;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.Size = new System.Drawing.Size(960, 316);
            this.dgvRecent.TabIndex = 2;
            // 
            // colReturnNo
            // 
            this.colReturnNo.FillWeight = 100F;
            this.colReturnNo.HeaderText = "还书单号";
            this.colReturnNo.Name = "colReturnNo";
            this.colReturnNo.ReadOnly = true;
            // 
            // colBarcode
            // 
            this.colBarcode.FillWeight = 100F;
            this.colBarcode.HeaderText = "图书条码";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.FillWeight = 160F;
            this.colTitle.HeaderText = "书名";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colBorrower
            // 
            this.colBorrower.FillWeight = 90F;
            this.colBorrower.HeaderText = "借阅人";
            this.colBorrower.Name = "colBorrower";
            this.colBorrower.ReadOnly = true;
            // 
            // colReturnDate
            // 
            this.colReturnDate.FillWeight = 100F;
            this.colReturnDate.HeaderText = "归还日期";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.FillWeight = 100F;
            this.colState.HeaderText = "状态";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.lblTip);
            this.pnlBottom.Controls.Add(this.btnConfirmReturn);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(10, 570);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(960, 60);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(133)))));
            this.lblTip.Location = new System.Drawing.Point(18, 22);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(260, 17);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "提示：扫条码后自动带出借阅记录";
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnConfirmReturn.FlatAppearance.BorderSize = 0;
            this.btnConfirmReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReturn.ForeColor = System.Drawing.Color.White;
            this.btnConfirmReturn.Location = new System.Drawing.Point(418, 13);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(124, 34);
            this.btnConfirmReturn.TabIndex = 1;
            this.btnConfirmReturn.Text = "确认还书";
            this.btnConfirmReturn.UseVisualStyleBackColor = false;
            // 
            // FrmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(980, 640);
            this.Controls.Add(this.dgvRecent);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.gbOverdue);
            this.Controls.Add(this.gbReturn);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(860, 580);
            this.Name = "FrmReturnBook";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "还书登记";
            this.gbReturn.ResumeLayout(false);
            this.tlpReturn.ResumeLayout(false);
            this.tlpReturn.PerformLayout();
            this.gbOverdue.ResumeLayout(false);
            this.flpOverdue.ResumeLayout(false);
            this.flpOverdue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbReturn;
        private System.Windows.Forms.TableLayoutPanel tlpReturn;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnScanBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.TextBox txtBorrower;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.TextBox txtBorrowDate;
        private System.Windows.Forms.GroupBox gbOverdue;
        private System.Windows.Forms.FlowLayoutPanel flpOverdue;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblOverdueDays;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnConfirmReturn;
    }
}
