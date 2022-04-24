
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.scriptHubButton = new ns1.SiticoneButton();
            this.minimizeButton = new ns1.SiticoneButton();
            this.closeButton = new ns1.SiticoneButton();
            this.xrayScript = new ns1.SiticoneButton();
            this.infiniteJumpScript = new ns1.SiticoneButton();
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
            // ScriptHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(867, 518);
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
    }
}