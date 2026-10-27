using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsGaoJiChuangti
{
    /// <summary>
    /// 课堂练习二：设备详情视图展示。
    /// 界面分两块：顶部是条件查询区（品牌 / 区域 / 机器编号），
    /// 下方是五列的明细列表，每行首列左侧带一个品牌图标。
    ///
    /// 数据流向固定为三段：
    /// 静态数据集合 allDevices → 按条件筛选得到临时集合 → FillListView 画到控件上。
    /// 查询不修改原始集合，每次都是重新筛一遍，所以连续查询不会丢数据。
    /// </summary>
    public partial class FrmDeviceDetail : Form
    {
        /// <summary>
        /// 保存全部设备记录。
        /// 用 List&lt;T&gt; 而不用数组，是因为集合可以随时 Add，不必事先确定条数。
        /// 这个字段是"唯一数据源"，界面上的行只是它的一次投影。
        /// </summary>
        private List<DeviceInfo> allDevices = new List<DeviceInfo>();

        public FrmDeviceDetail()
        {
            InitializeComponent();
        }

        #region 一、准备数据

        /// <summary>
        /// 课程阶段还没有数据库，先用代码把 8 条记录写死，称为静态数据。
        /// 将来接数据库时，只有本方法需要改成从表里读，其余代码一行不用动。
        /// </summary>
        private void InitDevices()
        {
            allDevices.Add(new DeviceInfo { Code = "101", Brand = "联想", Area = "A区", State = "空闲", BuyDate = new DateTime(2021, 4, 10) });
            allDevices.Add(new DeviceInfo { Code = "102", Brand = "同方", Area = "B区", State = "空闲", BuyDate = new DateTime(2021, 4, 10) });
            allDevices.Add(new DeviceInfo { Code = "103", Brand = "联想", Area = "C区", State = "空闲", BuyDate = new DateTime(2021, 4, 10) });
            allDevices.Add(new DeviceInfo { Code = "104", Brand = "联想", Area = "B区", State = "空闲", BuyDate = new DateTime(2021, 4, 10) });
            allDevices.Add(new DeviceInfo { Code = "105", Brand = "同方", Area = "Vip区", State = "使用中", BuyDate = new DateTime(2021, 4, 10) });
            allDevices.Add(new DeviceInfo { Code = "106", Brand = "同方", Area = "B区", State = "空闲", BuyDate = new DateTime(2021, 4, 10) });
            allDevices.Add(new DeviceInfo { Code = "107", Brand = "同方", Area = "C区", State = "空闲", BuyDate = new DateTime(2021, 4, 10) });
            allDevices.Add(new DeviceInfo { Code = "108", Brand = "同方", Area = "A区", State = "空闲", BuyDate = new DateTime(2021, 4, 10) });
        }

        /// <summary>
        /// 给两个下拉框装选项。
        /// 第一项统一是"全部"，作为"此条件不作限制"的标记值，
        /// 比用空字符串更直观，用户看得懂，代码里判断也清楚。
        /// </summary>
        private void InitComboBoxes()
        {
            cboBrand.Items.Add("全部");
            cboBrand.Items.Add("联想");
            cboBrand.Items.Add("同方");
            cboBrand.SelectedIndex = 0;

            cboArea.Items.Add("全部");
            cboArea.Items.Add("A区");
            cboArea.Items.Add("B区");
            cboArea.Items.Add("C区");
            cboArea.Items.Add("D区");
            cboArea.Items.Add("Vip区");
            cboArea.SelectedIndex = 0;
        }

        #endregion

        #region 二、把数据画到列表上

        /// <summary>
        /// 把一组设备记录逐行填入 ListView。
        /// 独立成方法的原因：窗体加载和点击查询都要用，
        /// 抽出来以后只需维护一份，改列顺序时不会漏改。
        /// </summary>
        /// <param name="list">要显示的数据集合，可以是全集，也可以是筛选后的子集</param>
        private void FillListView(List<DeviceInfo> list)
        {
            // BeginUpdate / EndUpdate 之间暂停重绘，
            // 批量添加时既不闪烁，速度也更快
            lvDevice.BeginUpdate();
            try
            {
                // 先清空旧行，否则重复查询会把新结果追加在后面，看起来像数据翻倍
                lvDevice.Items.Clear();

                foreach (DeviceInfo device in list)
                {
                    // 构造函数里的参数就是第一列（索引 0）
                    ListViewItem item = new ListViewItem(device.Code);

                    // 从第二列起用 SubItems.Add 追加。
                    // 注意：SubItems[0] 就是第一列本身，所以这里不能再加一次编号，
                    // 否则整行数据会右移一列，列头与内容全部错位
                    item.SubItems.Add(device.Brand);
                    item.SubItems.Add(device.Area);
                    item.SubItems.Add(device.State);
                    // 日期格式串：yyyy 四位年、M 不补零月、d 不补零日、
                    // H 24 小时制不补零小时，输出形如 2021/4/10 0:00:00
                    item.SubItems.Add(device.BuyDate.ToString("yyyy/M/d H:mm:ss"));

                    // 图标显示在第一列文字左侧，索引指向 SmallImageList 里的位置
                    item.ImageIndex = GetBrandImageIndex(device.Brand);

                    lvDevice.Items.Add(item);
                }
            }
            finally
            {
                // 放在 finally 里，保证即使循环中途出错也能恢复重绘，
                // 否则控件会一直停在挂起状态，之后怎么改都看不到变化
                lvDevice.EndUpdate();
            }
        }

        /// <summary>
        /// 由品牌名换算图标在 ImageList 中的索引。
        /// 用键名反查索引，比直接写死 0 和 1 稳妥：
        /// 以后在图片集合里调整顺序、插入新图，这里都不用改。
        /// </summary>
        /// <param name="brand">品牌名称</param>
        /// <returns>图标索引；键名不存在时返回 -1，图标位置会是空白</returns>
        private int GetBrandImageIndex(string brand)
        {
            if (brand == "联想")
            {
                return imageList1.Images.IndexOfKey("Lenovo.png");
            }
            return imageList1.Images.IndexOfKey("tongfang.png");
        }

        /// <summary>
        /// 窗体加载：按依赖顺序依次做三件事。
        /// 顺序不能随意调换——先装选项才能默认选中，先装数据才能填充列表。
        /// </summary>
        private void FrmDeviceDetail_Load(object sender, EventArgs e)
        {
            InitComboBoxes();          // 第一步：下拉框有选项
            InitDevices();             // 第二步：数据集合有记录
            FillListView(allDevices);  // 第三步：把全集画出来
        }

        #endregion

        #region 三、按条件查询

        /// <summary>
        /// 点击查询：按品牌、区域、机器编号三个条件筛选。
        /// 任一条件为"全部"或留空，表示该项不参与筛选，实现条件的自由组合。
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            // 下拉框取到的是 object，需要转成字符串比较；
            // SelectedItem 一定不为 null，因为 InitComboBoxes 里已设过 SelectedIndex
            string brand = cboBrand.SelectedItem.ToString();
            string area = cboArea.SelectedItem.ToString();
            // Trim 去掉用户可能带上的首尾空格，避免输入" 101 "查不到 101
            string code = txtCode.Text.Trim();

            // 临时集合，只装本次符合条件的记录，不改动 allDevices
            List<DeviceInfo> result = new List<DeviceInfo>();

            foreach (DeviceInfo device in allDevices)
            {
                // 每个条件都写成"条件未指定 或 满足"，不满足就 continue 跳过。
                // 这样写比层层嵌套 if 更清晰，增删条件都只影响一行
                if (brand != "全部" && device.Brand != brand)
                {
                    continue;
                }
                if (area != "全部" && device.Area != area)
                {
                    continue;
                }
                // 编号采用模糊匹配：只要包含输入内容就算命中，空串视为不限制。
                // 用 IndexOf 不用 Contains，因为后者属于 LINQ 扩展方法，课程尚未涉及
                if (code.Length > 0 && device.Code.IndexOf(code) < 0)
                {
                    continue;
                }
                result.Add(device);
            }

            // 把筛选结果交给同一个填充方法显示
            FillListView(result);

            // 结果为空时给出提示，否则用户无法区分"没有符合的记录"和"程序没反应"
            if (result.Count == 0)
            {
                MessageBox.Show("没有符合条件的设备。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
