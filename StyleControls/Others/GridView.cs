using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Drawing2D;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 格線控制項
    /// </summary>
    public partial class GridView : UserControl
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GridView()
        {
            InitializeComponent();
            this.Font = Helper.Style.Font;
            this.BackColor = Helper.Style.Control.BackColor;

            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.MultiSelect = false;
            dataGridView.ReadOnly = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.BackgroundColor = Helper.GetStyleModeData(StyleMode.Control).BackColor;
            dataGridView.ForeColor = Helper.GetStyleModeData(StyleMode.Control).ForeColor;

            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 64;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 64;
            dataGridView.RowsDefaultCellStyle.BackColor = Helper.GetStyleModeData(StyleMode.Control).BackColor;
            dataGridView.RowsDefaultCellStyle.ForeColor = Helper.GetStyleModeData(StyleMode.Control).ForeColor;
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Helper.GetStyleModeData(StyleMode.HighChroma).BackColor;
            dataGridView.RowsDefaultCellStyle.SelectionForeColor = Helper.GetStyleModeData(StyleMode.HighChroma).ForeColor;
            dataGridView.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            CellPadding = new Padding(4);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (SelectedRowIndex != e.RowIndex)
                {
                    if (Helper.SoundPlayer != null) { Helper.SoundPlayer.Play(Helper.ClickSound); }
                }

                if (RowClick != null) { RowClick(this, EventArgs.Empty); }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (SelectedRowIndex != e.RowIndex)
                {
                    if (Helper.SoundPlayer != null) { Helper.SoundPlayer.Play(Helper.ClickSound); }
                }

                if (RowDoubleClick != null) { RowDoubleClick(this, EventArgs.Empty); }
            }
        }

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            columnData columnData = _columnDatas[dataGridView.Columns[e.ColumnIndex].DataPropertyName];
            if (columnData.Sorted == true)
            {
                if (Helper.SoundPlayer != null) { Helper.SoundPlayer.Play(Helper.ClickSound); }
                if (_sortingKey == columnData.SortingKey)
                {
                    if (_sortingOrder == SortOrder.Ascending)
                    {
                        SetSorting(columnData.SortingKey, SortOrder.Descending);
                    }
                    else
                    {
                        SetSorting(columnData.SortingKey, SortOrder.Ascending);
                    }
                }
                else
                {
                    SetSorting(columnData.SortingKey, SortOrder.Ascending);
                }
                if (Sorting != null) { Sorting(this, EventArgs.Empty); }
            }
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int padding = 4;
            //改表頭
            if (e.RowIndex == -1)
            {
                Graphics g = e.Graphics;
                Rectangle rect = e.CellBounds;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;

                columnData columnData = _columnDatas[dataGridView.Columns[e.ColumnIndex].DataPropertyName];
                StyleModeData smd = StyleControls.Helper.GetStyleModeData(StyleMode.LowChroma);
                //background
                SolidBrush brush = new SolidBrush(smd.BackColor);
                g.FillRectangle(brush, rect);

                //Item
                rect = new Rectangle(rect.X + e.CellStyle.Padding.Left, rect.Y + e.CellStyle.Padding.Top, rect.Width - e.CellStyle.Padding.Left - e.CellStyle.Padding.Right, rect.Height - e.CellStyle.Padding.Top - e.CellStyle.Padding.Bottom);
                if (columnData.Sorted == true)
                {
                    brush = new SolidBrush(smd.BorderColor);
                    g.FillRectangle(brush, rect);
                    brush = new SolidBrush(Helper.GetLightColor(smd.BackColor));
                    g.FillRectangle(brush, new Rectangle(rect.X + StyleControls.Helper.ControlBorderWidth, rect.Y + StyleControls.Helper.ControlBorderWidth, rect.Width - StyleControls.Helper.ControlBorderWidth * 2, rect.Height - StyleControls.Helper.ControlBorderWidth * 2));
                }
                else
                {
                    brush = new SolidBrush(Helper.GetLightColor(smd.BackColor));
                    g.FillRectangle(brush, rect);
                }

                //icon
                int iconWidth = rect.Height - padding * 2;
                if (_sortingKey != "" && columnData.SortingKey == _sortingKey)
                {
                    Image icon = Properties.Resources.GridView_Descending;
                    if (_sortingOrder == SortOrder.Ascending)
                        icon = Properties.Resources.GridView_Ascending;
                    Helper.DrawImage(g, icon, Enabled, new Rectangle(rect.Right - padding - iconWidth, rect.Y + padding, iconWidth, rect.Height - padding * 2), new Size(iconWidth, iconWidth), ContentAlignment.MiddleCenter, Point.Empty);
                }

                //text
                Helper.DrawString(g, e.Value.ToString(), Enabled, new Rectangle(rect.X + padding, rect.Y + padding, rect.Width - padding * 2 - iconWidth, rect.Height - padding * 2), StyleControls.Helper.Style.Font, smd.ForeColor, ContentAlignment.MiddleLeft);

                e.Handled = true;
            }
        }

        private bool _selectedRowChangedTrigger = true;
        private void dataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (_selectedRowChangedTrigger == true && e.StateChanged == DataGridViewElementStates.Selected)
            {
                if (SelectedRowChanged != null) { SelectedRowChanged(this, EventArgs.Empty); }
            }
        }

        /// <summary>
        /// 排序事件
        /// </summary>
        [Browsable(true)]
        public event EventHandler<EventArgs> Sorting;

        /// <summary>
        /// 行點擊事件
        /// </summary>
        [Browsable(true)]
        public event EventHandler<EventArgs> RowClick;

        /// <summary>
        /// 行雙點擊事件
        /// </summary>
        [Browsable(true)]
        public event EventHandler<EventArgs> RowDoubleClick;

        /// <summary>
        /// 選取行改變事件
        /// </summary>
        [Browsable(true)]
        public event EventHandler<EventArgs> SelectedRowChanged;

        /// <summary>
        /// 欄位填充
        /// </summary>
        public Padding CellPadding
        {
            get { return _cellPadding; }
            set
            {
                _cellPadding = value;
                {
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        column.DefaultCellStyle.Padding = _cellPadding;
                    }
                }
            }
        }
        private Padding _cellPadding = new Padding(0);

        /// <summary>
        /// 欄位表頭高度
        /// </summary>
        public int ColumnHeaderHeight
        {
            get { return dataGridView.ColumnHeadersHeight; }
            set { dataGridView.ColumnHeadersHeight = value; }
        }

        /// <summary>
        /// 行高
        /// </summary>
        public int RowHeight
        {
            get { return dataGridView.RowTemplate.Height; }
            set { dataGridView.RowTemplate.Height = value; }
        }

        /// <summary>
        /// 排序鍵值
        /// </summary>
        public string SortingKey
        {
            get { return _sortingKey; }
            set { _sortingKey = value; }
        }
        private string _sortingKey = "";

        /// <summary>
        /// 排序方向
        /// </summary>
        public SortOrder SortingOrder
        {
            get { return _sortingOrder; }
            set { _sortingOrder = value; }
        }
        private SortOrder _sortingOrder = SortOrder.None;

        /// <summary>
        /// 設定排序
        /// </summary>
        /// <param name="key">鍵值</param>
        /// <param name="order">方向</param>
        public void SetSorting(string key, SortOrder order)
        {
            _sortingKey = key;
            _sortingOrder = order;
            dataGridView.Invalidate();
        }

        /// <summary>
        /// 資料來源
        /// </summary>
        public Array DataSource
        {
            set
            {
                _selectedRowChangedTrigger = false;
                dataGridView.Rows.Clear();

                if (dataGridView.ColumnCount > 0 && value != null)
                {
                    DataGridViewRow row = null;
                    int rowIndex = 0;
                    PropertyInfo pi = null;
                    DataGridViewCell cell = null;
                    foreach (object data in value)
                    {
                        rowIndex = dataGridView.Rows.Add();
                        row = dataGridView.Rows[rowIndex];
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            pi = null;
                            try
                            {
                                pi = data.GetType().GetProperty(column.DataPropertyName);
                                if (pi != null)
                                {
                                    cell = row.Cells[column.Name];
                                    if (column is DataGridViewImageColumn)
                                    {
                                        cell.Value = _columnDatas[column.DataPropertyName].GetImage(pi.GetValue(data, null));
                                    }
                                    else
                                    {
                                        cell.Value = pi.GetValue(data, null);
                                    }
                                }
                            }
                            catch { }
                        }
                        row.Selected = false;
                    }
                }
                if (dataGridView.Rows.Count > 0) { dataGridView.Rows[0].Selected = true; }
                _selectedRowChangedTrigger = true;
            }
        }

        public void RowsClear()
        {
            dataGridView.Rows.Clear();
        }

        /// <summary>
        /// 顯示行數
        /// </summary>
        public int DisplayRowsCount
        {
            get
            {
                int r = (dataGridView.Height - ColumnHeaderHeight) / RowHeight;
                if (r == 0) { r = 1; }
                return r;
            }
        }

        /// <summary>
        /// 行資料
        /// </summary>
        /// <param name="index">次序</param>
        public Dictionary<string, object> RowData(int index)
        {
            Dictionary<string, object> r = null;
            if (index < dataGridView.Rows.Count & index > -1)
            {
                r = new Dictionary<string, object>();
                DataGridViewRow row = dataGridView.Rows[index];
                DataGridViewCell cell = null;
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (!string.IsNullOrEmpty(column.DataPropertyName))
                    {
                        cell = row.Cells[column.Index];
                        if (column is DataGridViewImageColumn)
                        {
                            r.Add(column.DataPropertyName, _columnDatas[column.DataPropertyName].GetValue((Image)cell.Value));
                        }
                        else
                        {
                            r.Add(column.DataPropertyName, cell.Value);
                        }
                    }
                }
            }
            return r;
        }

        /// <summary>
        /// 選取行的次序
        /// </summary>
        public int SelectedRowIndex
        {
            get
            {
                int r = -1;
                if (dataGridView.SelectedRows.Count == 1) { r = dataGridView.SelectedRows[0].Index; }
                return r;
            }
            set
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    row.Selected = false;
                }
                if (value > -1 && value < dataGridView.Rows.Count)
                {
                    dataGridView.Rows[value].Selected = true;
                }
            }
        }

        /// <summary>
        /// 選取行的資料
        /// </summary>
        public Dictionary<string, object> SelectedRowData
        {
            get
            {
                Dictionary<string, object> r = null;
                if (SelectedRowIndex != -1) { r = RowData(SelectedRowIndex); }
                return r;
            }
        }

        private Dictionary<string, columnData> _columnDatas = new Dictionary<string, columnData>();
        /// <summary>
        /// 新增隱藏欄位
        /// </summary>
        /// <param name="id">代號</param>
        public void AddHiddenColumn(string id)
        {
            if (_columnDatas.ContainsKey(id) == false)
            {
                _columnDatas.Add(id, new columnData(id, columnType.Hidden, false, ""));

                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column = new DataGridViewTextBoxColumn();
                column.Name = "Column_" + id;
                column.DataPropertyName = id;
                column.ReadOnly = true;
                column.Visible = false;
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGridView.Columns.Add(column);
            }
        }
        /// <summary>
        /// 新增文字欄位
        /// </summary>
        /// <param name="id">代號</param>
        /// <param name="text">文字</param>
        /// <param name="sorted">可排序</param>
        /// <param name="sortingKey">排序鍵值</param>
        /// <param name="width">寬度</param>
        /// <param name="alignment">對齊</param>
        /// <param name="format">格式</param>
        public void AddTextColumn(string id, string text, bool sorted, string sortingKey, int width, DataGridViewContentAlignment alignment, string format)
        {
            if (_columnDatas.ContainsKey(id) == false)
            {
                _columnDatas.Add(id, new columnData(id, columnType.Text, sorted, sortingKey));

                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.Alignment = alignment;
                cellStyle.Format = format;
                cellStyle.Padding = CellPadding;
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.DefaultCellStyle = cellStyle;
                column.HeaderCell.Style.Padding = CellPadding;
                column.Name = "Column_" + id;
                column.DataPropertyName = id;
                column.ReadOnly = true;
                column.Width = width;
                column.HeaderText = text;
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGridView.Columns.Add(column);
            }
        }

        /// <summary>
        /// 新增圖形欄位
        /// </summary>
        /// <param name="id">代號</param>
        /// <param name="text">文字</param>
        /// <param name="sorted">可排序</param>
        /// <param name="sortingKey">排序鍵值</param>
        /// <param name="width">寬度</param>
        /// <param name="alignment">對齊</param>
        public void AddImageColumn(string id, string text, bool sorted, string sortingKey, int width, DataGridViewContentAlignment alignment)
        {
            if (_columnDatas.ContainsKey(id) == false)
            {
                _columnDatas.Add(id, new columnData(id, columnType.Image, sorted, sortingKey));

                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.Padding = CellPadding;
                cellStyle.Alignment = alignment;
                DataGridViewImageColumn column = new DataGridViewImageColumn();
                column.ImageLayout = DataGridViewImageCellLayout.Zoom;
                column.DefaultCellStyle = cellStyle;
                column.HeaderCell.Style.Padding = CellPadding;
                column.Name = "Column_" + id;
                column.DataPropertyName = id;
                column.Width = width;
                column.ReadOnly = true;
                column.HeaderText = text;
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGridView.Columns.Add(column);
            }

        }

        /// <summary>
        /// 新增圖形欄位值
        /// </summary>
        /// <param name="columnId">欄位代號</param>
        /// <param name="value">值</param>
        /// <param name="image">圖形</param>
        public void AddImageColumnValue(string columnId, object value, Image image)
        {
            if (_columnDatas.ContainsKey(columnId) == true)
            {
                _columnDatas[columnId].AddValueImage(value, image);
            }
        }

    }

    /// <summary>
    /// 欄位資料類別
    /// </summary>
    class columnData
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="id">代號</param>
        /// <param name="type">類型</param>
        /// <param name="sorted">排序</param>
        public columnData(string id, columnType type, bool sorted, string sortingKey) : base()
        {
            _id = id;
            _type = type;
            _sorted = sorted;
            _sortingKey = sortingKey;
        }

        /// <summary>
        /// 代號
        /// </summary>
        public string Id
        {
            get { return _id; }
        }
        private string _id = "";

        /// <summary>
        /// 類型
        /// </summary>
        public columnType Type
        {
            get { return _type; }
        }
        private columnType _type = columnType.Hidden;

        /// <summary>
        /// 排序
        /// </summary>
        public bool Sorted
        {
            get { return _sorted; }
        }
        private bool _sorted = false;

        /// <summary>
        /// 排序鍵值
        /// </summary>
        public string SortingKey
        {
            get { return _sortingKey; }
        }
        private string _sortingKey = "";

        private Dictionary<object, Image> _valueImages = new Dictionary<object, Image>();
        /// <summary>
        /// 新增值得圖形
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="image">圖形</param>
        public void AddValueImage(object value, Image image)
        {
            if (_valueImages.ContainsKey(value) == false) { _valueImages.Add(value, image); }
        }

        /// <summary>
        /// 值
        /// </summary>
        /// <param name="image">圖形</param>
        public object GetValue(Image image)
        {
            object r = null;
            foreach (object value in _valueImages.Keys)
            {
                if (_valueImages[value] == image)
                {
                    r = value;
                    break;
                }
            }
            return r;
        }

        /// <summary>
        /// 圖形
        /// </summary>
        /// <param name="value">值</param>
        public Image GetImage(object value)
        {
            Image r = null;
            if (_valueImages.ContainsKey(value) == true) { r = _valueImages[value]; }
            return r;
        }
    }

    /// <summary>
    /// 欄位型別列舉
    /// </summary>
    enum columnType
    {
        /// <summary>
        /// 隱藏
        /// </summary>
        Hidden = 0,

        /// <summary>
        /// 文字
        /// </summary>
        Text = 1,

        /// <summary>
        /// 圖形
        /// </summary>
        Image = 2
    }
}
