namespace WindowsFormsLibrarySystem
{
    partial class FrmReaderFile
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
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.flpTool = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.colCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbQuery.SuspendLayout();
            this.tlpQuery.SuspendLayout();
            this.pnlTool.SuspendLayout();
            this.flpTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
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
            this.gbQuery.Size = new System.Drawing.Size(940, 126);
            this.gbQuery.TabIndex = 0;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "查询条件";
            // 
            // tlpQuery
            // 
            this.tlpQuery.ColumnCount = 6;
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpQuery.Controls.Add(this.lblCardNo, 0, 0);
            this.tlpQuery.Controls.Add(this.txtCardNo, 1, 0);
            this.tlpQuery.Controls.Add(this.lblName, 2, 0);
            this.tlpQuery.Controls.Add(this.txtName, 3, 0);
            this.tlpQuery.Controls.Add(this.lblType, 4, 0);
            this.tlpQuery.Controls.Add(this.cboType, 5, 0);
            this.tlpQuery.Controls.Add(this.btnQuery, 4, 1);
            this.tlpQuery.Controls.Add(this.btnReset, 5, 1);
            this.tlpQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpQuery.Location = new System.Drawing.Point(8, 26);
            this.tlpQuery.Name = "tlpQuery";
            this.tlpQuery.Padding = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.tlpQuery.RowCount = 2;
            this.tlpQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpQuery.Size = new System.Drawing.Size(924, 96);
            this.tlpQuery.TabIndex = 0;
            // 
            // lblCardNo
            // 
            this.lblCardNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(37, 8);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(54, 38);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "读者证号：";
            this.lblCardNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardNo.Location = new System.Drawing.Point(97, 13);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(282, 27);
            this.txtCardNo.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(397, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(457, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(282, 27);
            this.txtName.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(765, 8);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 38);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "读者类型：";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Location = new System.Drawing.Point(825, 15);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(90, 28);
            this.cboType.TabIndex = 5;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(745, 54);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(74, 28);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnReset.Location = new System.Drawing.Point(825, 54);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 28);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.White;
            this.pnlTool.Controls.Add(this.btnExport);
            this.pnlTool.Controls.Add(this.flpTool);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(10, 136);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(940, 48);
            this.pnlTool.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(830, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 48);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "⤓  导出Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // flpTool
            // 
            this.flpTool.Controls.Add(this.btnAdd);
            this.flpTool.Controls.Add(this.btnEdit);
            this.flpTool.Controls.Add(this.btnDelete);
            this.flpTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTool.Location = new System.Drawing.Point(0, 0);
            this.flpTool.Name = "flpTool";
            this.flpTool.Padding = new System.Windows.Forms.Padding(2, 8, 2, 6);
            this.flpTool.Size = new System.Drawing.Size(940, 48);
            this.flpTool.TabIndex = 0;
            this.flpTool.WrapContents = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(164)))), ((int)(((byte)(93)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(5, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "＋  新增读者";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(115, 11);
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
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(209, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "✕  删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvReaders
            // 
            this.dgvReaders.AllowUserToAddRows = false;
            this.dgvReaders.AllowUserToDeleteRows = false;
            this.dgvReaders.AllowUserToResizeRows = false;
            this.dgvReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReaders.BackgroundColor = System.Drawing.Color.White;
            this.dgvReaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReaders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReaders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReaders.ColumnHeadersHeight = 38;
            this.dgvReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCardNo,
            this.colName,
            this.colSex,
            this.colType,
            this.colPhone,
            this.colRegDate,
            this.colState});
            this.dgvReaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReaders.EnableHeadersVisualStyles = false;
            this.dgvReaders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.dgvReaders.Location = new System.Drawing.Point(10, 184);
            this.dgvReaders.MultiSelect = false;
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.ReadOnly = true;
            this.dgvReaders.RowHeadersVisible = false;
            this.dgvReaders.RowHeadersWidth = 51;
            this.dgvReaders.RowTemplate.Height = 34;
            this.dgvReaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReaders.Size = new System.Drawing.Size(940, 446);
            this.dgvReaders.TabIndex = 2;
            // 
            // colCardNo
            // 
            this.colCardNo.FillWeight = 110F;
            this.colCardNo.HeaderText = "读者证号";
            this.colCardNo.MinimumWidth = 6;
            this.colCardNo.Name = "colCardNo";
            this.colCardNo.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.FillWeight = 90F;
            this.colName.HeaderText = "姓名";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.FillWeight = 60F;
            this.colSex.HeaderText = "性别";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "读者类型";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.FillWeight = 110F;
            this.colPhone.HeaderText = "联系电话";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colRegDate
            // 
            this.colRegDate.FillWeight = 110F;
            this.colRegDate.HeaderText = "办证日期";
            this.colRegDate.MinimumWidth = 6;
            this.colRegDate.Name = "colRegDate";
            this.colRegDate.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.FillWeight = 80F;
            this.colState.HeaderText = "状态";
            this.colState.MinimumWidth = 6;
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // FrmReaderFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.dgvReaders);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.gbQuery);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 540);
            this.Name = "FrmReaderFile";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "读者档案管理";
            this.gbQuery.ResumeLayout(false);
            this.tlpQuery.ResumeLayout(false);
            this.tlpQuery.PerformLayout();
            this.pnlTool.ResumeLayout(false);
            this.flpTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.TableLayoutPanel tlpQuery;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.FlowLayoutPanel flpTool;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvReaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
    }
}
