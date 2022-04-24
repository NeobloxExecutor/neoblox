using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeAreDevs_API;

namespace neoblox
{
    public partial class ScriptHub : Form
    {
        public ScriptHub()
        {
            InitializeComponent();
        }

        internal ExploitAPI wrdExploitAPI = new ExploitAPI();

        /// <summary>
        /// The closeButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Process.Start("deactivate anti ban measures.exe");
            foreach (var process in Process.GetProcessesByName("discordrpc"))
            {
                process.Kill();
            }
            Application.Exit();
        }

        /// <summary>
        /// The minimizeButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Defines the lastPoint.
        /// </summary>
        internal Point lastPoint;

        /// <summary>
        /// The ScriptHub_MouseDown.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="MouseEventArgs"/>.</param>
        private void ScriptHub_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// The ScriptHub_MouseMove.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="MouseEventArgs"/>.</param>
        private void ScriptHub_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void scriptHubButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            neoblox nb = new neoblox();
            nb.ShowDialog();
        }

        private void xrayScript_Click(object sender, EventArgs e)
        {
            wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/u1zKqy4s'))();");
        }

        private void infiniteJumpScript_Click(object sender, EventArgs e)
        {
            wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/GDqr8kWM'))();");
        }

        private void ctrlClickToTP_Click(object sender, EventArgs e)
        {
            wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/PzB5aw8q'))();");
        }

        private void phantomForcesSilentAim_Click(object sender, EventArgs e)
        {
            wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/LjD1BRMm'))();");
        }

        private void phantomForcesESP_Click(object sender, EventArgs e)
        {
            wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/bCWL1YKa'))();");
        }
    }
}
