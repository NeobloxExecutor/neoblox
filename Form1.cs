using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// raifu was here owo

namespace neoblox
{
    public partial class neoblox : Form
    {
        public neoblox()
        {
            InitializeComponent();
        }

        private void neoblox_Load(object sender, EventArgs e)
        { 
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_Negative);

            this.aceEditor.Navigate(string.Format("file:///{0}ace/AceEditor.html", AppDomain.CurrentDomain.BaseDirectory));
        }
    }
}
