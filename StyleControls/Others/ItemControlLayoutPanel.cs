using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    public class ItemControlLayoutPanel : FlowLayoutPanel
    {
        /// <summary>
        /// 分頁大小改變事件
        /// </summary>
        public event EventHandler<EventArgs> PageSizeChanged;

        public event EventHandler<EventArgs> SelectedItemControlChanged;

        private Size _itemControlSize = new Size(320, 80);
        public Size ItemControlSize
        {
            get { return _itemControlSize; }
            set
            {
                _itemControlSize.Width = value.Width;
                _itemControlSize.Height = value.Height;
                CheckPageSize();
            }
        }

        private int _pageSize = 1;
        private Size _itemControlMargin = new Size(2, 2);
        public int PageSize
        {
            get { return _pageSize; }
        }

        public int PageCount
        {
            get
            {
                int r = (Controls.Count / PageSize);
                if ((Controls.Count % PageSize) > 0) { r = r + 1; }
                if (r < 1) { r = 1; }
                return r;
            }
        }

        private int _pageIndex = 1;
        public int PageIndex
        {
            get { return _pageIndex; }
            set
            {
                int r = value;
                if (r < 1) { r = 1; }
                if (r > PageCount) { r = PageCount; }
                if (_pageIndex != r)
                {
                    _pageIndex = r;
                    int firstIndex = (_pageIndex - 1) * PageSize;
                    int lastIndex = _pageIndex * PageSize - 1;
                    for (int index = 0; index < Controls.Count; index++)
                    {
                        Controls[index].Visible = (index >= firstIndex && index <= lastIndex) ? true : false;
                    }
                    if (PageSizeChanged != null) { PageSizeChanged(this, EventArgs.Empty); }
                }
            }
        }

        public int ItemControlPageIndex(Control control)
        {
            int r = -1;
            int index = Controls.GetChildIndex(control);
            if (index != -1)
            {
                r = index / PageSize;
                if ((index % PageSize) > 0) { r = r + 1; }
                if (r < 1) { r = 1; }
            }
            return r;
        }

        private ButtonItemControlBase _selectedItemControl = null;
        private ButtonItemControlBase _beforeSelectedItemControl = null;
        public ButtonItemControlBase BeforeSelectedItemControl
        {
            get { return _beforeSelectedItemControl; }
        }
        public ButtonItemControlBase SelectedItemControl
        {
            get { return _selectedItemControl; }
            set
            {
                if (_selectedItemControl != value)
                {
                    _beforeSelectedItemControl = _selectedItemControl;
                    if (_selectedItemControl != null) { _selectedItemControl.Selected = false; }
                    _selectedItemControl = value;
                    if (_selectedItemControl != null)
                    {
                        _selectedItemControl.Selected = true;
                        _selectedItemControl.Focus();
                    }
                    if (SelectedItemControlChanged != null) { SelectedItemControlChanged(this, EventArgs.Empty); }
                    if (_selectedItemControl == null) { PageIndex = 1; }
                    else { PageIndex = ItemControlPageIndex(_selectedItemControl); }
                }
            }
        }

        private void CheckPageSize()
        {
            int width = ClientSize.Width;
            int height = ClientSize.Height - Padding.Top;
            int columns = width / (ItemControlSize.Width + 2);
            if (columns < 1) { columns = 1; }
            int rows = height / (ItemControlSize.Height + 2);
            if (rows < 1) { rows = 1; }
            if (columns == 1) { _itemControlMargin.Width = 0; }
            else { _itemControlMargin.Width = (width - ItemControlSize.Width * columns) / (columns + 1); }
            if (rows == 1) { _itemControlMargin.Height = 0; }
            else { _itemControlMargin.Height = (height - ItemControlSize.Height * rows) / (rows); }
            this.Padding = new Padding(_itemControlMargin.Width, Padding.Top, 0, 0);
            foreach (Control control in Controls) { control.Margin = new Padding(0, 0, _itemControlMargin.Width, _itemControlMargin.Height); }

            if (PageIndex != columns * rows)
            {
                _pageSize = columns * rows;
                if (PageSizeChanged != null) { PageSizeChanged(this, EventArgs.Empty); }
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            CheckPageSize();
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.Click += OnItemControlClick;
            e.Control.Margin = new Padding(0, 0, _itemControlMargin.Width, _itemControlMargin.Height);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            e.Control.Click -= OnItemControlClick;
        }

        private void OnItemControlClick(object sender, EventArgs e)
        {
            ButtonItemControlBase item = sender as ButtonItemControlBase;
            if (item != null) { SelectedItemControl = item; }
        }

        public bool PreviousKeyword(string keyword)
        {
            bool r = false;
            int startIndex = Controls.GetChildIndex(SelectedItemControl, false);
            int index = -1;
            if (keyword == "")
            {
                index = startIndex - 1;
                if (index < 0) { index = Controls.Count - 1; }
                else if (index > Controls.Count - 1) { index = 0; }
                SelectedItemControl = Controls[index] as ButtonItemControlBase;
                r = true;
            }
            else
            {
                ButtonItemControlBase itemControl;
                for (index = startIndex - 1; index > -1; index--)
                {
                    itemControl = Controls[index] as ButtonItemControlBase;
                    if (itemControl != null)
                    {
                        if (itemControl.SearchKeyword(keyword) == true)
                        {
                            SelectedItemControl = itemControl;
                            r = true;
                            break;
                        }
                    }
                }
                if (r == false)
                {
                    for (index = Controls.Count - 1; index > startIndex; index--)
                    {
                        itemControl = Controls[index] as ButtonItemControlBase;
                        if (itemControl != null)
                        {
                            if (itemControl.SearchKeyword(keyword) == true)
                            {
                                SelectedItemControl = itemControl;
                                r = true;
                                break;
                            }
                        }
                    }
                }
            }
            return r;
        }

        public bool NextKeyword(string keyword)
        {
            bool r = false;
            int startIndex = Controls.GetChildIndex(SelectedItemControl, false);
            int index = -1;
            if (keyword == "")
            {
                index = startIndex + 1;
                if (index < 0) { index = Controls.Count - 1; }
                else if (index > Controls.Count - 1) { index = 0; }
                SelectedItemControl = Controls[index] as ButtonItemControlBase;
                r = true;
            }
            else
            {
                ButtonItemControlBase itemControl;
                for (index = startIndex + 1; index < Controls.Count; index++)
                {
                    itemControl = Controls[index] as ButtonItemControlBase;
                    if (itemControl != null)
                    {
                        if (itemControl.SearchKeyword(keyword) == true)
                        {
                            SelectedItemControl = itemControl;
                            r = true;
                            break;
                        }
                    }
                }
                if (r == false)
                {
                    for (index = 0; index < startIndex; index++)
                    {
                        itemControl = Controls[index] as ButtonItemControlBase;
                        if (itemControl != null)
                        {
                            if (itemControl.SearchKeyword(keyword) == true)
                            {
                                SelectedItemControl = itemControl;
                                r = true;
                                break;
                            }
                        }
                    }
                }
            }
            return r;
        }

        public bool SearchKeyword(string keyword)
        {
            bool r = false;
            if (SelectedItemControl != null)
            {
                if (keyword == "") { r = true; }
                else { r = SelectedItemControl.SearchKeyword(keyword); }
            }
            if (r == false) { r = NextKeyword(keyword); }
            return r;
        }
    }
}
