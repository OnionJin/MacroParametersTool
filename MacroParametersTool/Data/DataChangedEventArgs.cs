using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroParametersTool.Data
{
    /// <summary>
    /// 資料變更事件資料類別
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataChangedEventArgs<T> : EventArgs
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="data">資料</param>
        public DataChangedEventArgs(T data) : base()
        {
            _data = data;
        }

        private T _data = default(T);
        /// <summary>
        /// 資料
        /// </summary>
        public T Data
        {
            get { return _data; }
        }
    }
}
