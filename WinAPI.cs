namespace neoblox
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines the <see cref="WinAPI" />.
    /// </summary>
    internal class WinAPI
    {
        /// <summary>
        /// Defines the HOR_Positive.
        /// </summary>
        public const int HOR_Positive = 0X1;

        /// <summary>
        /// Defines the HOR_Negative.
        /// </summary>
        public const int HOR_Negative = 0X2;

        /// <summary>
        /// Defines the VER_Positive.
        /// </summary>
        public const int VER_Positive = 0X4;

        /// <summary>
        /// Defines the VER_Negative.
        /// </summary>
        public const int VER_Negative = 0X8;

        /// <summary>
        /// Defines the Center.
        /// </summary>
        public const int Center = 0X10;

        /// <summary>
        /// Defines the Blend.
        /// </summary>
        public const int Blend = 0X80000;

        /// <summary>
        /// The AnimateWindow.
        /// </summary>
        /// <param name="hwand">The hwand<see cref="IntPtr"/>.</param>
        /// <param name="dwTime">The dwTime<see cref="int"/>.</param>
        /// <param name="dwFlag">The dwFlag<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }
}
