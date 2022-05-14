using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;


using WeAreDevs_API;
using KrnlAPI;
using System.IO;
using System.Diagnostics;
using ScintillaNET;

namespace lightweightNeoblox
{
    public partial class lightweightNeoblox : Form
    {
        ExploitAPI wrdExploitAPI = new ExploitAPI();

        KrnlApi krnlExploitAPI = new KrnlApi();

        EasyExploits.Module easyExploitsAPI = new EasyExploits.Module();

        bool isKrnl;
        bool isEasyExploit;
        bool isWRD;

        public lightweightNeoblox()
        {
            InitializeComponent();
        }

        #region Utils

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        public void InvokeIfNeeded(Action action)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }

        #endregion

        private void InitColors()
        {

            scintillaEditor.SetSelectionBackColor(true, IntToColor(0x114D9C));

        }

        private void InitSyntaxColoring()
        {
            scintillaEditor.StyleResetDefault();
            scintillaEditor.Styles[Style.Default].Font = "Consolas";
            scintillaEditor.Styles[Style.Default].Size = 10;
            scintillaEditor.Styles[Style.Default].BackColor = IntToColor(0x212121);
            scintillaEditor.Styles[Style.Default].ForeColor = Color.FromArgb(255, 218, 185);
            scintillaEditor.StyleClearAll();

            scintillaEditor.Styles[Style.Lua.Comment].ForeColor = Color.FromArgb(128, 128, 128);
            scintillaEditor.Styles[Style.Lua.CommentLine].ForeColor = Color.FromArgb(128, 128, 128);
            scintillaEditor.Styles[Style.Lua.CommentDoc].ForeColor = Color.FromArgb(128, 128, 128);
            scintillaEditor.Styles[Style.Lua.Number].ForeColor = Color.FromArgb(255, 253, 185);
            scintillaEditor.Styles[Style.Lua.String].ForeColor = Color.FromArgb(255, 247, 185);
            scintillaEditor.Styles[Style.Lua.Word].ForeColor = Color.FromArgb(255, 191, 134);
            scintillaEditor.Styles[Style.Lua.Word2].ForeColor = Color.FromArgb(255, 191, 134);
            scintillaEditor.Styles[Style.Lua.Operator].ForeColor = Color.FromArgb(255, 178, 109);
            scintillaEditor.Styles[Style.Lua.Character].ForeColor = Color.FromArgb(185, 255, 218);

            scintillaEditor.Lexer = Lexer.Lua;

            scintillaEditor.SetKeywords(0, "and break do else elseif end false for function if in local nil not or repeat return then true until while");

        }

        /// <summary>
        /// The neoblox_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void neoblox_Load(object sender, EventArgs e)
        {
            krnlExploitAPI.Initialize();

            listBox1.Items.Clear();
            PopulateListBox(listBox1, "./Scripts", "*.txt");
            PopulateListBox(listBox1, "./Scripts", "*.lua");

            InitSyntaxColoring();
            InitColors();

            try
            {
                using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts")))
                {
                    w.WriteLine("# Anti-Banwave measures for Roblox - added by Neoblox");
                    w.WriteLine("127.0.0.1 data.roblox.com");
                    w.WriteLine("127.0.0.1 roblox.sp.backtrace.io");
                }
            }
            catch
            {
                string message = "We couldn't activate Anti-Ban measures due to an unexpected error!\nTry running neoblox as an administrator!\nAlways use an alt while exploiting!";
                string title = "Anti-ban failed!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The executeButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void executeButton_Click(object sender, EventArgs e)
        {
            if (isKrnl == true)
            {
                krnlExploitAPI.Execute(scintillaEditor.Text);
            }
            if (isEasyExploit == true)
            {
                easyExploitsAPI.ExecuteScript(scintillaEditor.Text);
            }
            if (isWRD == true)
            {
                wrdExploitAPI.SendLuaScript(scintillaEditor.Text);
            }
        }

        /// <summary>
        /// The clearButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            scintillaEditor.Clear();
        }

        /// <summary>
        /// The openScriptButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void openScriptButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Scripts";
                openFileDialog.Filter = string.Format("Text files (*.txt)|*.txt|Lua files (*.lua)|*.lua", "*.lua");
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var MainText = reader.ReadToEnd();
                        scintillaEditor.Text = MainText;
                    }
                }
            }
        }

        /// <summary>
        /// The saveScriptButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void saveScriptButton_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog1 = new SaveFileDialog
                {
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Scripts",
                    Filter = string.Format("Text files (*.txt)|*.txt|Lua files (*.lua)|*.lua", "*.lua"),
                    RestoreDirectory = true,
                    ShowHelp = false,
                    CheckFileExists = false
                };
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) { File.WriteAllText(saveFileDialog1.FileName, scintillaEditor.Text); }
            }
            catch
            {

            }
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            if (isKrnl == true)
            {
                krnlExploitAPI.Inject();
            }
            if (isEasyExploit == true)
            {
                if (wrdExploitAPI.isAPIAttached())
                {
                    string message = "Cannot attach EasyExploit and WRD at the same time!";
                    string title = "EasyExploit attach failed!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
                else
                {
                    easyExploitsAPI.LaunchExploit();
                }
            }
            if (isWRD == true)
            {
                try
                {
                    if (easyExploitsAPI.isInjected())
                    {
                        string message = "Cannot attach WRD and EasyExploit at the same time!";
                        string title = "WRD attach failed!";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    }
                    else
                    {
                        wrdExploitAPI.LaunchExploit();
                    }
                }
                catch
                {
                    string message = "Attach failed. Try using attach fix.";
                    string title = "Attached failed.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
        }

        private void attachButtonFix_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Neoblox needs to restart to use attach fix!";
                string title = "Restart";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    var files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.exe");

                    foreach (var file in files)
                    {
                        if (file != "neoblox.exe")
                        {
                            Process.Start(file);
                            Application.Exit();
                        }
                    }
                }

            }
            catch
            {
                string message = "Attach fix failed! Try using the normal Attach. If that doesn't work report the bug at https://github.com/Plextora/neoblox/issues";
                string title = "Attach fix failed!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The closeButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts");
                File.WriteAllLines(path, (from l in File.ReadLines(path) where l != "127.0.0.1 data.roblox.com" select l).ToList<string>());
                File.WriteAllLines(path, (from l in File.ReadLines(path) where l != "127.0.0.1 roblox.sp.backtrace.io" select l).ToList<string>());
                File.WriteAllLines(path, (from l in File.ReadLines(path) where l != "# Anti-Banwave measures for Roblox - added by Neoblox" select l).ToList<string>());
            }
            catch
            {
                string title = "Deactivate anti-ban failed!";
                string message = "We couldn't deactivate anti-ban measures due to an unexpected error!\nRestart the program as an administrator!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
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

        private void Neoblox_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Neoblox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        /// <summary>
        /// The Panel_MouseDown.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="MouseEventArgs"/>.</param>
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// The Panel_MouseMove.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="MouseEventArgs"/>.</param>
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        /// <summary>
        /// The PopulateListBox.
        /// </summary>
        /// <param name="lsb">The lsb<see cref="ListBox"/>.</param>
        /// <param name="Folder">The Folder<see cref="string"/>.</param>
        /// <param name="FileType">The FileType<see cref="string"/>.</param>
        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

        /// <summary>
        /// The listBox1_SelectedIndexChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string script = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");

                scintillaEditor.Text = script;
            }
            catch { }
        }

        /// <summary>
        /// The refreshScriptList_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void refreshScriptList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            PopulateListBox(listBox1, "./Scripts", "*.txt");
            PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        /// <summary>
        /// The killRblx_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void killRblx_Click(object sender, EventArgs e)
        {
            Process[] processCheck = Process.GetProcessesByName("RobloxPlayerBeta");

            if (processCheck.Length == 0)
            {
                string message = "Roblox isn't running!";
                string title = "Kill roblox process failed.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    process.Kill();
                }
            }
        }

        /// <summary>
        /// The topMostCheckbox_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void topMostCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topMostCheckbox.Checked;
        }

        private void multiAPIComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (multiAPICombobox.SelectedIndex == 1)
            {
                isKrnl = true;
                isEasyExploit = false;
                isWRD = false;
            }
            if (multiAPICombobox.SelectedIndex == 2)
            {
                isEasyExploit = true;
                isKrnl = false;
                isWRD = false;
            }
            if (multiAPICombobox.SelectedIndex == 3)
            {
                isWRD = true;
                isEasyExploit = false;
                isKrnl = false;
            }
        }
    }
}