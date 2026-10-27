using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsGaoJiChuangti
{
    /// <summary>
    /// 课堂练习七：设备监控窗体。
    /// 用两个 Timer 分工：一个每秒刷新时间，一个每 1.5 秒推进画面轮播。
    /// </summary>
    public partial class FrmMonitor : Form
    {
        /// <summary>
        /// 当前轮播的起始画面索引。
        /// 必须定义在类级别（字段），不能写在 Tick 方法内部，
        /// 否则每次触发都会重新创建并归零，画面永远停在第一张。
        /// </summary>
        private int index = 0;

        public FrmMonitor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载：先准备图片，再设定两个计时器的间隔并启动。
        /// 图片必须先就位，否则第一次 Tick 取到的 Images 集合是空的。
        /// </summary>
        private void FrmMonitor_Load(object sender, EventArgs e)
        {
            InitImages();

            // Interval 的单位是毫秒，属性面板没设，这里统一给出，代码更有据可查
            tmrTime.Interval = 1000;      // 1 秒刷新一次时间
            tmrComputer.Interval = 1500;  // 1.5 秒推进一次轮播

            tmrTime.Start();
            tmrComputer.Start();
        }

        #region 一、准备监控画面

        /// <summary>
        /// 把 4 张监控画面装进 ImageList。
        /// 这里用绘图代码生成，避免依赖外部图片文件；
        /// 若改用真实照片，把循环体换成下列语句即可：
        /// ilComputer.Images.Add(Image.FromFile(@"D:\img\cam1.jpg"));
        /// 注意 ImageList 的 ImageSize 必须与画面尺寸一致，且必须在加图之前设好。
        /// </summary>
        private void InitImages()
        {
            for (int no = 1; no <= 4; no++)
            {
                ilComputer.Images.Add(CreateMonitorImage(no));
            }
        }

        /// <summary>
        /// 画一张模拟的监控画面：深色背景、通道号、录制指示点、底部信息条。
        /// </summary>
        /// <param name="no">通道编号，1 到 4</param>
        private Image CreateMonitorImage(int no)
        {
            Bitmap bmp = new Bitmap(240, 180);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // 抗锯齿，否则文字和圆点边缘会有毛刺
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                // 背景：深灰蓝纵向渐变，模拟机房弱光环境
                using (LinearGradientBrush background = new LinearGradientBrush(
                    new Rectangle(0, 0, 240, 180),
                    Color.FromArgb(46, 54, 66),
                    Color.FromArgb(22, 26, 32),
                    LinearGradientMode.Vertical))
                {
                    g.FillRectangle(background, 0, 0, 240, 180);
                }

                // 中央：机器编号
                using (Font font = new Font("微软雅黑", 22F, FontStyle.Bold))
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(205, 220, 238)))
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    g.DrawString(no + " 号机", font, brush,
                        new RectangleF(0, 46, 240, 60), format);
                }

                // 左上角：录制指示红点与 REC 字样
                using (SolidBrush red = new SolidBrush(Color.FromArgb(232, 68, 68)))
                {
                    g.FillEllipse(red, 12, 12, 8, 8);
                }
                using (Font font = new Font("Arial", 8F))
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(210, 210, 210)))
                {
                    g.DrawString("REC", font, brush, 24, 10);
                }

                // 右上角：通道号
                using (Font font = new Font("Arial", 8F))
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(140, 165, 190)))
                {
                    g.DrawString("CAM-0" + no, font, brush, 186, 10);
                }

                // 底部信息条：先铺半透明黑条，再写文字
                using (SolidBrush bar = new SolidBrush(Color.FromArgb(140, 0, 0, 0)))
                {
                    g.FillRectangle(bar, 0, 152, 240, 28);
                }
                using (Font font = new Font("微软雅黑", 8F))
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(190, 205, 218)))
                {
                    g.DrawString("通道 0" + no + "　在线", font, brush, 12, 157);
                }

                // 外框：一圈浅蓝细线，让四个画面边界清晰
                using (Pen pen = new Pen(Color.FromArgb(90, 160, 220), 1F))
                {
                    g.DrawRectangle(pen, 0, 0, 239, 179);
                }
            }

            return bmp;
        }

        #endregion

        #region 二、两个计时器的 Tick 事件

        /// <summary>
        /// 每 1 秒触发一次：把当前时间写到标签上。
        /// DateTime.Now.ToString() 会按系统区域格式输出完整的日期和时间。
        /// </summary>
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lbTimeMeg.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 每 1.5 秒触发一次：索引前进一格，四个画面依次显示 index、index+1、index+2、index+3。
        /// 取模运算保证索引绕回 0，不会越界。
        /// </summary>
        private void tmrComputer_Tick(object sender, EventArgs e)
        {
            int count = ilComputer.Images.Count;

            // 集合为空时直接返回，避免除零和取图异常
            if (count == 0)
            {
                return;
            }

            // 推进一格，到达末尾自动回到 0
            index = (index + 1) % count;

            // 四个画面错开显示，形成轮流滚动的效果
            pb1.Image = ilComputer.Images[index];
            pb2.Image = ilComputer.Images[(index + 1) % count];
            pb3.Image = ilComputer.Images[(index + 2) % count];
            pb4.Image = ilComputer.Images[(index + 3) % count];
        }

        #endregion
    }
}
