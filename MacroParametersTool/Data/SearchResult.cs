using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroParametersTool.Data
{
    /// <summary>
    /// 查詢結果類別
    /// </summary>
    /// <typeparam name="T">資料類型</typeparam>
    public class SearchResult<T>
    {
        public SearchResult(Paging paging) : base()
        {
            if (paging != null) { _paging = new Paging(paging.Size, paging.Index); }
        }
        public SearchResult() : base() { }
        private Paging _paging = null;
        public Paging Paging
        {
            get
            {
                if (_paging == null) { _paging = new Paging(Int32.MaxValue, 1); }
                return _paging;
            }
            set { _paging = value; }
        }

        private List<T> _data = null;
        public List<T> Data
        {
            get
            {
                if (_data == null) { _data = new List<T>(); }
                return _data;
            }
            set { _data = value; }
        }

    }
}
