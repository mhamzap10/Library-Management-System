namespace Library_Management_System
{
    partial class main_form
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
            this.exit = new System.Windows.Forms.Button();
            this.main_member_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.main_admin_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.DimGray;
            this.exit.BackgroundImage = global::Library_Management_System.Properties.Resources.iconfinder_Delete_27842;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(1843, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 65);
            this.exit.TabIndex = 3;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // main_member_btn
            // 
            this.main_member_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.main_member_btn.BackColor = System.Drawing.Color.Transparent;
            this.main_member_btn.BackgroundImage = global::Library_Management_System.Properties.Resources.user_login_icon_29;
            this.main_member_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_member_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_member_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_member_btn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_member_btn.ForeColor = System.Drawing.Color.Cyan;
            this.main_member_btn.Location = new System.Drawing.Point(1312, 468);
            this.main_member_btn.Name = "main_member_btn";
            this.main_member_btn.Size = new System.Drawing.Size(558, 470);
            this.main_member_btn.TabIndex = 2;
            this.main_member_btn.Text = "LIBRARIAN LOGIN";
            this.main_member_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.main_member_btn.UseVisualStyleBackColor = false;
            this.main_member_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(1926, 772);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 257);
            this.button1.TabIndex = 4;
            this.button1.Text = "MEMBER ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // main_admin_login
            // 
            this.main_admin_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.main_admin_login.BackColor = System.Drawing.Color.Transparent;
            this.main_admin_login.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed__1_1;
            this.main_admin_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_admin_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_admin_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_admin_login.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_admin_login.ForeColor = System.Drawing.Color.Cyan;
            this.main_admin_login.Location = new System.Drawing.Point(72, 457);
            this.main_admin_login.Name = "main_admin_login";
            this.main_admin_login.Size = new System.Drawing.Size(558, 470);
            this.main_admin_login.TabIndex = 1;
            this.main_admin_login.Text = "ADMIN LOGIN";
            this.main_admin_login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.main_admin_login.UseVisualStyleBackColor = false;
            this.main_admin_login.Click += new System.EventHandler(this.main_admin_login_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(473, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1072, 97);
            this.label1.TabIndex = 8;
            this.label1.Text = "welcome to BUKC smart library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.bookcase_books_bookshelves_270571;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_admin_login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.main_member_btn);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button main_member_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button main_admin_login;
        private System.Windows.Forms.Label label1;
    }
}