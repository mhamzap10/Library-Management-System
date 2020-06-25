namespace Library_Management_System
{
    partial class add_book_admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shelve_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TEXT_CLEAR = new System.Windows.Forms.Button();
            this.ADD_BOOKS = new System.Windows.Forms.Button();
            this.admEditBookDBBtnClear = new System.Windows.Forms.Button();
            this.editBookDBBtnAddToDB = new System.Windows.Forms.Button();
            this.title_txtbox = new System.Windows.Forms.TextBox();
            this.author_txtbox = new System.Windows.Forms.TextBox();
            this.publisher_txtbox = new System.Windows.Forms.TextBox();
            this.isbn_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CLOSE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::Library_Management_System.Properties.Resources.thi_business_and_education_background1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.shelve_combo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TEXT_CLEAR);
            this.panel1.Controls.Add(this.ADD_BOOKS);
            this.panel1.Controls.Add(this.admEditBookDBBtnClear);
            this.panel1.Controls.Add(this.editBookDBBtnAddToDB);
            this.panel1.Controls.Add(this.title_txtbox);
            this.panel1.Controls.Add(this.author_txtbox);
            this.panel1.Controls.Add(this.publisher_txtbox);
            this.panel1.Controls.Add(this.isbn_txtbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 428);
            this.panel1.TabIndex = 1;
            // 
            // shelve_combo
            // 
            this.shelve_combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shelve_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shelve_combo.FormattingEnabled = true;
            this.shelve_combo.Items.AddRange(new object[] {
            "SHELVE # 1 => BSE",
            "SHELVE # 2 => BCE",
            "SHELVE # 3 => BEE",
            "SHELVE # 4 => BBA",
            "SHELVE # 5 => BSCS",
            "SHELVE # 6 => BSIT",
            "SHELVE # 7 => BSPP",
            "SHELVE # 8 => BS GEO"});
            this.shelve_combo.Location = new System.Drawing.Point(278, 230);
            this.shelve_combo.MaxDropDownItems = 3;
            this.shelve_combo.Name = "shelve_combo";
            this.shelve_combo.Size = new System.Drawing.Size(654, 24);
            this.shelve_combo.Sorted = true;
            this.shelve_combo.TabIndex = 5;
            this.shelve_combo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 35);
            this.label4.TabIndex = 70;
            this.label4.Text = "SHELVE #:";
            // 
            // TEXT_CLEAR
            // 
            this.TEXT_CLEAR.BackColor = System.Drawing.Color.Teal;
            this.TEXT_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TEXT_CLEAR.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_CLEAR.ForeColor = System.Drawing.Color.Azure;
            this.TEXT_CLEAR.Location = new System.Drawing.Point(680, 317);
            this.TEXT_CLEAR.Margin = new System.Windows.Forms.Padding(4);
            this.TEXT_CLEAR.Name = "TEXT_CLEAR";
            this.TEXT_CLEAR.Size = new System.Drawing.Size(199, 66);
            this.TEXT_CLEAR.TabIndex = 69;
            this.TEXT_CLEAR.Text = "Clear Boxes";
            this.TEXT_CLEAR.UseVisualStyleBackColor = false;
            this.TEXT_CLEAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADD_BOOKS
            // 
            this.ADD_BOOKS.BackColor = System.Drawing.Color.Teal;
            this.ADD_BOOKS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADD_BOOKS.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_BOOKS.ForeColor = System.Drawing.Color.Azure;
            this.ADD_BOOKS.Location = new System.Drawing.Point(355, 317);
            this.ADD_BOOKS.Margin = new System.Windows.Forms.Padding(4);
            this.ADD_BOOKS.Name = "ADD_BOOKS";
            this.ADD_BOOKS.Size = new System.Drawing.Size(199, 66);
            this.ADD_BOOKS.TabIndex = 68;
            this.ADD_BOOKS.Text = "Add to DB";
            this.ADD_BOOKS.UseVisualStyleBackColor = false;
            this.ADD_BOOKS.Click += new System.EventHandler(this.button2_Click);
            // 
            // admEditBookDBBtnClear
            // 
            this.admEditBookDBBtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admEditBookDBBtnClear.Location = new System.Drawing.Point(677, 823);
            this.admEditBookDBBtnClear.Margin = new System.Windows.Forms.Padding(4);
            this.admEditBookDBBtnClear.Name = "admEditBookDBBtnClear";
            this.admEditBookDBBtnClear.Size = new System.Drawing.Size(175, 48);
            this.admEditBookDBBtnClear.TabIndex = 67;
            this.admEditBookDBBtnClear.Text = "Clear Boxes";
            this.admEditBookDBBtnClear.UseVisualStyleBackColor = true;
            // 
            // editBookDBBtnAddToDB
            // 
            this.editBookDBBtnAddToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookDBBtnAddToDB.Location = new System.Drawing.Point(352, 805);
            this.editBookDBBtnAddToDB.Margin = new System.Windows.Forms.Padding(4);
            this.editBookDBBtnAddToDB.Name = "editBookDBBtnAddToDB";
            this.editBookDBBtnAddToDB.Size = new System.Drawing.Size(199, 66);
            this.editBookDBBtnAddToDB.TabIndex = 56;
            this.editBookDBBtnAddToDB.Text = "Add to DB";
            this.editBookDBBtnAddToDB.UseVisualStyleBackColor = true;
            // 
            // title_txtbox
            // 
            this.title_txtbox.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txtbox.Location = new System.Drawing.Point(278, 98);
            this.title_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.title_txtbox.Name = "title_txtbox";
            this.title_txtbox.Size = new System.Drawing.Size(654, 23);
            this.title_txtbox.TabIndex = 51;
            // 
            // author_txtbox
            // 
            this.author_txtbox.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_txtbox.Location = new System.Drawing.Point(278, 188);
            this.author_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.author_txtbox.Name = "author_txtbox";
            this.author_txtbox.Size = new System.Drawing.Size(654, 23);
            this.author_txtbox.TabIndex = 54;
            // 
            // publisher_txtbox
            // 
            this.publisher_txtbox.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher_txtbox.Location = new System.Drawing.Point(278, 144);
            this.publisher_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.publisher_txtbox.Name = "publisher_txtbox";
            this.publisher_txtbox.Size = new System.Drawing.Size(654, 23);
            this.publisher_txtbox.TabIndex = 52;
            // 
            // isbn_txtbox
            // 
            this.isbn_txtbox.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn_txtbox.Location = new System.Drawing.Point(278, 56);
            this.isbn_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.isbn_txtbox.Name = "isbn_txtbox";
            this.isbn_txtbox.Size = new System.Drawing.Size(654, 23);
            this.isbn_txtbox.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 35);
            this.label6.TabIndex = 49;
            this.label6.Text = "Publisher :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 35);
            this.label5.TabIndex = 48;
            this.label5.Text = "ISBN # :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 35);
            this.label3.TabIndex = 46;
            this.label3.Text = "Author :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 35);
            this.label1.TabIndex = 44;
            this.label1.Text = "Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Image = global::Library_Management_System.Properties.Resources.twitter_corner_blue1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(65, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 97);
            this.label2.TabIndex = 75;
            this.label2.Text = "ADD BOOKS";
            // 
            // CLOSE
            // 
            this.CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.CLOSE.BackgroundImage = global::Library_Management_System.Properties.Resources.iconfinder_Delete_27842;
            this.CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOSE.Location = new System.Drawing.Point(973, 24);
            this.CLOSE.Margin = new System.Windows.Forms.Padding(4);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(80, 80);
            this.CLOSE.TabIndex = 74;
            this.CLOSE.UseVisualStyleBackColor = false;
            this.CLOSE.Click += new System.EventHandler(this.button3_Click);
            // 
            // add_book_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.library_hero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_book_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_book_admin";
            this.Load += new System.EventHandler(this.add_book_admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admEditBookDBBtnClear;
        private System.Windows.Forms.Button editBookDBBtnAddToDB;
        private System.Windows.Forms.TextBox title_txtbox;
        private System.Windows.Forms.TextBox author_txtbox;
        private System.Windows.Forms.TextBox publisher_txtbox;
        private System.Windows.Forms.TextBox isbn_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TEXT_CLEAR;
        private System.Windows.Forms.Button ADD_BOOKS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox shelve_combo;
    }
}