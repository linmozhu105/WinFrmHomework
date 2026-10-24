namespace WindowsFormsLibrarySystem
{
    partial class FrmReaderLoss
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
            this.gbLoss = new System.Windows.Forms.GroupBox();
            this.tlpLoss = new System.Windows.Forms.TableLayoutPanel();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblLossDate = new System.Windows.Forms.Label();
            this.dtpLossDate = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.pnlFormBtns = new System.Windows.Forms.Panel();
            this.btnLoss = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbRecord = new System.Windows.Forms.GroupBox();
            this.dgvLoss = new System.Windows.Forms.DataGridView();
            this.colLossNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLossDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbLoss.SuspendLayout();
            this.tlpLoss.SuspendLayout();
            this.pnlFormBtns.SuspendLayout();
            this.gbRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbLoss);
            this.splitContainer1.Panel1.Controls.Add(this.pnlFormBtns);
            this.splitContainer1.Panel1MinSize = 380;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbRecord);
            this.splitContainer1.Size = new System.Drawing.Size(960, 600);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbLoss
            // 
            this.gbLoss.BackColor = System.Drawing.Color.White;
            this.gbLoss.Controls.Add(this.tlpLoss);
            this.gbLoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLoss.Location = new System.Drawing.Point(0, 0);
            this.gbLoss.Name = "gbLoss";
            this.gbLoss.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbLoss.Size = new System.Drawing.Size(420, 542);
            this.gbLoss.TabIndex = 0;
            this.gbLoss.TabStop = false;
            this.gbLoss.Text = "挂失登记";
            // 
            // tlpLoss
            // 
            this.tlpLoss.ColumnCount = 2;
            this.tlpLoss.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpLoss.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLoss.Controls.Add(this.lblCardNo, 0, 0);
            this.tlpLoss.Controls.Add(this.txtCardNo, 1, 0);
            this.tlpLoss.Controls.Add(this.lblName, 0, 1);
            this.tlpLoss.Controls.Add(this.txtName, 1, 1);
            this.tlpLoss.Controls.Add(this.lblType, 0, 2);
            this.tlpLoss.Controls.Add(this.txtType, 1, 2);
            this.tlpLoss.Controls.Add(this.lblLossDate, 0, 3);
            this.tlpLoss.Controls.Add(this.dtpLossDate, 1, 3);
            this.tlpLoss.Controls.Add(this.lblReason, 0, 4);
            this.tlpLoss.Controls.Add(this.txtReason, 1, 4);
            this.tlpLoss.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpLoss.Location = new System.Drawing.Point(11, 24);
            this.tlpLoss.Name = "tlpLoss";
            this.tlpLoss.Padding = new System.Windows.Forms.Padding(6, 10, 6, 6);
            this.tlpLoss.RowCount = 5;
            this.tlpLoss.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpLoss.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpLoss.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpLoss.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpLoss.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tlpLoss.Size = new System.Drawing.Size(398, 322);
            this.tlpLoss.TabIndex = 0;
            // 
            // lblCardNo
            // 
            this.lblCardNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(20, 25);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(80, 17);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "读者证号：";
            this.lblCardNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardNo.Location = new System.Drawing.Point(109, 21);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(280, 25);
            this.txtCardNo.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(109, 65);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(280, 25);
            this.txtName.TabIndex = 3;
            this.txtName.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(28, 113);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(72, 17);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "读者类型：";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Location = new System.Drawing.Point(109, 109);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(280, 25);
            this.txtType.TabIndex = 5;
            this.txtType.TabStop = false;
            // 
            // lblLossDate
            // 
            this.lblLossDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLossDate.AutoSize = true;
            this.lblLossDate.Location = new System.Drawing.Point(28, 157);
            this.lblLossDate.Name = "lblLossDate";
            this.lblLossDate.Size = new System.Drawing.Size(72, 17);
            this.lblLossDate.TabIndex = 6;
            this.lblLossDate.Text = "挂失日期：";
            this.lblLossDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpLossDate
            // 
            this.dtpLossDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpLossDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLossDate.Location = new System.Drawing.Point(109, 153);
            this.dtpLossDate.Name = "dtpLossDate";
            this.dtpLossDate.Size = new System.Drawing.Size(280, 25);
            this.dtpLossDate.TabIndex = 7;
            // 
            // lblReason
            // 
            this.lblReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(28, 191);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(72, 17);
            this.lblReason.TabIndex = 8;
            this.lblReason.Text = "挂失原因：";
            this.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(109, 191);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(280, 116);
            this.txtReason.TabIndex = 9;
            // 
            // pnlFormBtns
            // 
            this.pnlFormBtns.BackColor = System.Drawing.Color.White;
            this.pnlFormBtns.Controls.Add(this.btnLoss);
            this.pnlFormBtns.Controls.Add(this.btnCancel);
            this.pnlFormBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormBtns.Location = new System.Drawing.Point(0, 542);
            this.pnlFormBtns.Name = "pnlFormBtns";
            this.pnlFormBtns.Size = new System.Drawing.Size(420, 58);
            this.pnlFormBtns.TabIndex = 1;
            // 
            // btnLoss
            // 
            this.btnLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.btnLoss.FlatAppearance.BorderSize = 0;
            this.btnLoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoss.ForeColor = System.Drawing.Color.White;
            this.btnLoss.Location = new System.Drawing.Point(88, 12);
            this.btnLoss.Name = "btnLoss";
            this.btnLoss.Size = new System.Drawing.Size(120, 34);
            this.btnLoss.TabIndex = 0;
            this.btnLoss.Text = "确认挂失";
            this.btnLoss.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancel.Location = new System.Drawing.Point(218, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // gbRecord
            // 
            this.gbRecord.BackColor = System.Drawing.Color.White;
            this.gbRecord.Controls.Add(this.dgvLoss);
            this.gbRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRecord.Location = new System.Drawing.Point(0, 0);
            this.gbRecord.Name = "gbRecord";
            this.gbRecord.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbRecord.Size = new System.Drawing.Size(534, 600);
            this.gbRecord.TabIndex = 0;
            this.gbRecord.TabStop = false;
            this.gbRecord.Text = "挂失记录";
            // 
            // dgvLoss
            // 
            this.dgvLoss.AllowUserToAddRows = false;
            this.dgvLoss.AllowUserToDeleteRows = false;
            this.dgvLoss.AllowUserToResizeRows = false;
            this.dgvLoss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoss.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoss.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoss.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dgvLoss.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvLoss.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvLoss.ColumnHeadersHeight = 38;
            this.dgvLoss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLossNo,
            this.colCardNo,
            this.colName,
            this.colLossDate,
            this.colReason,
            this.colOperator});
            this.dgvLoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoss.EnableHeadersVisualStyles = false;
            this.dgvLoss.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.dgvLoss.Location = new System.Drawing.Point(8, 24);
            this.dgvLoss.MultiSelect = false;
            this.dgvLoss.Name = "dgvLoss";
            this.dgvLoss.ReadOnly = true;
            this.dgvLoss.RowHeadersVisible = false;
            this.dgvLoss.RowTemplate.Height = 34;
            this.dgvLoss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoss.Size = new System.Drawing.Size(518, 570);
            this.dgvLoss.TabIndex = 0;
            // 
            // colLossNo
            // 
            this.colLossNo.FillWeight = 100F;
            this.colLossNo.HeaderText = "挂失单号";
            this.colLossNo.Name = "colLossNo";
            this.colLossNo.ReadOnly = true;
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
            // colLossDate
            // 
            this.colLossDate.FillWeight = 100F;
            this.colLossDate.HeaderText = "挂失时间";
            this.colLossDate.Name = "colLossDate";
            this.colLossDate.ReadOnly = true;
            // 
            // colReason
            // 
            this.colReason.FillWeight = 150F;
            this.colReason.HeaderText = "挂失原因";
            this.colReason.Name = "colReason";
            this.colReason.ReadOnly = true;
            // 
            // colOperator
            // 
            this.colOperator.FillWeight = 80F;
            this.colOperator.HeaderText = "操作员";
            this.colOperator.Name = "colOperator";
            this.colOperator.ReadOnly = true;
            // 
            // FrmReaderLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(860, 540);
            this.Name = "FrmReaderLoss";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "读者挂失";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbLoss.ResumeLayout(false);
            this.tlpLoss.ResumeLayout(false);
            this.tlpLoss.PerformLayout();
            this.pnlFormBtns.ResumeLayout(false);
            this.gbRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoss)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbLoss;
        private System.Windows.Forms.TableLayoutPanel tlpLoss;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblLossDate;
        private System.Windows.Forms.DateTimePicker dtpLossDate;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Panel pnlFormBtns;
        private System.Windows.Forms.Button btnLoss;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbRecord;
        private System.Windows.Forms.DataGridView dgvLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLossNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLossDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperator;
    }
}
