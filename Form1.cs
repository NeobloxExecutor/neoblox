namespace neoblox
{
    using Microsoft.Win32;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using Utility;
    using WeAreDevs_API;
    using KrnlAPI;
    using EasyExploits;
    using DiscordRPC;

    /// <summary>
    /// Defines the <see cref="neoblox" />.
    /// </summary>
    public partial class neoblox : FadeForm
    {
        ExploitAPI wrdExploitAPI = new ExploitAPI();

        KrnlApi krnlExploitAPI = new KrnlApi();

        EasyExploits.Module easyExploitsAPI = new EasyExploits.Module();


        bool isKrnl;
        bool isEasyExploit;
        bool isWRD;

        /// <summary>
        /// Initializes a new instance of the <see cref="neoblox"/> class.
        /// </summary>
        public neoblox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The config.
        /// </summary>
        public void config()
        {
            string topMostOn = "topmost:neutral";

            string discordRPCOn = "discordrpc:neutral";

            string musicOn = "music:neutral";

            // mfw if statements go brr

            if (topMostCheckbox.Checked == true)
            {
                topMostOn = "topmost:true";
            }
            if (topMostCheckbox.Checked == false)
            {
                topMostOn = "topmost:false";
            }
            if (discordRPCCheckbox.Checked == true)
            {
                discordRPCOn = "discordrpc:true";
            }
            if (discordRPCCheckbox.Checked == false)
            {
                discordRPCOn = "discordrpc:false";
            }
            if (musicCheckbox.Checked == true)
            {
                musicOn = "music:true";
            }
            if (musicCheckbox.Checked == false)
            {
                musicOn = "music:false";
            }

            using (StreamWriter writer = new StreamWriter("config.txt"))
            {
                writer.WriteLine(topMostOn);
                writer.WriteLine(discordRPCOn);
                writer.WriteLine(musicOn);
            }
        }

        /// <summary>
        /// Defines the wc.
        /// </summary>
        internal WebClient wc = new WebClient();

        /// <summary>
        /// Defines the defPath.
        /// </summary>
        private string defPath = Application.StartupPath + "//Monaco//";

        /// <summary>
        /// The AddIntel.
        /// </summary>
        /// <param name="label">The label<see cref="string"/>.</param>
        /// <param name="kind">The kind<see cref="string"/>.</param>
        /// <param name="detail">The detail<see cref="string"/>.</param>
        /// <param name="insertText">The insertText<see cref="string"/>.</param>
        private void AddIntel(string label, string kind, string detail, string insertText)
        {
            string text = "\"" + label + "\"";
            string text2 = "\"" + kind + "\"";
            string text3 = "\"" + detail + "\"";
            string text4 = "\"" + insertText + "\"";
            monacoEditor.Document.InvokeScript("AddIntellisense", new object[]
            {
                label,
                kind,
                detail,
                insertText
            });
        }

        /// <summary>
        /// The AddGlobalF.
        /// </summary>
        private void AddGlobalF()
        {
            string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
            foreach (string text in array)
            {
                bool flag = text.Contains(':');
                if (flag)
                {
                    this.AddIntel(text, "Function", text, text.Substring(1));
                }
                else
                {
                    this.AddIntel(text, "Function", text, text);
                }
            }
        }

        /// <summary>
        /// The AddGlobalV.
        /// </summary>
        private void AddGlobalV()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
            {
                this.AddIntel(text, "Variable", text, text);
            }
        }

        /// <summary>
        /// The AddGlobalNS.
        /// </summary>
        private void AddGlobalNS()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
            {
                this.AddIntel(text, "Class", text, text);
            }
        }

        /// <summary>
        /// The AddMath.
        /// </summary>
        private void AddMath()
        {
            foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
            {
                this.AddIntel(text, "Method", text, text);
            }
        }

        /// <summary>
        /// The AddBase.
        /// </summary>
        private void AddBase()
        {
            foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
            {
                this.AddIntel(text, "Keyword", text, text);
            }
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


            WebClient wc = new WebClient
            {
                Proxy = null
            };
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = registryKey.GetValue(friendlyName) == null;
                if (flag2)
                {
                    registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
                }
                registryKey = null;
                friendlyName = null;
            }
            catch (Exception)
            {
            }
            monacoEditor.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
            await Task.Delay(500);
            AddBase();
            AddMath();
            AddGlobalNS();
            AddGlobalV();
            AddGlobalF();

            if (!File.Exists("config.txt"))
            {
                File.Create("config.txt");
            }

            string contents = File.ReadAllText("config.txt");
            if (contents.Contains("topmost:true"))
            {
                topMostCheckbox.Checked = true;
            }
            if (contents.Contains("topmost:false"))
            {
                topMostCheckbox.Checked = false;
            }
            if (contents.Contains("discordrpc:true"))
            {
                discordRPCCheckbox.Checked = true;
            }
            if (contents.Contains("discordrpc:false"))
            {
                discordRPCCheckbox.Checked = false;
            }
            if (contents.Contains("music:true"))
            {
                musicCheckbox.Checked = true;
            }
            if (contents.Contains("music:false"))
            {
                musicCheckbox.Checked = false;
            }

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
                MessageBox.Show("We couldn't activate Anti-Ban measures due to an unexpected error!\nTry running neoblox as an administrator!\nAlways use an alt while exploiting!");
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
                HtmlDocument document = monacoEditor.Document;
                string scriptName = "GetText";
                object[] args = new string[0];
                object obj = document.InvokeScript(scriptName, args);
                string script = obj.ToString();

                krnlExploitAPI.Execute(script);
            }
            if (isEasyExploit == true)
            {
                HtmlDocument document = monacoEditor.Document;
                string scriptName = "GetText";
                object[] args = new string[0];
                object obj = document.InvokeScript(scriptName, args);
                string script = obj.ToString();

                easyExploitsAPI.ExecuteScript(script);
            }
            if (isWRD == true)
            {
                HtmlDocument document = monacoEditor.Document;
                string scriptName = "GetText";
                object[] args = new string[0];
                object obj = document.InvokeScript(scriptName, args);
                string script = obj.ToString();

                wrdExploitAPI.SendLuaScript(script);
            }
        }

        /// <summary>
        /// The clearButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            monacoEditor.Document.InvokeScript("SetText", new object[]
            {
                ""
            });
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
                        monacoEditor.Document.InvokeScript("SetText", new object[]
                        {
                            MainText
                        });
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
            HtmlDocument document = monacoEditor.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();

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
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) { File.WriteAllText(saveFileDialog1.FileName, script); }
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
                    MessageBox.Show("Cannot attach EasyExploit and WRD at the same time!");
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
                        MessageBox.Show("Cannot attach WRD and EasyExploit at the same time!");
                    }
                    else
                    {
                        wrdExploitAPI.LaunchExploit();
                    }
                }
                catch
                {
                    MessageBox.Show("Attach failed. Try using attach fix");
                }
            }
        }

        private void attachButtonFix_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("finj.exe");
            }
            catch
            {
                MessageBox.Show("Attach fix failed! Try using the normal Attach. If that doesn't work report the bug at https://github.com/Plextora/neoblox/issues");
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
                MessageBox.Show("We couldn't deactivate anti-ban measures due to an unexpected error!\nRestart the program as an administrator!");
            }

            var discordRPC = new DiscordRpcClient("953316205001842718");
            discordRPC.Initialize();

            discordRPC.Deinitialize();
            discordRPC.Dispose();

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
            monacoEditor.Document.InvokeScript("SetText", new object[]
            {
                File.ReadAllText($"./Scripts/{listBox1.SelectedItem}")
            });
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
        /// The fpsCapTextbox_KeyDown.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyEventArgs"/>.</param>
        private void fpsCapTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool isIntInText = fpsCapTextbox.Text.All(char.IsDigit);
                if (isIntInText)
                {
                    string fpsCap = fpsCapTextbox.Text;
                    wrdExploitAPI.SendLuaScript($"set_fps_cap({fpsCap})");
                }
            }
        }

        /// <summary>
        /// The onButtonFly_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void onButtonFly_Click(object sender, EventArgs e)
        {
            wrdExploitAPI.SendLuaScript("loadstring(game:HttpGet('https://pastebin.com/raw/ETeUDwvV', true))()");
        }

        /// <summary>
        /// The killRblx_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void killRblx_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
            {
                process.Kill();
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

            config();
        }

        /// <summary>
        /// The discordRPCCheckbox_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void discordRPCCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (discordRPCCheckbox.Checked == true)
            {
                var discordRPC = new DiscordRpcClient("953316205001842718");
                discordRPC.Initialize();

                discordRPC.SetPresence(new RichPresence()
                {
                    Timestamps = Timestamps.Now,
                    Details = "Exploiting in Roblox using Neoblox",
                    Assets = new Assets()
                    {
                        LargeImageKey = "neoblox-icon",
                        LargeImageText = "Made by Plextora#0033",
                    }
                });
            }

            if (discordRPCCheckbox.Checked == false)
            {
                var discordRPC = new DiscordRpcClient("953316205001842718");
                discordRPC.Initialize();

                discordRPC.Deinitialize();
                discordRPC.Dispose();
            }

            config();
        }

        /// <summary>
        /// The musicCheckbox_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void musicCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            var soundPlayer = new System.Media.SoundPlayer();
            if (musicCheckbox.Checked == true)
            {
                soundPlayer.SoundLocation = "https://us-east-1.tixte.net/uploads/plextora.is-from.space/elevatormusic.wav";
                soundPlayer.PlayLooping();
            }
            if (musicCheckbox.Checked == false)
            {
                soundPlayer.Stop();
            }

            config();
        }

        private void scriptHubButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScriptHub sh = new ScriptHub();
            sh.ShowDialog();
        }

        private void multiAPIComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (multiAPIComboBox.SelectedIndex == 0)
            {
                isKrnl = true;
                isEasyExploit = false;
                isWRD = false;
            }
            if (multiAPIComboBox.SelectedIndex == 1)
            {
                isEasyExploit = true;
                isKrnl = false;
                isWRD = false;
            }
            if (multiAPIComboBox.SelectedIndex == 2)
            {
                isWRD = true;
                isEasyExploit = false;
                isKrnl = false;
            }
        }
    }
}
