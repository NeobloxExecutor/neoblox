namespace neoblox
{
    /// <summary>
    /// Defines the <see cref="Neoblox" />.
    /// </summary>
    public partial class Neoblox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Neoblox));
            this.Panel = new System.Windows.Forms.Panel();
            this.multiAPICombobox = new ns1.SiticoneRoundedComboBox();
            this.titleLogo = new System.Windows.Forms.PictureBox();
            this.scriptHubButton = new ns1.SiticoneButton();
            this.siticoneButton3 = new ns1.SiticoneButton();
            this.siticoneButton2 = new ns1.SiticoneButton();
            this.killRblx = new ns1.SiticoneButton();
            this.discordRPCCheckbox = new ns1.SiticoneCheckBox();
            this.topMostCheckbox = new ns1.SiticoneCheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.refreshScriptList = new ns1.SiticoneButton();
            this.attachButton = new ns1.SiticoneButton();
            this.saveScriptButton = new ns1.SiticoneButton();
            this.openScriptButton = new ns1.SiticoneButton();
            this.clearButton = new ns1.SiticoneButton();
            this.executeButtonWRD = new ns1.SiticoneButton();
            this.credit = new System.Windows.Forms.Label();
            this.attachButtonFix = new ns1.SiticoneButton();
            this.monacoEditor = new System.Windows.Forms.WebBrowser();
            this.discordRPCRelaunch = new System.Windows.Forms.Timer(this.components);
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Panel.Controls.Add(this.multiAPICombobox);
            this.Panel.Controls.Add(this.titleLogo);
            this.Panel.Controls.Add(this.scriptHubButton);
            this.Panel.Controls.Add(this.siticoneButton3);
            this.Panel.Controls.Add(this.siticoneButton2);
            this.Panel.Controls.Add(this.killRblx);
            this.Panel.Controls.Add(this.discordRPCCheckbox);
            this.Panel.Controls.Add(this.topMostCheckbox);
            this.Panel.Location = new System.Drawing.Point(0, -7);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(981, 66);
            this.Panel.TabIndex = 0;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // multiAPICombobox
            // 
            this.multiAPICombobox.BackColor = System.Drawing.Color.Transparent;
            this.multiAPICombobox.BorderColor = System.Drawing.Color.PeachPuff;
            this.multiAPICombobox.DisplayMember = "2";
            this.multiAPICombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.multiAPICombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.multiAPICombobox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.multiAPICombobox.FocusedColor = System.Drawing.Color.PeachPuff;
            this.multiAPICombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.multiAPICombobox.ForeColor = System.Drawing.Color.PeachPuff;
            this.multiAPICombobox.FormattingEnabled = true;
            this.multiAPICombobox.HoveredState.Parent = this.multiAPICombobox;
            this.multiAPICombobox.ItemHeight = 30;
            this.multiAPICombobox.Items.AddRange(new object[] {
            "Multi API selection",
            "Krnl (not keyless!)",
            "EasyExploit",
            "WRD"});
            this.multiAPICombobox.ItemsAppearance.Parent = this.multiAPICombobox;
            this.multiAPICombobox.Location = new System.Drawing.Point(651, 20);
            this.multiAPICombobox.Name = "multiAPICombobox";
            this.multiAPICombobox.ShadowDecoration.Parent = this.multiAPICombobox;
            this.multiAPICombobox.Size = new System.Drawing.Size(183, 36);
            this.multiAPICombobox.StartIndex = 0;
            this.multiAPICombobox.TabIndex = 22;
            this.multiAPICombobox.SelectedIndexChanged += new System.EventHandler(this.multiAPIComboBox_SelectedIndexChanged);
            // 
            // titleLogo
            // 
            this.titleLogo.Image = ((System.Drawing.Image)(resources.GetObject("titleLogo.Image")));
            this.titleLogo.Location = new System.Drawing.Point(10, 7);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(66, 60);
            this.titleLogo.TabIndex = 22;
            this.titleLogo.TabStop = false;
            // 
            // scriptHubButton
            // 
            this.scriptHubButton.CheckedState.Parent = this.scriptHubButton;
            this.scriptHubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scriptHubButton.CustomImages.Parent = this.scriptHubButton;
            this.scriptHubButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scriptHubButton.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptHubButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.scriptHubButton.HoveredState.Parent = this.scriptHubButton;
            this.scriptHubButton.Location = new System.Drawing.Point(481, 22);
            this.scriptHubButton.Name = "scriptHubButton";
            this.scriptHubButton.ShadowDecoration.Parent = this.scriptHubButton;
            this.scriptHubButton.Size = new System.Drawing.Size(163, 33);
            this.scriptHubButton.TabIndex = 19;
            this.scriptHubButton.Text = "Click to go to script hub";
            this.scriptHubButton.Click += new System.EventHandler(this.scriptHubButton_Click);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.PeachPuff;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(906, 15);
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
            this.siticoneButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 28.14545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.PeachPuff;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(844, 15);
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
            this.killRblx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.killRblx.CustomImages.Parent = this.killRblx;
            this.killRblx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.killRblx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.killRblx.ForeColor = System.Drawing.Color.PeachPuff;
            this.killRblx.HoveredState.Parent = this.killRblx;
            this.killRblx.Location = new System.Drawing.Point(85, 22);
            this.killRblx.Name = "killRblx";
            this.killRblx.ShadowDecoration.Parent = this.killRblx;
            this.killRblx.Size = new System.Drawing.Size(133, 33);
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
            this.discordRPCCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordRPCCheckbox.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordRPCCheckbox.ForeColor = System.Drawing.Color.PeachPuff;
            this.discordRPCCheckbox.Location = new System.Drawing.Point(342, 25);
            this.discordRPCCheckbox.Name = "discordRPCCheckbox";
            this.discordRPCCheckbox.Size = new System.Drawing.Size(134, 29);
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
            this.topMostCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topMostCheckbox.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMostCheckbox.ForeColor = System.Drawing.Color.PeachPuff;
            this.topMostCheckbox.Location = new System.Drawing.Point(227, 25);
            this.topMostCheckbox.Name = "topMostCheckbox";
            this.topMostCheckbox.Size = new System.Drawing.Size(108, 29);
            this.topMostCheckbox.TabIndex = 13;
            this.topMostCheckbox.Text = "Top Most";
            this.topMostCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.topMostCheckbox.UncheckedState.BorderRadius = 2;
            this.topMostCheckbox.UncheckedState.BorderThickness = 0;
            this.topMostCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.topMostCheckbox.UseVisualStyleBackColor = false;
            this.topMostCheckbox.CheckedChanged += new System.EventHandler(this.topMostCheckbox_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.PeachPuff;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(669, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 312);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // refreshScriptList
            // 
            this.refreshScriptList.CheckedState.Parent = this.refreshScriptList;
            this.refreshScriptList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshScriptList.CustomImages.Parent = this.refreshScriptList;
            this.refreshScriptList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.refreshScriptList.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshScriptList.ForeColor = System.Drawing.Color.PeachPuff;
            this.refreshScriptList.HoveredState.Parent = this.refreshScriptList;
            this.refreshScriptList.Location = new System.Drawing.Point(10, 443);
            this.refreshScriptList.Name = "refreshScriptList";
            this.refreshScriptList.ShadowDecoration.Parent = this.refreshScriptList;
            this.refreshScriptList.Size = new System.Drawing.Size(229, 33);
            this.refreshScriptList.TabIndex = 18;
            this.refreshScriptList.Text = "Refresh script list";
            this.refreshScriptList.Click += new System.EventHandler(this.refreshScriptList_Click);
            // 
            // attachButton
            // 
            this.attachButton.CheckedState.Parent = this.attachButton;
            this.attachButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attachButton.CustomImages.Parent = this.attachButton;
            this.attachButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.attachButton.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.attachButton.HoveredState.Parent = this.attachButton;
            this.attachButton.Location = new System.Drawing.Point(245, 443);
            this.attachButton.Name = "attachButton";
            this.attachButton.ShadowDecoration.Parent = this.attachButton;
            this.attachButton.Size = new System.Drawing.Size(240, 33);
            this.attachButton.TabIndex = 17;
            this.attachButton.Text = "Attach";
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // saveScriptButton
            // 
            this.saveScriptButton.CheckedState.Parent = this.saveScriptButton;
            this.saveScriptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveScriptButton.CustomImages.Parent = this.saveScriptButton;
            this.saveScriptButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveScriptButton.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveScriptButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.saveScriptButton.HoveredState.Parent = this.saveScriptButton;
            this.saveScriptButton.Location = new System.Drawing.Point(703, 399);
            this.saveScriptButton.Name = "saveScriptButton";
            this.saveScriptButton.ShadowDecoration.Parent = this.saveScriptButton;
            this.saveScriptButton.Size = new System.Drawing.Size(264, 33);
            this.saveScriptButton.TabIndex = 16;
            this.saveScriptButton.Text = "Save script";
            this.saveScriptButton.Click += new System.EventHandler(this.saveScriptButton_Click);
            // 
            // openScriptButton
            // 
            this.openScriptButton.CheckedState.Parent = this.openScriptButton;
            this.openScriptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openScriptButton.CustomImages.Parent = this.openScriptButton;
            this.openScriptButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openScriptButton.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openScriptButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.openScriptButton.HoveredState.Parent = this.openScriptButton;
            this.openScriptButton.Location = new System.Drawing.Point(474, 399);
            this.openScriptButton.Name = "openScriptButton";
            this.openScriptButton.ShadowDecoration.Parent = this.openScriptButton;
            this.openScriptButton.Size = new System.Drawing.Size(223, 33);
            this.openScriptButton.TabIndex = 15;
            this.openScriptButton.Text = "Open script";
            this.openScriptButton.Click += new System.EventHandler(this.openScriptButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.CheckedState.Parent = this.clearButton;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.CustomImages.Parent = this.clearButton;
            this.clearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.clearButton.HoveredState.Parent = this.clearButton;
            this.clearButton.Location = new System.Drawing.Point(245, 399);
            this.clearButton.Name = "clearButton";
            this.clearButton.ShadowDecoration.Parent = this.clearButton;
            this.clearButton.Size = new System.Drawing.Size(223, 33);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // executeButtonWRD
            // 
            this.executeButtonWRD.CheckedState.Parent = this.executeButtonWRD;
            this.executeButtonWRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.executeButtonWRD.CustomImages.Parent = this.executeButtonWRD;
            this.executeButtonWRD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.executeButtonWRD.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButtonWRD.ForeColor = System.Drawing.Color.PeachPuff;
            this.executeButtonWRD.HoveredState.Parent = this.executeButtonWRD;
            this.executeButtonWRD.Location = new System.Drawing.Point(10, 399);
            this.executeButtonWRD.Name = "executeButtonWRD";
            this.executeButtonWRD.ShadowDecoration.Parent = this.executeButtonWRD;
            this.executeButtonWRD.Size = new System.Drawing.Size(229, 33);
            this.executeButtonWRD.TabIndex = 13;
            this.executeButtonWRD.Text = "Execute";
            this.executeButtonWRD.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.credit.Font = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.PeachPuff;
            this.credit.Location = new System.Drawing.Point(736, 443);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(231, 30);
            this.credit.TabIndex = 19;
            this.credit.Text = "Made by Plextora#0033";
            // 
            // attachButtonFix
            // 
            this.attachButtonFix.CheckedState.Parent = this.attachButtonFix;
            this.attachButtonFix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attachButtonFix.CustomImages.Parent = this.attachButtonFix;
            this.attachButtonFix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.attachButtonFix.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachButtonFix.ForeColor = System.Drawing.Color.PeachPuff;
            this.attachButtonFix.HoveredState.Parent = this.attachButtonFix;
            this.attachButtonFix.Location = new System.Drawing.Point(490, 443);
            this.attachButtonFix.Name = "attachButtonFix";
            this.attachButtonFix.ShadowDecoration.Parent = this.attachButtonFix;
            this.attachButtonFix.Size = new System.Drawing.Size(240, 33);
            this.attachButtonFix.TabIndex = 21;
            this.attachButtonFix.Text = "Attach (WRD fix)";
            this.attachButtonFix.Click += new System.EventHandler(this.attachButtonFix_Click);
            // 
            // monacoEditor
            // 
            this.monacoEditor.Location = new System.Drawing.Point(0, 65);
            this.monacoEditor.MinimumSize = new System.Drawing.Size(20, 20);
            this.monacoEditor.Name = "monacoEditor";
            this.monacoEditor.Size = new System.Drawing.Size(663, 317);
            this.monacoEditor.TabIndex = 1;
            // 
            // discordRPCRelaunch
            // 
            this.discordRPCRelaunch.Enabled = true;
            this.discordRPCRelaunch.Interval = 1;
            this.discordRPCRelaunch.Tick += new System.EventHandler(this.discordRPCRelaunch_Tick);
            // 
            // Neoblox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(979, 492);
            this.Controls.Add(this.attachButtonFix);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.refreshScriptList);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.saveScriptButton);
            this.Controls.Add(this.openScriptButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.executeButtonWRD);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monacoEditor);
            this.Controls.Add(this.Panel);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Neoblox";
            this.Text = "Neoblox";
            this.Load += new System.EventHandler(this.neoblox_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Neoblox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Neoblox_MouseMove);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Defines the Panel.
        /// </summary>
        private System.Windows.Forms.Panel Panel;

        /// <summary>
        /// Defines the listBox1.
        /// </summary>
        private System.Windows.Forms.ListBox listBox1;

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
        /// Defines the credit.
        /// </summary>
        private System.Windows.Forms.Label credit;

        /// <summary>
        /// Defines the siticoneButton3.
        /// </summary>
        private ns1.SiticoneButton siticoneButton3;

        /// <summary>
        /// Defines the siticoneButton2.
        /// </summary>
        private ns1.SiticoneButton siticoneButton2;
        private ns1.SiticoneButton attachButtonFix;
        private ns1.SiticoneButton scriptHubButton;
        private System.Windows.Forms.WebBrowser monacoEditor;
        private System.Windows.Forms.Timer discordRPCRelaunch;
        private ns1.SiticoneRoundedComboBox multiAPICombobox;
        private System.Windows.Forms.PictureBox titleLogo;
    }
}
