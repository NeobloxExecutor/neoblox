using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeAreDevs_API;

// raifu was here owo

namespace neoblox
{
    public partial class neoblox : Form
    {
        ExploitAPI wrdExploitAPI = new ExploitAPI();
        public neoblox()
        {
            InitializeComponent();
        }

        private void neoblox_Load(object sender, EventArgs e)
        { 
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_Negative);

            this.aceEditor.Navigate(string.Format("file:///{0}ace/AceEditor.html", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            HtmlDocument document = aceEditor.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();

            wrdExploitAPI.SendLuaScript(script);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aceEditor.Document.InvokeScript("SetText", new object[]
            {
                ""
            });
        }
    }
}
