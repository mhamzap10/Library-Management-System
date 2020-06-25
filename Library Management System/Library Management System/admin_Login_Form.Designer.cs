namespace Library_Management_System
{
    partial class admin_Login_Form
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
            this.admin_username = new System.Windows.Forms.TextBox();
            this.credential_panel = new System.Windows.Forms.Panel();
            this.admin_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_exit = new System.Windows.Forms.Button();
            this.admin_back = new System.Windows.Forms.Button();
            this.admin_login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.credential_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_username
            // 
            this.admin_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_username.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.admin_username.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_username.Location = new System.Drawing.Point(40, 43);
            this.admin_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_username.Name = "admin_username";
            this.admin_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.admin_username.Size = new System.Drawing.Size(402, 40);
            this.admin_username.TabIndex = 1;
            this.admin_username.Tag = "";
            this.admin_username.Text = "USERNAME";
            this.admin_username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // credential_panel
            // 
            this.credential_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.credential_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.credential_panel.BackColor = System.Drawing.Color.Transparent;
            this.credential_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.credential_panel.Controls.Add(this.admin_password);
            this.credential_panel.Controls.Add(this.admin_username);
            this.credential_panel.Location = new System.Drawing.Point(352, 134);
            this.credential_panel.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.credential_panel.Name = "credential_panel";
            this.credential_panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.credential_panel.Size = new System.Drawing.Size(476, 181);
            this.credential_panel.TabIndex = 1;
            // 
            // admin_password
            // 
            this.admin_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.admin_password.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_password.Location = new System.Drawing.Point(40, 92);
            this.admin_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_password.Name = "admin_password";
            this.admin_password.PasswordChar = '*';
            this.admin_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.admin_password.Size = new System.Drawing.Size(402, 40);
            this.admin_password.TabIndex = 2;
            this.admin_password.TabStop = false;
            this.admin_password.Text = "PASSWORD";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed__1_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(75, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(252, 180);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // admin_exit
            // 
            this.admin_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_exit.BackColor = System.Drawing.Color.Transparent;
            this.admin_exit.BackgroundImage = global::Library_Management_System.Properties.Resources.iconfinder_Delete_27842;
            this.admin_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_exit.ForeColor = System.Drawing.Color.Transparent;
            this.admin_exit.Location = new System.Drawing.Point(857, 10);
            this.admin_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_exit.Name = "admin_exit";
            this.admin_exit.Size = new System.Drawing.Size(49, 53);
            this.admin_exit.TabIndex = 5;
            this.admin_exit.UseVisualStyleBackColor = false;
            this.admin_exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // admin_back
            // 
            this.admin_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_back.BackColor = System.Drawing.Color.Transparent;
            this.admin_back.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed;
            this.admin_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_back.Location = new System.Drawing.Point(804, 10);
            this.admin_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_back.Name = "admin_back";
            this.admin_back.Size = new System.Drawing.Size(49, 53);
            this.admin_back.TabIndex = 6;
            this.admin_back.UseVisualStyleBackColor = false;
            this.admin_back.Click += new System.EventHandler(this.back_Click);
            // 
            // admin_login_btn
            // 
            this.admin_login_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_login_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_login_btn.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed__3_;
            this.admin_login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_login_btn.Location = new System.Drawing.Point(704, 342);
            this.admin_login_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_login_btn.Name = "admin_login_btn";
            this.admin_login_btn.Size = new System.Drawing.Size(110, 119);
            this.admin_login_btn.TabIndex = 3;
            this.admin_login_btn.UseVisualStyleBackColor = false;
            this.admin_login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 78);
            this.label1.TabIndex = 8;
            this.label1.Text = "ADMIN LOGIN FORM";
            // 
            // admin_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.Benefits_in_Integrating_Study_material_repository_and_Library_Management_System_in_school_management_Software_1_1024x673;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 449);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_login_btn);
            this.Controls.Add(this.admin_back);
            this.Controls.Add(this.admin_exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.credential_panel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "admin_Login_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.credential_panel.ResumeLayout(false);
            this.credential_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox admin_username;
        private System.Windows.Forms.Panel credential_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox admin_password;
        private System.Windows.Forms.Button admin_exit;
        private System.Windows.Forms.Button admin_back;
        private System.Windows.Forms.Button admin_login_btn;
        private System.Windows.Forms.Label label1;
    }
}

