namespace WindowsFormsGaoJiChuangti
{
    partial class FrmMonitor
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
            this.lbTimeTitle = new System.Windows.Forms.Label();
            this.lbTimeMeg = new System.Windows.Forms.Label();
            this.gbMonitor = new System.Windows.Forms.GroupBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.ilComputer = new System.Windows.Forms.ImageList(this.components);
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tmrComputer = new System.Windows.Forms.Timer(this.components);
            this.gbMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTimeTitle
            // 
            this.lbTimeTitle.AutoSize = true;
            this.lbTimeTitle.Location = new System.Drawing.Point(24, 26);
            this.lbTimeTitle.Name = "lbTimeTitle";
            this.lbTimeTitle.Size = new System.Drawing.Size(76, 15);
            this.lbTimeTitle.TabIndex = 0;
            this.lbTimeTitle.Text = "当前时间：";
            // 
            // lbTimeMeg
            // 
            this.lbTimeMeg.AutoSize = true;
            this.lbTimeMeg.Location = new System.Drawing.Point(114, 26);
            this.lbTimeMeg.Name = "lbTimeMeg";
            this.lbTimeMeg.Size = new System.Drawing.Size(76, 15);
            this.lbTimeMeg.TabIndex = 1;
            this.lbTimeMeg.Text = "加载时间中";
            // 
            // gbMonitor
            // 
            this.gbMonitor.Controls.Add(this.pb4);
            this.gbMonitor.Controls.Add(this.pb3);
            this.gbMonitor.Controls.Add(this.pb2);
            this.gbMonitor.Controls.Add(this.pb1);
            this.gbMonitor.Location = new System.Drawing.Point(20, 56);
            this.gbMonitor.Name = "gbMonitor";
            this.gbMonitor.Size = new System.Drawing.Size(540, 424);
            this.gbMonitor.TabIndex = 2;
            this.gbMonitor.TabStop = false;
            this.gbMonitor.Text = "实时监控";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(20, 24);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(240, 180);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(280, 24);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(240, 180);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(20, 224);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(240, 180);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(280, 224);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(240, 180);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            // 
            // ilComputer
            // 
            this.ilComputer.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ilComputer.ImageSize = new System.Drawing.Size(240, 180);
            this.ilComputer.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 496);
            this.Controls.Add(this.gbMonitor);
            this.Controls.Add(this.lbTimeMeg);
            this.Controls.Add(this.lbTimeTitle);
            this.Name = "FrmMonitor";
            this.Text = "设备监控";
            this.Load += new System.EventHandler(this.FrmMonitor_Load);
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            this.tmrComputer.Tick += new System.EventHandler(this.tmrComputer_Tick);
            this.gbMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimeTitle;
        private System.Windows.Forms.Label lbTimeMeg;
        private System.Windows.Forms.GroupBox gbMonitor;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.ImageList ilComputer;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Timer tmrComputer;
    }
}
