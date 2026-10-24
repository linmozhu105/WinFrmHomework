namespace WindowsFormsLibrarySystem
{
    partial class FrmBorrowRegister
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
            this.gbReader = new System.Windows.Forms.GroupBox();
            this.tlpReader = new System.Windows.Forms.TableLayoutPanel();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.btnScanCard = new System.Windows.Forms.Button();
            this.lblReaderInfo = new System.Windows.Forms.Label();
            this.txtReaderInfo = new System.Windows.Forms.TextBox();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.tlpBook = new System.Windows.Forms.TableLayoutPanel();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnScanBook = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.dgvBorrowList = new System.Windows.Forms.DataGridView();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbReader.SuspendLayout();
            this.tlpReader.SuspendLayout();
            this.gbBook.SuspendLayout();
            this.tlpBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReader
            // 
            this.gbReader.BackColor = System.Drawing.Color.White;
            this.gbReader.Controls.Add(this.tlpReader);
            this.gbReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbReader.Location = new System.Drawing.Point(10, 10);
            this.gbReader.Name = "gbReader";
            this.gbReader.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbReader.Size = new System.Drawing.Size(960, 124);
            this.gbReader.TabIndex = 0;
            this.gbReader.TabStop = false;
            this.gbReader.Text = "读者信息";
            // 
            // tlpReader
            // 
            this.tlpReader.ColumnCount = 3;
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpReader.Controls.Add(this.lblCardNo, 0, 0);
            this.tlpReader.Controls.Add(this.txtCardNo, 1, 0);
            this.tlpReader.Controls.Add(this.btnScanCard, 2, 0);
            this.tlpReader.Controls.Add(this.lblReaderInfo, 0, 1);
            this.tlpReader.Controls.Add(this.txtReaderInfo, 1, 1);
            this.tlpReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpReader.Location = new System.Drawing.Point(11, 24);
            this.tlpReader.Name = "tlpReader";
            this.tlpReader.Padding = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.tlpReader.RowCount = 2;
            this.tlpReader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpReader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpReader.SetColumnSpan(this.txtReaderInfo, 2);
            this.tlpReader.Size = new System.Drawing.Size(938, 94);
            this.tlpReader.TabIndex = 0;
            // 
            // lblCardNo
            // 
            this.lblCardNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(10, 18);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(80, 17);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "读者证号：";
            this.lblCardNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardNo.Location = new System.Drawing.Point(97, 14);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(720, 25);
            this.txtCardNo.TabIndex = 1;
            // 
            // btnScanCard
            // 
            this.btnScanCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnScanCard.FlatAppearance.BorderSize = 0;
            this.btnScanCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanCard.ForeColor = System.Drawing.Color.White;
            this.btnScanCard.Location = new System.Drawing.Point(823, 10);
            this.btnScanCard.Name = "btnScanCard";
            this.btnScanCard.Size = new System.Drawing.Size(96, 32);
            this.btnScanCard.TabIndex = 2;
            this.btnScanCard.Text = "扫码";
            this.btnScanCard.UseVisualStyleBackColor = false;
            // 
            // lblReaderInfo
            // 
            this.lblReaderInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReaderInfo.AutoSize = true;
            this.lblReaderInfo.Location = new System.Drawing.Point(10, 56);
            this.lblReaderInfo.Name = "lblReaderInfo";
            this.lblReaderInfo.Size = new System.Drawing.Size(80, 17);
            this.lblReaderInfo.TabIndex = 3;
            this.lblReaderInfo.Text = "姓名类型：";
            this.lblReaderInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReaderInfo
            // 
            this.txtReaderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReaderInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtReaderInfo.Location = new System.Drawing.Point(97, 52);
            this.txtReaderInfo.Name = "txtReaderInfo";
            this.txtReaderInfo.ReadOnly = true;
            this.txtReaderInfo.Size = new System.Drawing.Size(822, 25);
            this.txtReaderInfo.TabIndex = 4;
            this.txtReaderInfo.TabStop = false;
            // 
            // gbBook
            // 
            this.gbBook.BackColor = System.Drawing.Color.White;
            this.gbBook.Controls.Add(this.tlpBook);
            this.gbBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBook.Location = new System.Drawing.Point(10, 134);
            this.gbBook.Name = "gbBook";
            this.gbBook.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbBook.Size = new System.Drawing.Size(960, 124);
            this.gbBook.TabIndex = 1;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "图书信息";
            // 
            // tlpBook
            // 
            this.tlpBook.ColumnCount = 3;
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpBook.Controls.Add(this.lblBarCode, 0, 0);
            this.tlpBook.Controls.Add(this.txtBarCode, 1, 0);
            this.tlpBook.Controls.Add(this.btnScanBook, 2, 0);
            this.tlpBook.Controls.Add(this.lblBookName, 0, 1);
            this.tlpBook.Controls.Add(this.txtBookName, 1, 1);
            this.tlpBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBook.Location = new System.Drawing.Point(11, 24);
            this.tlpBook.Name = "tlpBook";
            this.tlpBook.Padding = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.tlpBook.RowCount = 2;
            this.tlpBook.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpBook.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpBook.SetColumnSpan(this.txtBookName, 2);
            this.tlpBook.Size = new System.Drawing.Size(938, 94);
            this.tlpBook.TabIndex = 0;
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
            this.txtBarCode.Size = new System.Drawing.Size(720, 25);
            this.txtBarCode.TabIndex = 1;
            // 
            // btnScanBook
            // 
            this.btnScanBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnScanBook.FlatAppearance.BorderSize = 0;
            this.btnScanBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanBook.ForeColor = System.Drawing.Color.White;
            this.btnScanBook.Location = new System.Drawing.Point(823, 10);
            this.btnScanBook.Name = "btnScanBook";
            this.btnScanBook.Size = new System.Drawing.Size(96, 32);
            this.btnScanBook.TabIndex = 2;
            this.btnScanBook.Text = "扫码";
            this.btnScanBook.UseVisualStyleBackColor = false;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(44, 56);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(46, 17);
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Text = "书名：";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtBookName.Location = new System.Drawing.Point(97, 52);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(822, 25);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.TabStop = false;
            // 
            // dgvBorrowList
            // 
            this.dgvBorrowList.AllowUserToAddRows = false;
            this.dgvBorrowList.AllowUserToDeleteRows = false;
            this.dgvBorrowList.AllowUserToResizeRows = false;
            this.dgvBorrowList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowList.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorrowList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBorrowList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBorrowList.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dgvBorrowList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvBorrowList.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvBorrowList.ColumnHeadersHeight = 38;
            this.dgvBorrowList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarcode,
            this.colTitle,
            this.colCategory,
            this.colBorrowDate,
            this.colDueDate});
            this.dgvBorrowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowList.EnableHeadersVisualStyles = false;
            this.dgvBorrowList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.dgvBorrowList.Location = new System.Drawing.Point(10, 258);
            this.dgvBorrowList.MultiSelect = false;
            this.dgvBorrowList.Name = "dgvBorrowList";
            this.dgvBorrowList.ReadOnly = true;
            this.dgvBorrowList.RowHeadersVisible = false;
            this.dgvBorrowList.RowTemplate.Height = 34;
            this.dgvBorrowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowList.Size = new System.Drawing.Size(960, 312);
            this.dgvBorrowList.TabIndex = 2;
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
            // colCategory
            // 
            this.colCategory.FillWeight = 80F;
            this.colCategory.HeaderText = "分类";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
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
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.lblCount);
            this.pnlBottom.Controls.Add(this.btnFinish);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(10, 570);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(960, 60);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblCount.Location = new System.Drawing.Point(18, 20);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(120, 19);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "已借数量：0/5";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(676, 13);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(120, 34);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "完成借书";
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancel.Location = new System.Drawing.Point(806, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FrmBorrowRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(980, 640);
            this.Controls.Add(this.dgvBorrowList);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.gbReader);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(860, 560);
            this.Name = "FrmBorrowRegister";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "借书登记";
            this.gbReader.ResumeLayout(false);
            this.tlpReader.ResumeLayout(false);
            this.tlpReader.PerformLayout();
            this.gbBook.ResumeLayout(false);
            this.tlpBook.ResumeLayout(false);
            this.tlpBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbReader;
        private System.Windows.Forms.TableLayoutPanel tlpReader;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Button btnScanCard;
        private System.Windows.Forms.Label lblReaderInfo;
        private System.Windows.Forms.TextBox txtReaderInfo;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.TableLayoutPanel tlpBook;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnScanBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.DataGridView dgvBorrowList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
    }
}
