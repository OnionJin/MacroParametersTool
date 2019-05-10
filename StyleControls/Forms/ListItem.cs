using System;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 清單項目類別
    /// </summary>
    public class ListItem : ICloneable
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public ListItem() : base() { }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="text">文字</param>
        /// <param name="value">值</param>
        public ListItem(string text, object value) : base()
        {
            _text = text;
            _value = value;
        }

        private string _text = "";
        /// <summary>
        /// 文字
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private object _value = null;
        /// <summary>
        /// 值
        /// </summary>
        public object Value
        {
            get { return _value; }
            set { this._value = value; }
        }

        object ICloneable.Clone()
        {
            ListItem r = new ListItem();
            r.Text = this.Text;
            r.Value = this.Value;
            return r;
        }
    }
}
