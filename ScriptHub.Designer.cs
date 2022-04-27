
namespace neoblox
{
    partial class ScriptHub
    {
        /// <summary>
        /// Required designer variable.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.scriptHubButton = new ns1.SiticoneButton();
            this.minimizeButton = new ns1.SiticoneButton();
            this.closeButton = new ns1.SiticoneButton();
            this.xrayScript = new ns1.SiticoneButton();
            this.infiniteJumpScript = new ns1.SiticoneButton();
            this.qToTP = new ns1.SiticoneButton();
            this.phantomForcesSilentAim = new ns1.SiticoneButton();
            this.phantomForcesESP = new ns1.SiticoneButton();
            this.icon = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.injectButtonFix = new ns1.SiticoneButton();
            this.injectButton = new ns1.SiticoneButton();
            this.katGUI = new ns1.SiticoneButton();
            this.mm2GUI = new ns1.SiticoneButton();
            this.injectCheckLabel = new System.Windows.Forms.Label();
            this.checkInjectedTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.titleLabel.Location = new System.Drawing.Point(3, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(268, 38);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Neoblox (script hub)";
            // 
            // scriptHubButton
            // 
            this.scriptHubButton.CheckedState.Parent = this.scriptHubButton;
            this.scriptHubButton.CustomImages.Parent = this.scriptHubButton;
            this.scriptHubButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scriptHubButton.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptHubButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.scriptHubButton.HoveredState.Parent = this.scriptHubButton;
            this.scriptHubButton.Location = new System.Drawing.Point(277, 13);
            this.scriptHubButton.Name = "scriptHubButton";
            this.scriptHubButton.ShadowDecoration.Parent = this.scriptHubButton;
            this.scriptHubButton.Size = new System.Drawing.Size(172, 33);
            this.scriptHubButton.TabIndex = 20;
            this.scriptHubButton.Text = "Click to leave script hub";
            this.scriptHubButton.Click += new System.EventHandler(this.scriptHubButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.CheckedState.Parent = this.minimizeButton;
            this.minimizeButton.CustomImages.Parent = this.minimizeButton;
            this.minimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 28.14545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.minimizeButton.HoveredState.Parent = this.minimizeButton;
            this.minimizeButton.Location = new System.Drawing.Point(735, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.ShadowDecoration.Parent = this.minimizeButton;
            this.minimizeButton.Size = new System.Drawing.Size(62, 43);
            this.minimizeButton.TabIndex = 21;
            this.minimizeButton.Text = "-";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.CustomImages.Parent = this.closeButton;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.closeButton.HoveredState.Parent = this.closeButton;
            this.closeButton.Location = new System.Drawing.Point(803, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(62, 43);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // xrayScript
            // 
            this.xrayScript.CheckedState.Parent = this.xrayScript;
            this.xrayScript.CustomImages.Parent = this.xrayScript;
            this.xrayScript.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.xrayScript.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrayScript.ForeColor = System.Drawing.Color.PeachPuff;
            this.xrayScript.HoveredState.Parent = this.xrayScript;
            this.xrayScript.Location = new System.Drawing.Point(12, 63);
            this.xrayScript.Name = "xrayScript";
            this.xrayScript.ShadowDecoration.Parent = this.xrayScript;
            this.xrayScript.Size = new System.Drawing.Size(170, 43);
            this.xrayScript.TabIndex = 23;
            this.xrayScript.Text = "Xray script (X to toggle)";
            this.xrayScript.Click += new System.EventHandler(this.xrayScript_Click);
            // 
            // infiniteJumpScript
            // 
            this.infiniteJumpScript.CheckedState.Parent = this.infiniteJumpScript;
            this.infiniteJumpScript.CustomImages.Parent = this.infiniteJumpScript;
            this.infiniteJumpScript.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.infiniteJumpScript.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infiniteJumpScript.ForeColor = System.Drawing.Color.PeachPuff;
            this.infiniteJumpScript.HoveredState.Parent = this.infiniteJumpScript;
            this.infiniteJumpScript.Location = new System.Drawing.Point(188, 63);
            this.infiniteJumpScript.Name = "infiniteJumpScript";
            this.infiniteJumpScript.ShadowDecoration.Parent = this.infiniteJumpScript;
            this.infiniteJumpScript.Size = new System.Drawing.Size(125, 43);
            this.infiniteJumpScript.TabIndex = 24;
            this.infiniteJumpScript.Text = "Infinite Jump";
            this.infiniteJumpScript.Click += new System.EventHandler(this.infiniteJumpScript_Click);
            // 
            // qToTP
            // 
            this.qToTP.CheckedState.Parent = this.qToTP;
            this.qToTP.CustomImages.Parent = this.qToTP;
            this.qToTP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.qToTP.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qToTP.ForeColor = System.Drawing.Color.PeachPuff;
            this.qToTP.HoveredState.Parent = this.qToTP;
            this.qToTP.Location = new System.Drawing.Point(319, 63);
            this.qToTP.Name = "qToTP";
            this.qToTP.ShadowDecoration.Parent = this.qToTP;
            this.qToTP.Size = new System.Drawing.Size(125, 43);
            this.qToTP.TabIndex = 25;
            this.qToTP.Text = "Ctrl + click TP";
            this.qToTP.Click += new System.EventHandler(this.ctrlClickToTP_Click);
            // 
            // phantomForcesSilentAim
            // 
            this.phantomForcesSilentAim.CheckedState.Parent = this.phantomForcesSilentAim;
            this.phantomForcesSilentAim.CustomImages.Parent = this.phantomForcesSilentAim;
            this.phantomForcesSilentAim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.phantomForcesSilentAim.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phantomForcesSilentAim.ForeColor = System.Drawing.Color.PeachPuff;
            this.phantomForcesSilentAim.HoveredState.Parent = this.phantomForcesSilentAim;
            this.phantomForcesSilentAim.Location = new System.Drawing.Point(450, 63);
            this.phantomForcesSilentAim.Name = "phantomForcesSilentAim";
            this.phantomForcesSilentAim.ShadowDecoration.Parent = this.phantomForcesSilentAim;
            this.phantomForcesSilentAim.Size = new System.Drawing.Size(196, 43);
            this.phantomForcesSilentAim.TabIndex = 26;
            this.phantomForcesSilentAim.Text = "Phantom Forces silent aim";
            this.phantomForcesSilentAim.Click += new System.EventHandler(this.phantomForcesSilentAim_Click);
            // 
            // phantomForcesESP
            // 
            this.phantomForcesESP.CheckedState.Parent = this.phantomForcesESP;
            this.phantomForcesESP.CustomImages.Parent = this.phantomForcesESP;
            this.phantomForcesESP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.phantomForcesESP.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phantomForcesESP.ForeColor = System.Drawing.Color.PeachPuff;
            this.phantomForcesESP.HoveredState.Parent = this.phantomForcesESP;
            this.phantomForcesESP.Location = new System.Drawing.Point(652, 63);
            this.phantomForcesESP.Name = "phantomForcesESP";
            this.phantomForcesESP.ShadowDecoration.Parent = this.phantomForcesESP;
            this.phantomForcesESP.Size = new System.Drawing.Size(182, 43);
            this.phantomForcesESP.TabIndex = 27;
            this.phantomForcesESP.Text = "Phantom Forces ESP";
            this.phantomForcesESP.Click += new System.EventHandler(this.phantomForcesESP_Click);
            // 
            // icon
            // 
            this.icon.AutoSize = true;
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.icon.Font = new System.Drawing.Font("Hack NF", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon.ForeColor = System.Drawing.Color.PeachPuff;
            this.icon.Location = new System.Drawing.Point(829, 478);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 33);
            this.icon.TabIndex = 29;
            this.icon.Text = "";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.credit.Font = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.PeachPuff;
            this.credit.Location = new System.Drawing.Point(603, 479);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(231, 30);
            this.credit.TabIndex = 28;
            this.credit.Text = "Made by Plextora#0033";
            // 
            // injectButtonFix
            // 
            this.injectButtonFix.CheckedState.Parent = this.injectButtonFix;
            this.injectButtonFix.CustomImages.Parent = this.injectButtonFix;
            this.injectButtonFix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.injectButtonFix.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectButtonFix.ForeColor = System.Drawing.Color.PeachPuff;
            this.injectButtonFix.HoveredState.Parent = this.injectButtonFix;
            this.injectButtonFix.Location = new System.Drawing.Point(596, 13);
            this.injectButtonFix.Name = "injectButtonFix";
            this.injectButtonFix.ShadowDecoration.Parent = this.injectButtonFix;
            this.injectButtonFix.Size = new System.Drawing.Size(135, 33);
            this.injectButtonFix.TabIndex = 31;
            this.injectButtonFix.Text = "Inject (fix)";
            this.injectButtonFix.Click += new System.EventHandler(this.injectButtonFix_Click);
            // 
            // injectButton
            // 
            this.injectButton.CheckedState.Parent = this.injectButton;
            this.injectButton.CustomImages.Parent = this.injectButton;
            this.injectButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.injectButton.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.injectButton.HoveredState.Parent = this.injectButton;
            this.injectButton.Location = new System.Drawing.Point(455, 13);
            this.injectButton.Name = "injectButton";
            this.injectButton.ShadowDecoration.Parent = this.injectButton;
            this.injectButton.Size = new System.Drawing.Size(135, 33);
            this.injectButton.TabIndex = 30;
            this.injectButton.Text = "Inject";
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // katGUI
            // 
            this.katGUI.CheckedState.Parent = this.katGUI;
            this.katGUI.CustomImages.Parent = this.katGUI;
            this.katGUI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.katGUI.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.katGUI.ForeColor = System.Drawing.Color.PeachPuff;
            this.katGUI.HoveredState.Parent = this.katGUI;
            this.katGUI.Location = new System.Drawing.Point(12, 112);
            this.katGUI.Name = "katGUI";
            this.katGUI.ShadowDecoration.Parent = this.katGUI;
            this.katGUI.Size = new System.Drawing.Size(88, 43);
            this.katGUI.TabIndex = 32;
            this.katGUI.Text = "KAT GUI";
            this.katGUI.Click += new System.EventHandler(this.katGUI_Click);
            // 
            // mm2GUI
            // 
            this.mm2GUI.CheckedState.Parent = this.mm2GUI;
            this.mm2GUI.CustomImages.Parent = this.mm2GUI;
            this.mm2GUI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mm2GUI.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mm2GUI.ForeColor = System.Drawing.Color.PeachPuff;
            this.mm2GUI.HoveredState.Parent = this.mm2GUI;
            this.mm2GUI.Location = new System.Drawing.Point(106, 112);
            this.mm2GUI.Name = "mm2GUI";
            this.mm2GUI.ShadowDecoration.Parent = this.mm2GUI;
            this.mm2GUI.Size = new System.Drawing.Size(101, 43);
            this.mm2GUI.TabIndex = 33;
            this.mm2GUI.Text = "MM2 GUI";
            this.mm2GUI.Click += new System.EventHandler(this.mm2GUI_Click);
            // 
            // injectCheckLabel
            // 
            this.injectCheckLabel.AutoSize = true;
            this.injectCheckLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.injectCheckLabel.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectCheckLabel.ForeColor = System.Drawing.Color.Crimson;
            this.injectCheckLabel.Location = new System.Drawing.Point(8, 485);
            this.injectCheckLabel.Name = "injectCheckLabel";
            this.injectCheckLabel.Size = new System.Drawing.Size(175, 23);
            this.injectCheckLabel.TabIndex = 34;
            this.injectCheckLabel.Text = "Neoblox isn\'t injected";
            // 
            // checkInjectedTimer
            // 
            this.checkInjectedTimer.Enabled = true;
            this.checkInjectedTimer.Interval = 500;
            this.checkInjectedTimer.Tick += new System.EventHandler(this.checkInjectedTimer_Tick);
            // 
            // ScriptHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(867, 518);
            this.Controls.Add(this.injectCheckLabel);
            this.Controls.Add(this.mm2GUI);
            this.Controls.Add(this.katGUI);
            this.Controls.Add(this.injectButtonFix);
            this.Controls.Add(this.injectButton);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.phantomForcesESP);
            this.Controls.Add(this.phantomForcesSilentAim);
            this.Controls.Add(this.qToTP);
            this.Controls.Add(this.infiniteJumpScript);
            this.Controls.Add(this.xrayScript);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.scriptHubButton);
            this.ForeColor = System.Drawing.Color.PeachPuff;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScriptHub";
            this.Text = "ScriptHub";
            this.Load += new System.EventHandler(this.ScriptHub_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScriptHub_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScriptHub_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private ns1.SiticoneButton scriptHubButton;
        private ns1.SiticoneButton minimizeButton;
        private ns1.SiticoneButton closeButton;
        private ns1.SiticoneButton xrayScript;
        private ns1.SiticoneButton infiniteJumpScript;
        private ns1.SiticoneButton qToTP;
        private ns1.SiticoneButton phantomForcesSilentAim;
        private ns1.SiticoneButton phantomForcesESP;
        private System.Windows.Forms.Label icon;
        private System.Windows.Forms.Label credit;
        private ns1.SiticoneButton injectButtonFix;
        private ns1.SiticoneButton injectButton;
        private ns1.SiticoneButton katGUI;
        private ns1.SiticoneButton mm2GUI;
        private System.Windows.Forms.Label injectCheckLabel;
        private System.Windows.Forms.Timer checkInjectedTimer;
    }
}