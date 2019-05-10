using System.Collections.Generic;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 清單項目集合類別
    /// </summary>
    public class ListItems : List<ListItem>
    {
        /// <summary>
        /// 新增項目
        /// </summary>
        /// <param name="text">文字</param>
        /// <param name="value">值</param>
        public void AddItem(string text, object value)
        {
            ListItem item = new ListItem(text, value); this.Add(item);
        }
    }
}
