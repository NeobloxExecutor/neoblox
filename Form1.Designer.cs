namespace neoblox
{
    /// <summary>
    /// Defines the <see cref="neoblox" />.
    /// </summary>
    public partial class neoblox
    {
        /// <summary>
        /// Required designer variable..
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(neoblox));
            this.Panel = new System.Windows.Forms.Panel();
            this.multiAPIComboBox = new System.Windows.Forms.ComboBox();
            this.scriptHubButton = new ns1.SiticoneButton();
            this.musicCheckbox = new ns1.SiticoneCheckBox();
            this.siticoneButton3 = new ns1.SiticoneButton();
            this.siticoneButton2 = new ns1.SiticoneButton();
            this.killRblx = new ns1.SiticoneButton();
            this.discordRPCCheckbox = new ns1.SiticoneCheckBox();
            this.topMostCheckbox = new ns1.SiticoneCheckBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fpsCapLabel = new System.Windows.Forms.Label();
            this.fpsCapTextbox = new System.Windows.Forms.TextBox();
            this.flyLabel = new System.Windows.Forms.Label();
            this.refreshScriptList = new ns1.SiticoneButton();
            this.attachButton = new ns1.SiticoneButton();
            this.saveScriptButton = new ns1.SiticoneButton();
            this.openScriptButton = new ns1.SiticoneButton();
            this.clearButton = new ns1.SiticoneButton();
            this.executeButtonWRD = new ns1.SiticoneButton();
            this.icon = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.onButtonFly = new ns1.SiticoneButton();
            this.attachButtonFix = new ns1.SiticoneButton();
            this.monacoEditor = new System.Windows.Forms.WebBrowser();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Panel.Controls.Add(this.multiAPIComboBox);
            this.Panel.Controls.Add(this.scriptHubButton);
            this.Panel.Controls.Add(this.musicCheckbox);
            this.Panel.Controls.Add(this.siticoneButton3);
            this.Panel.Controls.Add(this.siticoneButton2);
            this.Panel.Controls.Add(this.killRblx);
            this.Panel.Controls.Add(this.discordRPCCheckbox);
            this.Panel.Controls.Add(this.topMostCheckbox);
            this.Panel.Controls.Add(this.titleLabel);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1447, 49);
            this.Panel.TabIndex = 0;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // multiAPIComboBox
            // 
            this.multiAPIComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.multiAPIComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiAPIComboBox.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiAPIComboBox.ForeColor = System.Drawing.Color.PeachPuff;
            this.multiAPIComboBox.FormattingEnabled = true;
            this.multiAPIComboBox.Items.AddRange(new object[] {
            "Krnl (not keyless!)",
            "EasyExploit",
            "WRD"});
            this.multiAPIComboBox.Location = new System.Drawing.Point(861, 15);
            this.multiAPIComboBox.Name = "multiAPIComboBox";
            this.multiAPIComboBox.Size = new System.Drawing.Size(121, 21);
            this.multiAPIComboBox.TabIndex = 21;
            this.multiAPIComboBox.Text = "Multi API selection";
            this.multiAPIComboBox.SelectedIndexChanged += new System.EventHandler(this.multiAPIComboBox_SelectedIndexChanged);
            // 
            // scriptHubButton
            // 
            this.scriptHubButton.CheckedState.Parent = this.scriptHubButton;
            this.scriptHubButton.CustomImages.Parent = this.scriptHubButton;
            this.scriptHubButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scriptHubButton.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptHubButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.scriptHubButton.HoveredState.Parent = this.scriptHubButton;
            this.scriptHubButton.Location = new System.Drawing.Point(683, 8);
            this.scriptHubButton.Name = "scriptHubButton";
            this.scriptHubButton.ShadowDecoration.Parent = this.scriptHubButton;
            this.scriptHubButton.Size = new System.Drawing.Size(172, 33);
            this.scriptHubButton.TabIndex = 19;
            this.scriptHubButton.Text = "Click to go to script hub";
            this.scriptHubButton.Click += new System.EventHandler(this.scriptHubButton_Click);
            // 
            // musicCheckbox
            // 
            this.musicCheckbox.AutoSize = true;
            this.musicCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.musicCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.musicCheckbox.CheckedState.BorderRadius = 2;
            this.musicCheckbox.CheckedState.BorderThickness = 0;
            this.musicCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.musicCheckbox.Font = new System.Drawing.Font("Segoe UI", 13.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicCheckbox.ForeColor = System.Drawing.Color.PeachPuff;
            this.musicCheckbox.Location = new System.Drawing.Point(590, 7);
            this.musicCheckbox.Name = "musicCheckbox";
            this.musicCheckbox.Size = new System.Drawing.Size(87, 34);
            this.musicCheckbox.TabIndex = 18;
            this.musicCheckbox.Text = "Music";
            this.musicCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.musicCheckbox.UncheckedState.BorderRadius = 2;
            this.musicCheckbox.UncheckedState.BorderThickness = 0;
            this.musicCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.musicCheckbox.UseVisualStyleBackColor = false;
            this.musicCheckbox.CheckedChanged += new System.EventHandler(this.musicCheckbox_CheckedChanged);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.PeachPuff;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(1372, 3);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(62, 43);
            this.siticoneButton3.TabIndex = 17;
            this.siticoneButton3.Text = "X";
            this.siticoneButton3.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 28.14545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.PeachPuff;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(1308, 3);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(62, 43);
            this.siticoneButton2.TabIndex = 16;
            this.siticoneButton2.Text = "-";
            this.siticoneButton2.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // killRblx
            // 
            this.killRblx.CheckedState.Parent = this.killRblx;
            this.killRblx.CustomImages.Parent = this.killRblx;
            this.killRblx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.killRblx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.killRblx.ForeColor = System.Drawing.Color.PeachPuff;
            this.killRblx.HoveredState.Parent = this.killRblx;
            this.killRblx.Location = new System.Drawing.Point(136, 8);
            this.killRblx.Name = "killRblx";
            this.killRblx.ShadowDecoration.Parent = this.killRblx;
            this.killRblx.Size = new System.Drawing.Size(172, 33);
            this.killRblx.TabIndex = 15;
            this.killRblx.Text = "Kill Roblox Process";
            this.killRblx.Click += new System.EventHandler(this.killRblx_Click);
            // 
            // discordRPCCheckbox
            // 
            this.discordRPCCheckbox.AutoSize = true;
            this.discordRPCCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.discordRPCCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discordRPCCheckbox.CheckedState.BorderRadius = 2;
            this.discordRPCCheckbox.CheckedState.BorderThickness = 0;
            this.discordRPCCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discordRPCCheckbox.Font = new System.Drawing.Font("Segoe UI", 13.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordRPCCheckbox.ForeColor = System.Drawing.Color.PeachPuff;
            this.discordRPCCheckbox.Location = new System.Drawing.Point(438, 7);
            this.discordRPCCheckbox.Name = "discordRPCCheckbox";
            this.discordRPCCheckbox.Size = new System.Drawing.Size(146, 34);
            this.discordRPCCheckbox.TabIndex = 14;
            this.discordRPCCheckbox.Text = "Discord RPC";
            this.discordRPCCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.discordRPCCheckbox.UncheckedState.BorderRadius = 2;
            this.discordRPCCheckbox.UncheckedState.BorderThickness = 0;
            this.discordRPCCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.discordRPCCheckbox.UseVisualStyleBackColor = false;
            this.discordRPCCheckbox.CheckedChanged += new System.EventHandler(this.discordRPCCheckbox_CheckedChanged);
            // 
            // topMostCheckbox
            // 
            this.topMostCheckbox.AutoSize = true;
            this.topMostCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.topMostCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topMostCheckbox.CheckedState.BorderRadius = 2;
            this.topMostCheckbox.CheckedState.BorderThickness = 0;
            this.topMostCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topMostCheckbox.Font = new System.Drawing.Font("Segoe UI", 13.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMostCheckbox.ForeColor = System.Drawing.Color.PeachPuff;
            this.topMostCheckbox.Location = new System.Drawing.Point(314, 7);
            this.topMostCheckbox.Name = "topMostCheckbox";
            this.topMostCheckbox.Size = new System.Drawing.Size(118, 34);
            this.topMostCheckbox.TabIndex = 13;
            this.topMostCheckbox.Text = "Top Most";
            this.topMostCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.topMostCheckbox.UncheckedState.BorderRadius = 2;
            this.topMostCheckbox.UncheckedState.BorderThickness = 0;
            this.topMostCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.topMostCheckbox.UseVisualStyleBackColor = false;
            this.topMostCheckbox.CheckedChanged += new System.EventHandler(this.topMostCheckbox_CheckedChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.titleLabel.Location = new System.Drawing.Point(9, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(121, 38);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Neoblox";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.PeachPuff;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1205, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 325);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // fpsCapLabel
            // 
            this.fpsCapLabel.AutoSize = true;
            this.fpsCapLabel.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsCapLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.fpsCapLabel.Location = new System.Drawing.Point(547, 453);
            this.fpsCapLabel.Name = "fpsCapLabel";
            this.fpsCapLabel.Size = new System.Drawing.Size(145, 17);
            this.fpsCapLabel.TabIndex = 3;
            this.fpsCapLabel.Text = "Change FPS cap (WRD):";
            // 
            // fpsCapTextbox
            // 
            this.fpsCapTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fpsCapTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpsCapTextbox.Font = new System.Drawing.Font("Hack NF", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsCapTextbox.ForeColor = System.Drawing.Color.Silver;
            this.fpsCapTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fpsCapTextbox.Location = new System.Drawing.Point(696, 453);
            this.fpsCapTextbox.Name = "fpsCapTextbox";
            this.fpsCapTextbox.Size = new System.Drawing.Size(100, 20);
            this.fpsCapTextbox.TabIndex = 9;
            this.fpsCapTextbox.TabStop = false;
            this.fpsCapTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fpsCapTextbox_KeyDown);
            // 
            // flyLabel
            // 
            this.flyLabel.AutoSize = true;
            this.flyLabel.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flyLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.flyLabel.Location = new System.Drawing.Point(811, 452);
            this.flyLabel.Name = "flyLabel";
            this.flyLabel.Size = new System.Drawing.Size(27, 20);
            this.flyLabel.TabIndex = 10;
            this.flyLabel.Text = "Fly";
            // 
            // refreshScriptList
            // 
            this.refreshScriptList.CheckedState.Parent = this.refreshScriptList;
            this.refreshScriptList.CustomImages.Parent = this.refreshScriptList;
            this.refreshScriptList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.refreshScriptList.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshScriptList.ForeColor = System.Drawing.Color.PeachPuff;
            this.refreshScriptList.HoveredState.Parent = this.refreshScriptList;
            this.refreshScriptList.Location = new System.Drawing.Point(16, 440);
            this.refreshScriptList.Name = "refreshScriptList";
            this.refreshScriptList.ShadowDecoration.Parent = this.refreshScriptList;
            this.refreshScriptList.Size = new System.Drawing.Size(512, 33);
            this.refreshScriptList.TabIndex = 18;
            this.refreshScriptList.Text = "Refresh script list";
            this.refreshScriptList.Click += new System.EventHandler(this.refreshScriptList_Click);
            // 
            // attachButton
            // 
            this.attachButton.CheckedState.Parent = this.attachButton;
            this.attachButton.CustomImages.Parent = this.attachButton;
            this.attachButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.attachButton.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.attachButton.HoveredState.Parent = this.attachButton;
            this.attachButton.Location = new System.Drawing.Point(802, 399);
            this.attachButton.Name = "attachButton";
            this.attachButton.ShadowDecoration.Parent = this.attachButton;
            this.attachButton.Size = new System.Drawing.Size(194, 33);
            this.attachButton.TabIndex = 17;
            this.attachButton.Text = "Attach";
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // saveScriptButton
            // 
            this.saveScriptButton.CheckedState.Parent = this.saveScriptButton;
            this.saveScriptButton.CustomImages.Parent = this.saveScriptButton;
            this.saveScriptButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveScriptButton.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveScriptButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.saveScriptButton.HoveredState.Parent = this.saveScriptButton;
            this.saveScriptButton.Location = new System.Drawing.Point(602, 399);
            this.saveScriptButton.Name = "saveScriptButton";
            this.saveScriptButton.ShadowDecoration.Parent = this.saveScriptButton;
            this.saveScriptButton.Size = new System.Drawing.Size(194, 33);
            this.saveScriptButton.TabIndex = 16;
            this.saveScriptButton.Text = "Save script";
            this.saveScriptButton.Click += new System.EventHandler(this.saveScriptButton_Click);
            // 
            // openScriptButton
            // 
            this.openScriptButton.CheckedState.Parent = this.openScriptButton;
            this.openScriptButton.CustomImages.Parent = this.openScriptButton;
            this.openScriptButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openScriptButton.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openScriptButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.openScriptButton.HoveredState.Parent = this.openScriptButton;
            this.openScriptButton.Location = new System.Drawing.Point(402, 399);
            this.openScriptButton.Name = "openScriptButton";
            this.openScriptButton.ShadowDecoration.Parent = this.openScriptButton;
            this.openScriptButton.Size = new System.Drawing.Size(194, 33);
            this.openScriptButton.TabIndex = 15;
            this.openScriptButton.Text = "Open script";
            this.openScriptButton.Click += new System.EventHandler(this.openScriptButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.CheckedState.Parent = this.clearButton;
            this.clearButton.CustomImages.Parent = this.clearButton;
            this.clearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.clearButton.HoveredState.Parent = this.clearButton;
            this.clearButton.Location = new System.Drawing.Point(202, 399);
            this.clearButton.Name = "clearButton";
            this.clearButton.ShadowDecoration.Parent = this.clearButton;
            this.clearButton.Size = new System.Drawing.Size(194, 33);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // executeButtonWRD
            // 
            this.executeButtonWRD.CheckedState.Parent = this.executeButtonWRD;
            this.executeButtonWRD.CustomImages.Parent = this.executeButtonWRD;
            this.executeButtonWRD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.executeButtonWRD.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButtonWRD.ForeColor = System.Drawing.Color.PeachPuff;
            this.executeButtonWRD.HoveredState.Parent = this.executeButtonWRD;
            this.executeButtonWRD.Location = new System.Drawing.Point(16, 399);
            this.executeButtonWRD.Name = "executeButtonWRD";
            this.executeButtonWRD.ShadowDecoration.Parent = this.executeButtonWRD;
            this.executeButtonWRD.Size = new System.Drawing.Size(180, 33);
            this.executeButtonWRD.TabIndex = 13;
            this.executeButtonWRD.Text = "Execute";
            this.executeButtonWRD.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // icon
            // 
            this.icon.AutoSize = true;
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.icon.Font = new System.Drawing.Font("Hack NF", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon.ForeColor = System.Drawing.Color.PeachPuff;
            this.icon.Location = new System.Drawing.Point(1251, 443);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 33);
            this.icon.TabIndex = 20;
            this.icon.Text = "";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.credit.Font = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.PeachPuff;
            this.credit.Location = new System.Drawing.Point(1025, 444);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(231, 30);
            this.credit.TabIndex = 19;
            this.credit.Text = "Made by Plextora#0033";
            // 
            // onButtonFly
            // 
            this.onButtonFly.CheckedState.Parent = this.onButtonFly;
            this.onButtonFly.CustomImages.Parent = this.onButtonFly;
            this.onButtonFly.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.onButtonFly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onButtonFly.ForeColor = System.Drawing.Color.PeachPuff;
            this.onButtonFly.HoveredState.Parent = this.onButtonFly;
            this.onButtonFly.Location = new System.Drawing.Point(847, 449);
            this.onButtonFly.Name = "onButtonFly";
            this.onButtonFly.ShadowDecoration.Parent = this.onButtonFly;
            this.onButtonFly.Size = new System.Drawing.Size(172, 27);
            this.onButtonFly.TabIndex = 16;
            this.onButtonFly.Text = "On (Press E to toggle)";
            this.onButtonFly.Click += new System.EventHandler(this.onButtonFly_Click);
            // 
            // attachButtonFix
            // 
            this.attachButtonFix.CheckedState.Parent = this.attachButtonFix;
            this.attachButtonFix.CustomImages.Parent = this.attachButtonFix;
            this.attachButtonFix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.attachButtonFix.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachButtonFix.ForeColor = System.Drawing.Color.PeachPuff;
            this.attachButtonFix.HoveredState.Parent = this.attachButtonFix;
            this.attachButtonFix.Location = new System.Drawing.Point(1002, 399);
            this.attachButtonFix.Name = "attachButtonFix";
            this.attachButtonFix.ShadowDecoration.Parent = this.attachButtonFix;
            this.attachButtonFix.Size = new System.Drawing.Size(194, 33);
            this.attachButtonFix.TabIndex = 21;
            this.attachButtonFix.Text = "Attach (WRD fix)";
            this.attachButtonFix.Click += new System.EventHandler(this.attachButtonFix_Click);
            // 
            // monacoEditor
            // 
            this.monacoEditor.Location = new System.Drawing.Point(0, 47);
            this.monacoEditor.MinimumSize = new System.Drawing.Size(20, 20);
            this.monacoEditor.Name = "monacoEditor";
            this.monacoEditor.Size = new System.Drawing.Size(1202, 335);
            this.monacoEditor.TabIndex = 1;
            // 
            // neoblox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1446, 492);
            this.Controls.Add(this.attachButtonFix);
            this.Controls.Add(this.onButtonFly);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.refreshScriptList);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.saveScriptButton);
            this.Controls.Add(this.openScriptButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.executeButtonWRD);
            this.Controls.Add(this.flyLabel);
            this.Controls.Add(this.fpsCapTextbox);
            this.Controls.Add(this.fpsCapLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monacoEditor);
            this.Controls.Add(this.Panel);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "neoblox";
            this.Text = "Neoblox";
            this.Load += new System.EventHandler(this.neoblox_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Defines the Panel.
        /// </summary>
        private System.Windows.Forms.Panel Panel;

        /// <summary>
        /// Defines the titleLabel.
        /// </summary>
        private System.Windows.Forms.Label titleLabel;

        /// <summary>
        /// Defines the listBox1.
        /// </summary>
        private System.Windows.Forms.ListBox listBox1;

        /// <summary>
        /// Defines the walkspeedLabel.
        /// </summary>
        private System.Windows.Forms.Label fpsCapLabel;

        /// <summary>
        /// Defines the walkspeedTextbox.
        /// </summary>
        private System.Windows.Forms.TextBox fpsCapTextbox;

        /// <summary>
        /// Defines the flyLabel.
        /// </summary>
        private System.Windows.Forms.Label flyLabel;

        /// <summary>
        /// Defines the refreshScriptList.
        /// </summary>
        private ns1.SiticoneButton refreshScriptList;

        /// <summary>
        /// Defines the injectButton.
        /// </summary>
        private ns1.SiticoneButton attachButton;

        /// <summary>
        /// Defines the saveScriptButton.
        /// </summary>
        private ns1.SiticoneButton saveScriptButton;

        /// <summary>
        /// Defines the openScriptButton.
        /// </summary>
        private ns1.SiticoneButton openScriptButton;

        /// <summary>
        /// Defines the clearButton.
        /// </summary>
        private ns1.SiticoneButton clearButton;

        /// <summary>
        /// Defines the executeButton.
        /// </summary>
        private ns1.SiticoneButton executeButtonWRD;

        /// <summary>
        /// Defines the killRblx.
        /// </summary>
        private ns1.SiticoneButton killRblx;

        /// <summary>
        /// Defines the discordRPCCheckbox.
        /// </summary>
        private ns1.SiticoneCheckBox discordRPCCheckbox;

        /// <summary>
        /// Defines the topMostCheckbox.
        /// </summary>
        private ns1.SiticoneCheckBox topMostCheckbox;

        /// <summary>
        /// Defines the icon.
        /// </summary>
        private System.Windows.Forms.Label icon;

        /// <summary>
        /// Defines the credit.
        /// </summary>
        private System.Windows.Forms.Label credit;

        /// <summary>
        /// Defines the onButtonFly.
        /// </summary>
        private ns1.SiticoneButton onButtonFly;

        /// <summary>
        /// Defines the siticoneButton3.
        /// </summary>
        private ns1.SiticoneButton siticoneButton3;

        /// <summary>
        /// Defines the siticoneButton2.
        /// </summary>
        private ns1.SiticoneButton siticoneButton2;

        /// <summary>
        /// Defines the musicCheckbox.
        /// </summary>
        private ns1.SiticoneCheckBox musicCheckbox;
        private ns1.SiticoneButton attachButtonFix;
        private ns1.SiticoneButton scriptHubButton;
        private System.Windows.Forms.WebBrowser monacoEditor;
        private System.Windows.Forms.ComboBox multiAPIComboBox;
    }
}
