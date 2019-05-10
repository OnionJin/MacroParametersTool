using System.Drawing;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 樣式介面
    /// </summary>
    public interface IStyle
    {
        /// <summary>
        /// 控制項
        /// </summary>
        StyleModeData Control { get; }

        /// <summary>
        /// 警告
        /// </summary>
        StyleModeData Warning { get; }

        /// <summary>
        /// 一般
        /// </summary>
        StyleModeData Normal { get; }

        /// <summary>
        /// 低彩
        /// </summary>
        StyleModeData LowChroma { get; }

        /// <summary>
        /// 高彩
        /// </summary>
        StyleModeData HighChroma { get; }

        /// <summary>
        /// 字型
        /// </summary>
        Font Font { get; }

        /// <summary>
        /// 小字型
        /// </summary>
        Font SmallFont { get; }

    }
}
