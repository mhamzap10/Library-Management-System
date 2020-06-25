namespace Library_Management_System
{
    partial class show_books_admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.show_books_GV = new System.Windows.Forms.DataGridView();
            this.RbBoth = new System.Windows.Forms.RadioButton();
            this.BRbAuthor = new System.Windows.Forms.RadioButton();
            this.RbTitle = new System.Windows.Forms.RadioButton();
            this.show_books_btn = new System.Windows.Forms.Button();
            this.clear_selection_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.book_search_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_books_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Library_Management_System.Properties.Resources.thi_business_and_education_background1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.show_books_GV);
            this.panel1.Controls.Add(this.RbBoth);
            this.panel1.Controls.Add(this.BRbAuthor);
            this.panel1.Controls.Add(this.RbTitle);
            this.panel1.Controls.Add(this.show_books_btn);
            this.panel1.Controls.Add(this.clear_selection_btn);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.book_search_txtbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 853);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Library_Management_System.Properties.Resources.iconfinder_Delete_27842;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(638, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 65);
            this.button3.TabIndex = 74;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Image = global::Library_Management_System.Properties.Resources.twitter_corner_blue1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 78);
            this.label2.TabIndex = 75;
            this.label2.Text = "BOOKS IN LIBRARY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // show_books_GV
            // 
            this.show_books_GV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_books_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.show_books_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.show_books_GV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.show_books_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.show_books_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_books_GV.Location = new System.Drawing.Point(30, 234);
            this.show_books_GV.Name = "show_books_GV";
            this.show_books_GV.Size = new System.Drawing.Size(631, 591);
            this.show_books_GV.TabIndex = 76;
            // 
            // RbBoth
            // 
            this.RbBoth.AutoSize = true;
            this.RbBoth.BackColor = System.Drawing.Color.Transparent;
            this.RbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbBoth.Location = new System.Drawing.Point(314, 134);
            this.RbBoth.Name = "RbBoth";
            this.RbBoth.Size = new System.Drawing.Size(61, 24);
            this.RbBoth.TabIndex = 75;
            this.RbBoth.TabStop = true;
            this.RbBoth.Text = "Both";
            this.RbBoth.UseVisualStyleBackColor = false;
            // 
            // BRbAuthor
            // 
            this.BRbAuthor.AutoSize = true;
            this.BRbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.BRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRbAuthor.Location = new System.Drawing.Point(232, 134);
            this.BRbAuthor.Name = "BRbAuthor";
            this.BRbAuthor.Size = new System.Drawing.Size(75, 24);
            this.BRbAuthor.TabIndex = 74;
            this.BRbAuthor.TabStop = true;
            this.BRbAuthor.Text = "Author";
            this.BRbAuthor.UseVisualStyleBackColor = false;
            // 
            // RbTitle
            // 
            this.RbTitle.AutoSize = true;
            this.RbTitle.BackColor = System.Drawing.Color.Transparent;
            this.RbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbTitle.Location = new System.Drawing.Point(170, 134);
            this.RbTitle.Name = "RbTitle";
            this.RbTitle.Size = new System.Drawing.Size(56, 24);
            this.RbTitle.TabIndex = 73;
            this.RbTitle.TabStop = true;
            this.RbTitle.Text = "Title";
            this.RbTitle.UseVisualStyleBackColor = false;
            // 
            // show_books_btn
            // 
            this.show_books_btn.BackColor = System.Drawing.Color.Teal;
            this.show_books_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_books_btn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_books_btn.ForeColor = System.Drawing.Color.Azure;
            this.show_books_btn.Location = new System.Drawing.Point(201, 174);
            this.show_books_btn.Name = "show_books_btn";
            this.show_books_btn.Size = new System.Drawing.Size(149, 54);
            this.show_books_btn.TabIndex = 70;
            this.show_books_btn.Text = "SHOW BOOKS";
            this.show_books_btn.UseVisualStyleBackColor = false;
            this.show_books_btn.Click += new System.EventHandler(this.show_books_btn_Click);
            // 
            // clear_selection_btn
            // 
            this.clear_selection_btn.BackColor = System.Drawing.Color.Teal;
            this.clear_selection_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_selection_btn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_selection_btn.ForeColor = System.Drawing.Color.Azure;
            this.clear_selection_btn.Location = new System.Drawing.Point(512, 174);
            this.clear_selection_btn.Name = "clear_selection_btn";
            this.clear_selection_btn.Size = new System.Drawing.Size(149, 54);
            this.clear_selection_btn.TabIndex = 69;
            this.clear_selection_btn.Text = "CELAR ";
            this.clear_selection_btn.UseVisualStyleBackColor = false;
            this.clear_selection_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Teal;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Azure;
            this.search_btn.Location = new System.Drawing.Point(356, 174);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(149, 54);
            this.search_btn.TabIndex = 68;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // book_search_txtbox
            // 
            this.book_search_txtbox.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_search_txtbox.Location = new System.Drawing.Point(170, 109);
            this.book_search_txtbox.Name = "book_search_txtbox";
            this.book_search_txtbox.Size = new System.Drawing.Size(492, 20);
            this.book_search_txtbox.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 27);
            this.label5.TabIndex = 48;
            this.label5.Text = "SEARCH :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // show_books_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.library_hero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 640);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "show_books_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_book_admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_books_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox book_search_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear_selection_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton RbBoth;
        private System.Windows.Forms.RadioButton BRbAuthor;
        private System.Windows.Forms.RadioButton RbTitle;
        private System.Windows.Forms.Button show_books_btn;
        private System.Windows.Forms.DataGridView show_books_GV;
    }
}