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
using KrnlAPI;

namespace neoblox
{
    public partial class ScriptHub : Form
    {
        public ScriptHub()
        {
            InitializeComponent();
        }

        internal ExploitAPI wrdExploitAPI = new ExploitAPI();

        KrnlApi krnlExploitAPI = new KrnlApi();

        private void ScriptHub_Load(object sender, EventArgs e)
        {
        }

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
            if (krnlExploitAPI.IsInjected())
            {
                krnlExploitAPI.Execute("loadstring(game: HttpGet('https://pastebin.com/raw/u1zKqy4s'))();");
            }
            if (wrdExploitAPI.isAPIAttached())
            {
                wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/u1zKqy4s'))();");
            }
        }

        private void infiniteJumpScript_Click(object sender, EventArgs e)
        {
            if (wrdExploitAPI.isAPIAttached())
            {
                wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/GDqr8kWM'))();");
            }
            if (krnlExploitAPI.IsInjected())
            {
                krnlExploitAPI.Execute("loadstring(game: HttpGet('https://pastebin.com/raw/GDqr8kWM'))();");
            }
        }

        private void ctrlClickToTP_Click(object sender, EventArgs e)
        {
            if (wrdExploitAPI.isAPIAttached())
            {
                wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/PzB5aw8q'))();");
            }
            if (krnlExploitAPI.IsInjected())
            {
                krnlExploitAPI.Execute("loadstring(game: HttpGet('https://pastebin.com/raw/PzB5aw8q'))();");
            }
        }

        private void phantomForcesSilentAim_Click(object sender, EventArgs e)
        {
            if (wrdExploitAPI.isAPIAttached())
            {
                wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/LjD1BRMm'))();");
            }
            if (krnlExploitAPI.IsInjected())
            {
                krnlExploitAPI.Execute("loadstring(game: HttpGet('https://pastebin.com/raw/LjD1BRMm'))();");
            }
        }

        private void phantomForcesESP_Click(object sender, EventArgs e)
        {
            if (wrdExploitAPI.isAPIAttached())
            {
                wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/bCWL1YKa'))();");
            }
            if (krnlExploitAPI.IsInjected())
            {
                krnlExploitAPI.Execute("loadstring(game: HttpGet('https://pastebin.com/raw/bCWL1YKa'))();");
            }
        }

        private void katGUI_Click(object sender, EventArgs e)
        {
            if (wrdExploitAPI.isAPIAttached())
            {
                wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/4itkacii'))();");
            }
            if (krnlExploitAPI.IsInjected())
            {
                krnlExploitAPI.Execute("loadstring(game: HttpGet('https://pastebin.com/raw/4itkacii'))();");
            }
        }

        private void mm2GUI_Click(object sender, EventArgs e)
        {
            if (wrdExploitAPI.isAPIAttached())
            {
                wrdExploitAPI.SendLuaScript("loadstring(game: HttpGet('https://pastebin.com/raw/ee39zaEi'))();");
            }
            if (krnlExploitAPI.IsInjected())
            {
                krnlExploitAPI.Execute("loadstring(game: HttpGet('https://pastebin.com/raw/ee39zaEi'))();");
            }
        }

        private void injectButtonFix_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("finj.exe");
            }
            catch
            {
                MessageBox.Show("Inject fix failed! Try using the normal inject. If that doesn't work report the bug at https://github.com/Plextora/neoblox/issues");
            }
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            wrdExploitAPI.LaunchExploit();
        }
    }
}
