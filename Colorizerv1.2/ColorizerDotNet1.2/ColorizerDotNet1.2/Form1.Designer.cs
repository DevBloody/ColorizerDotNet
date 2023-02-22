namespace ColorizerDotNet1._2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisconnButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ConnectButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.IPBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ColorBLabel = new System.Windows.Forms.Label();
            this.ColorNLabel = new System.Windows.Forms.Label();
            this.ColorALabel = new System.Windows.Forms.Label();
            this.NeutralShowBox = new System.Windows.Forms.TextBox();
            this.BravoShowBox = new System.Windows.Forms.TextBox();
            this.AlphaShowBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisconnButton);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.IPBox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(44, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 69);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCPGecko Connection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DisconnButton
            // 
            this.DisconnButton.BorderThickness = 1;
            this.DisconnButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DisconnButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DisconnButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DisconnButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DisconnButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DisconnButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DisconnButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DisconnButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DisconnButton.ForeColor = System.Drawing.Color.White;
            this.DisconnButton.Location = new System.Drawing.Point(321, 29);
            this.DisconnButton.Name = "DisconnButton";
            this.DisconnButton.Size = new System.Drawing.Size(154, 25);
            this.DisconnButton.TabIndex = 7;
            this.DisconnButton.Text = "Disconnect";
            this.DisconnButton.Click += new System.EventHandler(this.DisconnButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BorderThickness = 1;
            this.ConnectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConnectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConnectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConnectButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConnectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConnectButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConnectButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Location = new System.Drawing.Point(143, 29);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(154, 25);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect To TCPGecko";
            this.ConnectButton.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // IPBox
            // 
            this.IPBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPBox.DefaultText = "";
            this.IPBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IPBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IPBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IPBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IPBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IPBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IPBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IPBox.Location = new System.Drawing.Point(6, 29);
            this.IPBox.Name = "IPBox";
            this.IPBox.PasswordChar = '\0';
            this.IPBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IPBox.PlaceholderText = "[Enter Wii U IP]";
            this.IPBox.SelectedText = "";
            this.IPBox.Size = new System.Drawing.Size(115, 25);
            this.IPBox.TabIndex = 6;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.guna2GradientButton6);
            this.SettingsGroupBox.Controls.Add(this.guna2GradientButton5);
            this.SettingsGroupBox.Controls.Add(this.guna2GradientButton4);
            this.SettingsGroupBox.Controls.Add(this.guna2GradientButton3);
            this.SettingsGroupBox.Controls.Add(this.ColorBLabel);
            this.SettingsGroupBox.Controls.Add(this.ColorNLabel);
            this.SettingsGroupBox.Controls.Add(this.ColorALabel);
            this.SettingsGroupBox.Controls.Add(this.NeutralShowBox);
            this.SettingsGroupBox.Controls.Add(this.BravoShowBox);
            this.SettingsGroupBox.Controls.Add(this.AlphaShowBox);
            this.SettingsGroupBox.Enabled = false;
            this.SettingsGroupBox.Location = new System.Drawing.Point(123, 87);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(349, 183);
            this.SettingsGroupBox.TabIndex = 6;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton6.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.Location = new System.Drawing.Point(131, 134);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.Size = new System.Drawing.Size(87, 31);
            this.guna2GradientButton6.TabIndex = 23;
            this.guna2GradientButton6.Text = "Get Colors";
            this.guna2GradientButton6.Click += new System.EventHandler(this.guna2GradientButton6_Click);
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton5.FillColor = System.Drawing.Color.Yellow;
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.Location = new System.Drawing.Point(244, 83);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.Size = new System.Drawing.Size(87, 31);
            this.guna2GradientButton5.TabIndex = 22;
            this.guna2GradientButton5.Text = "Set Neutral";
            this.guna2GradientButton5.Click += new System.EventHandler(this.guna2GradientButton5_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Blue;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.Location = new System.Drawing.Point(125, 83);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(93, 31);
            this.guna2GradientButton4.TabIndex = 21;
            this.guna2GradientButton4.Text = "Set Bravo";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(19, 83);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(77, 31);
            this.guna2GradientButton3.TabIndex = 7;
            this.guna2GradientButton3.Text = "Set Alpha";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // ColorBLabel
            // 
            this.ColorBLabel.AutoSize = true;
            this.ColorBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorBLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorBLabel.Location = new System.Drawing.Point(163, 32);
            this.ColorBLabel.Name = "ColorBLabel";
            this.ColorBLabel.Size = new System.Drawing.Size(39, 13);
            this.ColorBLabel.TabIndex = 12;
            this.ColorBLabel.Text = "not set";
            // 
            // ColorNLabel
            // 
            this.ColorNLabel.AutoSize = true;
            this.ColorNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorNLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorNLabel.Location = new System.Drawing.Point(270, 32);
            this.ColorNLabel.Name = "ColorNLabel";
            this.ColorNLabel.Size = new System.Drawing.Size(39, 13);
            this.ColorNLabel.TabIndex = 20;
            this.ColorNLabel.Text = "not set";
            // 
            // ColorALabel
            // 
            this.ColorALabel.AutoSize = true;
            this.ColorALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorALabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorALabel.Location = new System.Drawing.Point(57, 32);
            this.ColorALabel.Name = "ColorALabel";
            this.ColorALabel.Size = new System.Drawing.Size(39, 13);
            this.ColorALabel.TabIndex = 7;
            this.ColorALabel.Text = "not set";
            // 
            // NeutralShowBox
            // 
            this.NeutralShowBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NeutralShowBox.Enabled = false;
            this.NeutralShowBox.Location = new System.Drawing.Point(244, 28);
            this.NeutralShowBox.Name = "NeutralShowBox";
            this.NeutralShowBox.Size = new System.Drawing.Size(20, 20);
            this.NeutralShowBox.TabIndex = 7;
            this.NeutralShowBox.TextChanged += new System.EventHandler(this.NeutralShowBox_TextChanged);
            // 
            // BravoShowBox
            // 
            this.BravoShowBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BravoShowBox.Enabled = false;
            this.BravoShowBox.Location = new System.Drawing.Point(137, 28);
            this.BravoShowBox.Name = "BravoShowBox";
            this.BravoShowBox.Size = new System.Drawing.Size(20, 20);
            this.BravoShowBox.TabIndex = 6;
            this.BravoShowBox.TextChanged += new System.EventHandler(this.BravoShowBox_TextChanged);
            // 
            // AlphaShowBox
            // 
            this.AlphaShowBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AlphaShowBox.Enabled = false;
            this.AlphaShowBox.Location = new System.Drawing.Point(31, 28);
            this.AlphaShowBox.Name = "AlphaShowBox";
            this.AlphaShowBox.Size = new System.Drawing.Size(20, 20);
            this.AlphaShowBox.TabIndex = 5;
            this.AlphaShowBox.TextChanged += new System.EventHandler(this.AlphaShowBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(419, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Colorizer v1.2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(621, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Colorizer - Splatoon 2.12.0 | v1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton ConnectButton;
        private Guna.UI2.WinForms.Guna2TextBox IPBox;
        private Guna.UI2.WinForms.Guna2GradientButton DisconnButton;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private System.Windows.Forms.Label ColorBLabel;
        private System.Windows.Forms.Label ColorNLabel;
        private System.Windows.Forms.Label ColorALabel;
        private System.Windows.Forms.TextBox NeutralShowBox;
        private System.Windows.Forms.TextBox BravoShowBox;
        private System.Windows.Forms.TextBox AlphaShowBox;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

