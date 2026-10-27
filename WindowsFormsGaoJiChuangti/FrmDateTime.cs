using System;
using System.Windows.Forms;

namespace WindowsFormsGaoJiChuangti
{
    /// <summary>
    /// 课堂练习五：DateTimePicker 控件练习。
    /// 上方一个自定义格式的日期控件，下方对照演示两种取值方式：
    /// Text 取排版好的完整字符串，Value 取年月日各个组成部分。
    /// </summary>
    public partial class FrmDateTime : Form
    {
        public FrmDateTime()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载时先设定显示格式，再显示一次取值结果。
        /// 注意 Format 与 CustomFormat 的配合关系：CustomFormat 只在
        /// Format 等于 Custom 时才会生效，两者缺一，日期都按系统默认格式显示。
        /// </summary>
        private void FrmDateTime_Load(object sender, EventArgs e)
        {
            // Custom 表示"按自定义格式串排版"
            dtpDate.Format = DateTimePickerFormat.Custom;
            // 格式串里的"年""月""日"不是格式符，会原样输出
            dtpDate.CustomFormat = "yyyy年MM月dd日";

            ShowDateParts();
        }

        /// <summary>
        /// 用户改变选中日期时重新取值，让下方文本框实时跟随。
        /// 若只写在 Load 里，拖动日历后文本框会停在上次窗体打开时的那一天。
        /// </summary>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ShowDateParts();
        }

        /// <summary>
        /// 两种取值方式的对照演示，抽成独立方法供 Load 与 ValueChanged 共用。
        /// Text：已经按 CustomFormat 排好版的字符串，可直接显示；
        /// Value：DateTime 结构体，年月日时分秒各自独立，需要哪部分取哪部分。
        /// </summary>
        private void ShowDateParts()
        {
            // Text 属性返回的是"显示出来的样子"，格式改了它会跟着变
            txtText.Text = dtpDate.Text;

            // Value 是结构化的日期对象，不受显示格式影响
            // Year / Month / Day 返回 int，赋给 TextBox 必须显式 ToString
            txtYear.Text = dtpDate.Value.Year.ToString();
            txtMonth.Text = dtpDate.Value.Month.ToString();
            txtDay.Text = dtpDate.Value.Day.ToString();
        }
    }
}
