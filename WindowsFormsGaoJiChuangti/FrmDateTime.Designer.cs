namespace WindowsFormsGaoJiChuangti
{
    partial class FrmDateTime
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblText = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy年MM月dd日";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(145, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 23);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(24, 100);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(104, 15);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text属性获取：";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(152, 96);
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(150, 25);
            this.txtText.TabIndex = 2;
            this.txtText.TabStop = false;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(24, 150);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(116, 15);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "Value属性获取：";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(152, 146);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(70, 25);
            this.txtYear.TabIndex = 4;
            this.txtYear.TabStop = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(226, 150);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(20, 15);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "年";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(248, 146);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.ReadOnly = true;
            this.txtMonth.Size = new System.Drawing.Size(50, 25);
            this.txtMonth.TabIndex = 6;
            this.txtMonth.TabStop = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(302, 150);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(20, 15);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "月";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(326, 146);
            this.txtDay.Name = "txtDay";
            this.txtDay.ReadOnly = true;
            this.txtDay.Size = new System.Drawing.Size(50, 25);
            this.txtDay.TabIndex = 8;
            this.txtDay.TabStop = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(380, 150);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(20, 15);
            this.lblDay.TabIndex = 9;
            this.lblDay.Text = "日";
            // 
            // FrmDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 200);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.dtpDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "练习五 DateTimePicker 控件";
            this.Load += new System.EventHandler(this.FrmDateTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lblDay;
    }
}
