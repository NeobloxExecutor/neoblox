using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            try
            {
                using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts")))
                {
                    w.WriteLine("# Anti-Banwave measures for Roblox - added by neoblox");
                    w.WriteLine("127.0.0.1 data.roblox.com");
                    w.WriteLine("127.0.0.1 roblox.sp.backtrace.io");
                }
            }
            catch
            {
                MessageBox.Show("We couldn't activate Anti-Banwave due to an unexpected error!\nTry running neoblox as an administrator!\nBe careful!");
            }
        }

        private void neoblox_Close(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts");
                File.WriteAllLines(path, (from l in File.ReadLines(path) where l != "127.0.0.1 data.roblox.com" select l).ToList<string>());
                File.WriteAllLines(path, (from l in File.ReadLines(path) where l != "127.0.0.1 roblox.sp.backtrace.io" select l).ToList<string>());
                File.WriteAllLines(path, (from l in File.ReadLines(path) where l != "# Anti-Banwave measures for Roblox - added by neoblox" select l).ToList<string>());
            }
            catch
            {
                MessageBox.Show("We couldn't deactivate Anti-Banwave due to an unexpected error!\nRestart the program as an administrator!");
            }
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

        private void openScriptButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var MainText = reader.ReadToEnd();
                        aceEditor.Document.InvokeScript("SetText", new object[]
                        {
                            MainText
                        });
                    }
                }
            }
        }

        private void saveScriptButton_Click(object sender, EventArgs e)
        {
            HtmlDocument document = aceEditor.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();

            try
            {
                var saveFileDialog1 = new SaveFileDialog
                {
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Scripts",
                    Filter = string.Format("{0}Text files (*.txt)|*.txt|Lua files (*.lua)|*.lua", "*.lua"),
                    RestoreDirectory = true,
                    ShowHelp = false,
                    CheckFileExists = false
                };
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) { File.WriteAllText(saveFileDialog1.FileName, script); }
            }
            catch
            {

            }
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            wrdExploitAPI.LaunchExploit();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
    }
}
