namespace Library_Management_System
{
    partial class admin_dashboard
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
            this.show_books = new System.Windows.Forms.Button();
            this.delete_book = new System.Windows.Forms.Button();
            this.add_book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Show_issued_books = new System.Windows.Forms.Button();
            this.add_member = new System.Windows.Forms.Button();
            this.show_record_members = new System.Windows.Forms.Button();
            this.admin_exit = new System.Windows.Forms.Button();
            this.account_holder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // show_books
            // 
            this.show_books.BackColor = System.Drawing.Color.Transparent;
            this.show_books.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed__2_;
            this.show_books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_books.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_books.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_books.ForeColor = System.Drawing.Color.DarkBlue;
            this.show_books.Location = new System.Drawing.Point(139, 533);
            this.show_books.Name = "show_books";
            this.show_books.Size = new System.Drawing.Size(250, 250);
            this.show_books.TabIndex = 4;
            this.show_books.Text = "SHOW BOOKS";
            this.show_books.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.show_books.UseVisualStyleBackColor = false;
            this.show_books.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete_book
            // 
            this.delete_book.BackColor = System.Drawing.Color.Transparent;
            this.delete_book.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed2;
            this.delete_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_book.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_book.ForeColor = System.Drawing.Color.DarkBlue;
            this.delete_book.Location = new System.Drawing.Point(395, 277);
            this.delete_book.Name = "delete_book";
            this.delete_book.Size = new System.Drawing.Size(250, 250);
            this.delete_book.TabIndex = 2;
            this.delete_book.Text = "DELETE BOOK";
            this.delete_book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delete_book.UseVisualStyleBackColor = false;
            this.delete_book.Click += new System.EventHandler(this.delete_book_Click);
            // 
            // add_book
            // 
            this.add_book.BackColor = System.Drawing.Color.Transparent;
            this.add_book.BackgroundImage = global::Library_Management_System.Properties.Resources.Actions_address_book_new_icon;
            this.add_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_book.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_book.ForeColor = System.Drawing.Color.Blue;
            this.add_book.Location = new System.Drawing.Point(139, 277);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(250, 250);
            this.add_book.TabIndex = 1;
            this.add_book.Text = "ADD BOOK";
            this.add_book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_book.UseVisualStyleBackColor = false;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 97);
            this.label1.TabIndex = 15;
            this.label1.Text = "ADMIN DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Show_issued_books
            // 
            this.Show_issued_books.BackColor = System.Drawing.Color.Transparent;
            this.Show_issued_books.BackgroundImage = global::Library_Management_System.Properties.Resources._2585bf984d29347ef9acb44e2964c36d_books_pile_3d_icon;
            this.Show_issued_books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Show_issued_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_issued_books.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_issued_books.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_issued_books.ForeColor = System.Drawing.Color.DarkBlue;
            this.Show_issued_books.Location = new System.Drawing.Point(395, 533);
            this.Show_issued_books.Name = "Show_issued_books";
            this.Show_issued_books.Size = new System.Drawing.Size(250, 250);
            this.Show_issued_books.TabIndex = 5;
            this.Show_issued_books.Text = "SHOW ISSUED BOOK";
            this.Show_issued_books.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Show_issued_books.UseVisualStyleBackColor = false;
            this.Show_issued_books.Click += new System.EventHandler(this.button4_Click);
            // 
            // add_member
            // 
            this.add_member.BackColor = System.Drawing.Color.Transparent;
            this.add_member.BackgroundImage = global::Library_Management_System.Properties.Resources._5a93db12;
            this.add_member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_member.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_member.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_member.ForeColor = System.Drawing.Color.DarkBlue;
            this.add_member.Location = new System.Drawing.Point(651, 533);
            this.add_member.Name = "add_member";
            this.add_member.Size = new System.Drawing.Size(250, 250);
            this.add_member.TabIndex = 6;
            this.add_member.Text = "ADD MEMBER";
            this.add_member.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_member.UseVisualStyleBackColor = false;
            this.add_member.Click += new System.EventHandler(this.Edit_Credentials_Click);
            // 
            // show_record_members
            // 
            this.show_record_members.BackColor = System.Drawing.Color.Transparent;
            this.show_record_members.BackgroundImage = global::Library_Management_System.Properties.Resources.customers_512;
            this.show_record_members.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_record_members.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_record_members.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_record_members.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_record_members.ForeColor = System.Drawing.Color.DarkBlue;
            this.show_record_members.Location = new System.Drawing.Point(651, 277);
            this.show_record_members.Name = "show_record_members";
            this.show_record_members.Size = new System.Drawing.Size(250, 250);
            this.show_record_members.TabIndex = 3;
            this.show_record_members.Text = "SHOW MEMBER RECORD";
            this.show_record_members.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.show_record_members.UseVisualStyleBackColor = false;
            this.show_record_members.Click += new System.EventHandler(this.show_record_members_Click);
            // 
            // admin_exit
            // 
            this.admin_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_exit.BackColor = System.Drawing.Color.Transparent;
            this.admin_exit.BackgroundImage = global::Library_Management_System.Properties.Resources.logout_icon;
            this.admin_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_exit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_exit.ForeColor = System.Drawing.Color.Red;
            this.admin_exit.Location = new System.Drawing.Point(1737, 26);
            this.admin_exit.Name = "admin_exit";
            this.admin_exit.Size = new System.Drawing.Size(131, 152);
            this.admin_exit.TabIndex = 7;
            this.admin_exit.Text = "LOGOUT";
            this.admin_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.admin_exit.UseVisualStyleBackColor = false;
            this.admin_exit.Click += new System.EventHandler(this.admin_exit_Click);
            // 
            // account_holder
            // 
            this.account_holder.AutoSize = true;
            this.account_holder.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_holder.Location = new System.Drawing.Point(21, 26);
            this.account_holder.Name = "account_holder";
            this.account_holder.Size = new System.Drawing.Size(0, 29);
            this.account_holder.TabIndex = 16;
            // 
            // admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.dlv_plugin_for_divi___Copy1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.account_holder);
            this.Controls.Add(this.admin_exit);
            this.Controls.Add(this.add_member);
            this.Controls.Add(this.show_record_members);
            this.Controls.Add(this.Show_issued_books);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_books);
            this.Controls.Add(this.delete_book);
            this.Controls.Add(this.add_book);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button show_books;
        private System.Windows.Forms.Button delete_book;
        private System.Windows.Forms.Button add_book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Show_issued_books;
        private System.Windows.Forms.Button add_member;
        private System.Windows.Forms.Button show_record_members;
        private System.Windows.Forms.Button admin_exit;
        private System.Windows.Forms.Label account_holder;
    }
}