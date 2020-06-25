namespace Library_Management_System
{
    partial class issue_book_librarian
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
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.IssueRbBoth = new System.Windows.Forms.RadioButton();
            this.IssueRbAuthor = new System.Windows.Forms.RadioButton();
            this.IssueRbTitle = new System.Windows.Forms.RadioButton();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.show_non_issued_books_GV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.issue_btn = new System.Windows.Forms.Button();
            this.user_ID_txtbox = new System.Windows.Forms.TextBox();
            this.book_ID_txtbox = new System.Windows.Forms.TextBox();
            this.admIssueLblUserID = new System.Windows.Forms.Label();
            this.admIssueLblBookID = new System.Windows.Forms.Label();
            this.CLOSE_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_non_issued_books_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Library_Management_System.Properties.Resources.thi_business_and_education_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.search_txtbox);
            this.panel1.Controls.Add(this.IssueRbBoth);
            this.panel1.Controls.Add(this.IssueRbAuthor);
            this.panel1.Controls.Add(this.IssueRbTitle);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.show_non_issued_books_GV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.issue_btn);
            this.panel1.Controls.Add(this.user_ID_txtbox);
            this.panel1.Controls.Add(this.book_ID_txtbox);
            this.panel1.Controls.Add(this.admIssueLblUserID);
            this.panel1.Controls.Add(this.admIssueLblBookID);
            this.panel1.Location = new System.Drawing.Point(75, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 630);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "( Only books that are not issued )";
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.BackColor = System.Drawing.Color.Teal;
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(552, 204);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(88, 33);
            this.search_btn.TabIndex = 8;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_txtbox
            // 
            this.search_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txtbox.Location = new System.Drawing.Point(199, 175);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(441, 23);
            this.search_txtbox.TabIndex = 4;
            // 
            // IssueRbBoth
            // 
            this.IssueRbBoth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssueRbBoth.AutoSize = true;
            this.IssueRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueRbBoth.Location = new System.Drawing.Point(342, 204);
            this.IssueRbBoth.Name = "IssueRbBoth";
            this.IssueRbBoth.Size = new System.Drawing.Size(61, 24);
            this.IssueRbBoth.TabIndex = 7;
            this.IssueRbBoth.TabStop = true;
            this.IssueRbBoth.Text = "Both";
            this.IssueRbBoth.UseVisualStyleBackColor = true;
            // 
            // IssueRbAuthor
            // 
            this.IssueRbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssueRbAuthor.AutoSize = true;
            this.IssueRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueRbAuthor.Location = new System.Drawing.Point(261, 204);
            this.IssueRbAuthor.Name = "IssueRbAuthor";
            this.IssueRbAuthor.Size = new System.Drawing.Size(75, 24);
            this.IssueRbAuthor.TabIndex = 6;
            this.IssueRbAuthor.TabStop = true;
            this.IssueRbAuthor.Text = "Author";
            this.IssueRbAuthor.UseVisualStyleBackColor = true;
            // 
            // IssueRbTitle
            // 
            this.IssueRbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssueRbTitle.AutoSize = true;
            this.IssueRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueRbTitle.Location = new System.Drawing.Point(199, 204);
            this.IssueRbTitle.Name = "IssueRbTitle";
            this.IssueRbTitle.Size = new System.Drawing.Size(56, 24);
            this.IssueRbTitle.TabIndex = 5;
            this.IssueRbTitle.TabStop = true;
            this.IssueRbTitle.Text = "Title";
            this.IssueRbTitle.UseVisualStyleBackColor = true;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(129, 178);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(64, 20);
            this.admBookSearchLblSearch.TabIndex = 59;
            this.admBookSearchLblSearch.Text = "Search:";
            // 
            // show_non_issued_books_GV
            // 
            this.show_non_issued_books_GV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_non_issued_books_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.show_non_issued_books_GV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_non_issued_books_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_non_issued_books_GV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_non_issued_books_GV.Location = new System.Drawing.Point(25, 281);
            this.show_non_issued_books_GV.Name = "show_non_issued_books_GV";
            this.show_non_issued_books_GV.Size = new System.Drawing.Size(769, 326);
            this.show_non_issued_books_GV.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(25, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(769, 2);
            this.label7.TabIndex = 57;
            // 
            // issue_btn
            // 
            this.issue_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issue_btn.BackColor = System.Drawing.Color.Teal;
            this.issue_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issue_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.issue_btn.Location = new System.Drawing.Point(341, 102);
            this.issue_btn.Name = "issue_btn";
            this.issue_btn.Size = new System.Drawing.Size(96, 33);
            this.issue_btn.TabIndex = 3;
            this.issue_btn.Text = "Issue";
            this.issue_btn.UseVisualStyleBackColor = false;
            this.issue_btn.Click += new System.EventHandler(this.issue_btn_Click);
            // 
            // user_ID_txtbox
            // 
            this.user_ID_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_ID_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.user_ID_txtbox.Location = new System.Drawing.Point(374, 65);
            this.user_ID_txtbox.Name = "user_ID_txtbox";
            this.user_ID_txtbox.Size = new System.Drawing.Size(151, 31);
            this.user_ID_txtbox.TabIndex = 2;
            // 
            // book_ID_txtbox
            // 
            this.book_ID_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.book_ID_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.book_ID_txtbox.Location = new System.Drawing.Point(374, 19);
            this.book_ID_txtbox.Name = "book_ID_txtbox";
            this.book_ID_txtbox.Size = new System.Drawing.Size(151, 31);
            this.book_ID_txtbox.TabIndex = 1;
            // 
            // admIssueLblUserID
            // 
            this.admIssueLblUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admIssueLblUserID.AutoSize = true;
            this.admIssueLblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueLblUserID.Location = new System.Drawing.Point(267, 68);
            this.admIssueLblUserID.Name = "admIssueLblUserID";
            this.admIssueLblUserID.Size = new System.Drawing.Size(95, 25);
            this.admIssueLblUserID.TabIndex = 16;
            this.admIssueLblUserID.Text = "User ID: ";
            // 
            // admIssueLblBookID
            // 
            this.admIssueLblBookID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admIssueLblBookID.AutoSize = true;
            this.admIssueLblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueLblBookID.Location = new System.Drawing.Point(263, 22);
            this.admIssueLblBookID.Name = "admIssueLblBookID";
            this.admIssueLblBookID.Size = new System.Drawing.Size(99, 25);
            this.admIssueLblBookID.TabIndex = 15;
            this.admIssueLblBookID.Text = "Book ID: ";
            // 
            // CLOSE_BTN
            // 
            this.CLOSE_BTN.BackColor = System.Drawing.Color.Transparent;
            this.CLOSE_BTN.BackgroundImage = global::Library_Management_System.Properties.Resources.iconfinder_Delete_27842;
            this.CLOSE_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CLOSE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CLOSE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOSE_BTN.Location = new System.Drawing.Point(885, 11);
            this.CLOSE_BTN.Name = "CLOSE_BTN";
            this.CLOSE_BTN.Size = new System.Drawing.Size(60, 65);
            this.CLOSE_BTN.TabIndex = 67;
            this.CLOSE_BTN.UseVisualStyleBackColor = false;
            this.CLOSE_BTN.Click += new System.EventHandler(this.admIssueBooksBtnBack_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Image = global::Library_Management_System.Properties.Resources.twitter_corner_blue1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(70, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 78);
            this.label2.TabIndex = 68;
            this.label2.Text = "SMART LIBRARY";
            // 
            // issue_book_librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.bobst_LL1_09B_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 640);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLOSE_BTN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "issue_book_librarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "issue_book_librarian";
            this.Load += new System.EventHandler(this.issue_book_librarian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_non_issued_books_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CLOSE_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.RadioButton IssueRbBoth;
        private System.Windows.Forms.RadioButton IssueRbAuthor;
        private System.Windows.Forms.RadioButton IssueRbTitle;
        private System.Windows.Forms.Label admBookSearchLblSearch;
        private System.Windows.Forms.DataGridView show_non_issued_books_GV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button issue_btn;
        private System.Windows.Forms.TextBox user_ID_txtbox;
        private System.Windows.Forms.TextBox book_ID_txtbox;
        private System.Windows.Forms.Label admIssueLblUserID;
        private System.Windows.Forms.Label admIssueLblBookID;
        private System.Windows.Forms.Label label2;
    }
}