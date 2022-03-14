using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace neoblox
{
    class WinAPI
    {
        public const int HOR_Positive = 0X1;

        public const int HOR_Negative = 0X2;

        public const int VER_Positive = 0X4;

        public const int VER_Negative = 0X8;

        public const int Center = 0X10;

        public const int Blend = 0X80000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }
}
