namespace L12_1
{
    partial class Login_Forn
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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.username_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.password_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.login_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(43, 49);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(55, 13);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            this.username_tooltip.SetToolTip(this.username_label, "Enter your username");
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(45, 102);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            this.password_tooltip.SetToolTip(this.password_label, "Enter your password");
            this.username_tooltip.SetToolTip(this.password_label, "Enter your username");
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(133, 49);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(132, 20);
            this.username_textbox.TabIndex = 1;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(133, 95);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(132, 20);
            this.password_textbox.TabIndex = 2;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(133, 164);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(131, 62);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_tooltip.SetToolTip(this.login_btn, "Click to login");
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // username_tooltip
            // 
            this.username_tooltip.Tag = "";
            this.username_tooltip.ToolTipTitle = "g";
            // 
            // Login_Forn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 324);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Name = "Login_Forn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Forn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.ToolTip username_tooltip;
        private System.Windows.Forms.ToolTip password_tooltip;
        private System.Windows.Forms.ToolTip login_tooltip;
    }
}

