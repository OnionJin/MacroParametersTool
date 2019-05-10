using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroParametersTool.Data
{
    /// <summary>
    /// 頁碼類別
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public Paging() : base() { }
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="size">大小</param>
        /// <param name="index">頁次</param>
        public Paging(int size, int index) : base()
        {
            _size = size;
            _index = index;
        }

        private int _size = 10;
        /// <summary>
        /// 大小
        /// </summary>
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        private int _index = 1;
        /// <summary>
        /// 頁次
        /// </summary>
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        private int _rowsCount = 0;
        /// <summary>
        /// 筆數
        /// </summary>
        public int RowsCount
        {
            get { return _rowsCount; }
            set
            {
                _rowsCount = value;
                if (_index > PageCount) { _index = PageCount; }
            }
        }

        /// <summary>
        /// 頁數
        /// </summary>
        /// <returns></returns>
        public int PageCount
        {
            get
            {
                int r = 0;
                r = (_rowsCount / _size);
                if ((_rowsCount % _size) > 0) { r = r + 1; }
                if (r < 1) { r = 1; }
                return r;
            }
        }

        /// <summary>
        /// 開始筆次
        /// </summary>
        public int StartRowIndex
        {
            get
            {
                return (_index - 1) * _size + 1;
            }
        }

        /// <summary>
        /// 結束筆次
        /// </summary>
        public int EndRowIndex
        {
            get
            {
                int r = _index * _size;
                if (r > _rowsCount) { r = _rowsCount; }
                return r;
            }
        }

    }
}
