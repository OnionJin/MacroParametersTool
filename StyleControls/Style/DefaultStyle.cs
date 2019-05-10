using System.Drawing;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 預設模式類別
    /// </summary>
    public class DefaultStyle : IStyle
    {
        private StyleModeData _controlMode = null;
        /// <summary>
        /// 控制項
        /// </summary>
        public StyleModeData Control
        {
            get
            {
                if (_controlMode == null)
                {
                    _controlMode = new StyleModeData(Color.FromArgb(0xff, 0xff, 0xff), Color.FromArgb(0x0, 0x0, 0x0), Color.FromArgb(0xff, 0xff, 0xff));
                }
                return _controlMode;
            }
        }

        private Font _font = null;
        /// <summary>
        /// 字型
        /// </summary>
        public Font Font
        {
            get
            {
                if (_font == null)
                {
                    _font = new Font("微軟正黑體", 24, GraphicsUnit.Pixel);
                }
                return _font;
            }
        }

        private StyleModeData _highChroma = null;
        /// <summary>
        /// 高彩
        /// </summary>
        public StyleModeData HighChroma
        {
            get
            {
                if (_highChroma == null)
                {
                    _highChroma = new StyleModeData(Color.FromArgb(0x66, 0x0, 0x0), Color.FromArgb(0xff, 0xff, 0xff), Color.FromArgb(0xff, 0xff, 0xff));
                }
                return _highChroma;
            }
        }

        private StyleModeData _lowChroma = null;
        /// <summary>
        /// 低彩
        /// </summary>
        public StyleModeData LowChroma
        {
            get
            {
                if (_lowChroma == null)
                {
                    _lowChroma = new StyleModeData(Color.FromArgb(0x66, 0x66, 0x33), Color.FromArgb(0xff, 0xff, 0xff), Color.FromArgb(0xff, 0xff, 0xff));
                }
                return _lowChroma;
            }
        }

        private StyleModeData _normalMode = null;
        /// <summary>
        /// 一般
        /// </summary>
        public StyleModeData Normal
        {
            get
            {
                if (_normalMode == null)
                {
                    _normalMode = new StyleModeData(Color.FromArgb(0xcc, 0xcc, 0x99), Color.FromArgb(0x0, 0x0, 0x0), Color.FromArgb(0xff, 0xff, 0xff));
                }
                return _normalMode;
            }
        }

        private Font _smallFont = null;
        /// <summary>
        /// 小字型
        /// </summary>
        public Font SmallFont
        {
            get
            {
                if (_smallFont == null)
                    _smallFont = new Font("微軟正黑體", 18, GraphicsUnit.Pixel);
                return _smallFont;
            }
        }

        private StyleModeData _warning = null;
        /// <summary>
        /// 警告
        /// </summary>
        public StyleModeData Warning
        {
            get
            {
                if (_warning == null)
                {
                    _warning = new StyleModeData(Color.FromArgb(0xff, 0x0, 0x0), Color.FromArgb(0xff, 0xff, 0xff), Color.FromArgb(0xff, 0xff, 0xff));
                }
                return _warning;
            }
        }
    }
}
