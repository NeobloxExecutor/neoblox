
namespace neoblox
{
    partial class neoblox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(neoblox));
            this.Panel = new System.Windows.Forms.Panel();
            this.topMostCheckbox = new System.Windows.Forms.CheckBox();
            this.killRblx = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.aceEditor = new System.Windows.Forms.WebBrowser();
            this.executeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.openScriptButton = new System.Windows.Forms.Button();
            this.saveScriptButton = new System.Windows.Forms.Button();
            this.injectButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.refreshScriptList = new System.Windows.Forms.Button();
            this.walkspeedLabel = new System.Windows.Forms.Label();
            this.walkspeedTextbox = new System.Windows.Forms.TextBox();
            this.flyLabel = new System.Windows.Forms.Label();
            this.onButtonFly = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Panel.Controls.Add(this.topMostCheckbox);
            this.Panel.Controls.Add(this.killRblx);
            this.Panel.Controls.Add(this.minimizeButton);
            this.Panel.Controls.Add(this.closeButton);
            this.Panel.Controls.Add(this.titleLabel);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1447, 49);
            this.Panel.TabIndex = 0;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // topMostCheckbox
            // 
            this.topMostCheckbox.AutoSize = true;
            this.topMostCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMostCheckbox.Location = new System.Drawing.Point(294, 12);
            this.topMostCheckbox.Name = "topMostCheckbox";
            this.topMostCheckbox.Size = new System.Drawing.Size(86, 21);
            this.topMostCheckbox.TabIndex = 13;
            this.topMostCheckbox.Text = "Top Most";
            this.topMostCheckbox.UseVisualStyleBackColor = true;
            this.topMostCheckbox.CheckedChanged += new System.EventHandler(this.topMostCheckbox_CheckedChanged);
            // 
            // killRblx
            // 
            this.killRblx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.killRblx.FlatAppearance.BorderSize = 0;
            this.killRblx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.killRblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killRblx.Location = new System.Drawing.Point(124, 7);
            this.killRblx.Name = "killRblx";
            this.killRblx.Size = new System.Drawing.Size(161, 28);
            this.killRblx.TabIndex = 12;
            this.killRblx.Text = "Kill Roblox Process";
            this.killRblx.UseVisualStyleBackColor = false;
            this.killRblx.Click += new System.EventHandler(this.killRblx_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(1338, -2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(49, 46);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(1393, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(49, 46);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Silver;
            this.titleLabel.Location = new System.Drawing.Point(4, 1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(120, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Neoblox";
            // 
            // aceEditor
            // 
            this.aceEditor.Location = new System.Drawing.Point(0, 55);
            this.aceEditor.MinimumSize = new System.Drawing.Size(20, 20);
            this.aceEditor.Name = "aceEditor";
            this.aceEditor.Size = new System.Drawing.Size(1292, 327);
            this.aceEditor.TabIndex = 1;
            // 
            // executeButton
            // 
            this.executeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.executeButton.FlatAppearance.BorderSize = 0;
            this.executeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButton.Location = new System.Drawing.Point(10, 401);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(228, 37);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = false;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(244, 401);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(295, 37);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // openScriptButton
            // 
            this.openScriptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.openScriptButton.FlatAppearance.BorderSize = 0;
            this.openScriptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openScriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openScriptButton.Location = new System.Drawing.Point(545, 401);
            this.openScriptButton.Name = "openScriptButton";
            this.openScriptButton.Size = new System.Drawing.Size(295, 37);
            this.openScriptButton.TabIndex = 4;
            this.openScriptButton.Text = "Open script";
            this.openScriptButton.UseVisualStyleBackColor = false;
            this.openScriptButton.Click += new System.EventHandler(this.openScriptButton_Click);
            // 
            // saveScriptButton
            // 
            this.saveScriptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveScriptButton.FlatAppearance.BorderSize = 0;
            this.saveScriptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveScriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveScriptButton.Location = new System.Drawing.Point(846, 401);
            this.saveScriptButton.Name = "saveScriptButton";
            this.saveScriptButton.Size = new System.Drawing.Size(295, 37);
            this.saveScriptButton.TabIndex = 5;
            this.saveScriptButton.Text = "Save script";
            this.saveScriptButton.UseVisualStyleBackColor = false;
            this.saveScriptButton.Click += new System.EventHandler(this.saveScriptButton_Click);
            // 
            // injectButton
            // 
            this.injectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.injectButton.FlatAppearance.BorderSize = 0;
            this.injectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.injectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectButton.Location = new System.Drawing.Point(1147, 401);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(295, 37);
            this.injectButton.TabIndex = 6;
            this.injectButton.Text = "Inject";
            this.injectButton.UseVisualStyleBackColor = false;
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Silver;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1293, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 320);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // refreshScriptList
            // 
            this.refreshScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.refreshScriptList.FlatAppearance.BorderSize = 0;
            this.refreshScriptList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshScriptList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshScriptList.Location = new System.Drawing.Point(10, 444);
            this.refreshScriptList.Name = "refreshScriptList";
            this.refreshScriptList.Size = new System.Drawing.Size(952, 37);
            this.refreshScriptList.TabIndex = 8;
            this.refreshScriptList.Text = "Refresh script list";
            this.refreshScriptList.UseVisualStyleBackColor = false;
            this.refreshScriptList.Click += new System.EventHandler(this.refreshScriptList_Click);
            // 
            // walkspeedLabel
            // 
            this.walkspeedLabel.AutoSize = true;
            this.walkspeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkspeedLabel.ForeColor = System.Drawing.Color.Silver;
            this.walkspeedLabel.Location = new System.Drawing.Point(968, 452);
            this.walkspeedLabel.Name = "walkspeedLabel";
            this.walkspeedLabel.Size = new System.Drawing.Size(154, 20);
            this.walkspeedLabel.TabIndex = 3;
            this.walkspeedLabel.Text = "Change walkspeed:";
            // 
            // walkspeedTextbox
            // 
            this.walkspeedTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.walkspeedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.walkspeedTextbox.ForeColor = System.Drawing.Color.Silver;
            this.walkspeedTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.walkspeedTextbox.Location = new System.Drawing.Point(1127, 453);
            this.walkspeedTextbox.Name = "walkspeedTextbox";
            this.walkspeedTextbox.Size = new System.Drawing.Size(100, 20);
            this.walkspeedTextbox.TabIndex = 9;
            this.walkspeedTextbox.TabStop = false;
            this.walkspeedTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.walkspeedTextbox_KeyDown);
            // 
            // flyLabel
            // 
            this.flyLabel.AutoSize = true;
            this.flyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flyLabel.ForeColor = System.Drawing.Color.Silver;
            this.flyLabel.Location = new System.Drawing.Point(1233, 449);
            this.flyLabel.Name = "flyLabel";
            this.flyLabel.Size = new System.Drawing.Size(35, 24);
            this.flyLabel.TabIndex = 10;
            this.flyLabel.Text = "Fly";
            // 
            // onButtonFly
            // 
            this.onButtonFly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.onButtonFly.FlatAppearance.BorderSize = 0;
            this.onButtonFly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onButtonFly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onButtonFly.Location = new System.Drawing.Point(1273, 448);
            this.onButtonFly.Name = "onButtonFly";
            this.onButtonFly.Size = new System.Drawing.Size(161, 28);
            this.onButtonFly.TabIndex = 11;
            this.onButtonFly.Text = "On (Press E to toggle)";
            this.onButtonFly.UseVisualStyleBackColor = false;
            this.onButtonFly.Click += new System.EventHandler(this.onButtonFly_Click);
            // 
            // neoblox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1446, 488);
            this.Controls.Add(this.onButtonFly);
            this.Controls.Add(this.flyLabel);
            this.Controls.Add(this.walkspeedTextbox);
            this.Controls.Add(this.walkspeedLabel);
            this.Controls.Add(this.refreshScriptList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.injectButton);
            this.Controls.Add(this.saveScriptButton);
            this.Controls.Add(this.openScriptButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.aceEditor);
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

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.WebBrowser aceEditor;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button openScriptButton;
        private System.Windows.Forms.Button saveScriptButton;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button refreshScriptList;
        private System.Windows.Forms.Label walkspeedLabel;
        private System.Windows.Forms.TextBox walkspeedTextbox;
        private System.Windows.Forms.Label flyLabel;
        private System.Windows.Forms.Button onButtonFly;
        private System.Windows.Forms.Button killRblx;
        private System.Windows.Forms.CheckBox topMostCheckbox;
    }
}

