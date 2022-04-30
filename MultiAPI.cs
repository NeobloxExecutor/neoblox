using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KrnlAPI;

namespace neoblox
{
    public partial class MultiAPI : Form
    {
        KrnlApi krnlExploitAPI = new KrnlApi();

        EasyExploits.Module neobloxExploit = new EasyExploits.Module();

        neoblox nb = new neoblox();

        public MultiAPI()
        {
            InitializeComponent();
        }

        private void MultiAPI_Load(object sender, EventArgs e)
        {
            krnlExploitAPI.Initialize();
        }

        private void multiAPIButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            neoblox nb = new neoblox();
            nb.ShowDialog();
        }


        Point lastPoint;
        private void MultiAPI_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MultiAPI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void krnlInject_Click(object sender, EventArgs e)
        {
            bool isKrnlUsing = true;
            krnlExploitAPI.Inject();
        }

        private void easyxploitAPIInject_Click(object sender, EventArgs e)
        {
            bool isezXPloitUsing = true;
            neobloxExploit.LaunchExploit();
        }
    }
}
