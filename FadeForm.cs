// https://www.codeproject.com/Articles/30255/C-Fade-Form-Effect-With-the-AnimateWindow-API-Func

namespace Utility
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// Base form class that provides fading/sliding effects on open/close of the form.
    /// </summary>
    public class FadeForm : Form
    {
        /// <summary>
        /// Defines the AW_HIDE.
        /// </summary>
        internal const int AW_HIDE = 0X10000;

        /// <summary>
        /// Defines the AW_ACTIVATE.
        /// </summary>
        internal const int AW_ACTIVATE = 0X20000;

        /// <summary>
        /// Defines the AW_HOR_POSITIVE.
        /// </summary>
        internal const int AW_HOR_POSITIVE = 0X1;

        /// <summary>
        /// Defines the AW_HOR_NEGATIVE.
        /// </summary>
        internal const int AW_HOR_NEGATIVE = 0X2;

        /// <summary>
        /// Defines the AW_SLIDE.
        /// </summary>
        internal const int AW_SLIDE = 0X40000;

        /// <summary>
        /// Defines the AW_BLEND.
        /// </summary>
        internal const int AW_BLEND = 0X80000;

        /// <summary>
        /// The AnimateWindow.
        /// </summary>
        /// <param name="hwand">The hwand<see cref="IntPtr"/>.</param>
        /// <param name="dwTime">The dwTime<see cref="int"/>.</param>
        /// <param name="dwFlags">The dwFlags<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int AnimateWindow
        (IntPtr hwand, int dwTime, int dwFlags);

        /// <summary>
        /// Defines the _UseSlideAnimation.
        /// </summary>
        private bool _UseSlideAnimation;

        /// <summary>
        /// Initializes a new instance of the <see cref="FadeForm"/> class.
        /// </summary>
        public FadeForm() : this(false)         {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FadeForm"/> class.
        /// </summary>
        /// <param name="useSlideAnimation">if set to <c>true</c> [use slide animation].</param>
        public FadeForm(bool useSlideAnimation)
        {
            _UseSlideAnimation = useSlideAnimation;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AnimateWindow(this.Handle, 150, AW_ACTIVATE | (_UseSlideAnimation ? AW_HOR_POSITIVE | AW_SLIDE : AW_BLEND));
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Closing"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs"/> that contains the event data.</param>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == false)
            {
                AnimateWindow(this.Handle, 150, AW_HIDE | (_UseSlideAnimation ? AW_HOR_NEGATIVE | AW_SLIDE : AW_BLEND));
            }
        }
    }
}
