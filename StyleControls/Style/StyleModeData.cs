using System.Drawing;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 樣式模式資料類別
    /// </summary>
    public class StyleModeData
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="backColor">背景色</param>
        /// <param name="foreColor">前景色(文字)</param>
        /// <param name="borderColor">邊線色</param>
        public StyleModeData(Color backColor, Color foreColor, Color borderColor) : base()
        {
            _backColor = backColor;
            _foreColor = foreColor;
            _borderColor = borderColor;
        }

        private Color _backColor;
        /// <summary>
        /// 背景色
        /// </summary>
        public Color BackColor
        {
            get { return _backColor; }
        }

        private Color _foreColor;
        /// <summary>
        /// 前景色(文字)
        /// </summary>
        public Color ForeColor
        {
            get { return _foreColor; }
        }

        private Color _borderColor;
        /// <summary>
        /// 邊線色
        /// </summary>
        public Color BorderColor
        {
            get { return _borderColor; }
        }

    }
}
