namespace Library_Management_System
{
    partial class delete_book_admin
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
            this.admEditBookDBRbBoth = new System.Windows.Forms.RadioButton();
            this.admEditBookDBRbAuthor = new System.Windows.Forms.RadioButton();
            this.admEditBookDBRbTitle = new System.Windows.Forms.RadioButton();
            this.editBookDBDgvTable = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.admEditBookDBBtnClear = new System.Windows.Forms.Button();
            this.editBookDBBtnAddToDB = new System.Windows.Forms.Button();
            this.editBookDBTbxBookID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBookDBDgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::Library_Management_System.Properties.Resources.thi_business_and_education_background1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.admEditBookDBRbBoth);
            this.panel1.Controls.Add(this.admEditBookDBRbAuthor);
            this.panel1.Controls.Add(this.admEditBookDBRbTitle);
            this.panel1.Controls.Add(this.editBookDBDgvTable);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.admEditBookDBBtnClear);
            this.panel1.Controls.Add(this.editBookDBBtnAddToDB);
            this.panel1.Controls.Add(this.editBookDBTbxBookID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(71, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 665);
            this.panel1.TabIndex = 1;
            // 
            // admEditBookDBRbBoth
            // 
            this.admEditBookDBRbBoth.AutoSize = true;
            this.admEditBookDBRbBoth.BackColor = System.Drawing.Color.Transparent;
            this.admEditBookDBRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admEditBookDBRbBoth.Location = new System.Drawing.Point(469, 87);
            this.admEditBookDBRbBoth.Margin = new System.Windows.Forms.Padding(4);
            this.admEditBookDBRbBoth.Name = "admEditBookDBRbBoth";
            this.admEditBookDBRbBoth.Size = new System.Drawing.Size(73, 29);
            this.admEditBookDBRbBoth.TabIndex = 75;
            this.admEditBookDBRbBoth.TabStop = true;
            this.admEditBookDBRbBoth.Text = "Both";
            this.admEditBookDBRbBoth.UseVisualStyleBackColor = false;
            // 
            // admEditBookDBRbAuthor
            // 
            this.admEditBookDBRbAuthor.AutoSize = true;
            this.admEditBookDBRbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.admEditBookDBRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admEditBookDBRbAuthor.Location = new System.Drawing.Point(361, 87);
            this.admEditBookDBRbAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.admEditBookDBRbAuthor.Name = "admEditBookDBRbAuthor";
            this.admEditBookDBRbAuthor.Size = new System.Drawing.Size(91, 29);
            this.admEditBookDBRbAuthor.TabIndex = 74;
            this.admEditBookDBRbAuthor.TabStop = true;
            this.admEditBookDBRbAuthor.Text = "Author";
            this.admEditBookDBRbAuthor.UseVisualStyleBackColor = false;
            // 
            // admEditBookDBRbTitle
            // 
            this.admEditBookDBRbTitle.AutoSize = true;
            this.admEditBookDBRbTitle.BackColor = System.Drawing.Color.Transparent;
            this.admEditBookDBRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admEditBookDBRbTitle.Location = new System.Drawing.Point(278, 87);
            this.admEditBookDBRbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.admEditBookDBRbTitle.Name = "admEditBookDBRbTitle";
            this.admEditBookDBRbTitle.Size = new System.Drawing.Size(70, 29);
            this.admEditBookDBRbTitle.TabIndex = 73;
            this.admEditBookDBRbTitle.TabStop = true;
            this.admEditBookDBRbTitle.Text = "Title";
            this.admEditBookDBRbTitle.UseVisualStyleBackColor = false;
            // 
            // editBookDBDgvTable
            // 
            this.editBookDBDgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.editBookDBDgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.editBookDBDgvTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editBookDBDgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.editBookDBDgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editBookDBDgvTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.editBookDBDgvTable.Location = new System.Drawing.Point(72, 235);
            this.editBookDBDgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.editBookDBDgvTable.Name = "editBookDBDgvTable";
            this.editBookDBDgvTable.Size = new System.Drawing.Size(860, 394);
            this.editBookDBDgvTable.TabIndex = 71;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Azure;
            this.button4.Location = new System.Drawing.Point(319, 148);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 66);
            this.button4.TabIndex = 70;
            this.button4.Text = "DELETE BOOK";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(733, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 66);
            this.button1.TabIndex = 69;
            this.button1.Text = "Clear Boxes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(526, 148);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 66);
            this.button2.TabIndex = 68;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // editBookDBTbxBookID
            // 
            this.editBookDBTbxBookID.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookDBTbxBookID.Location = new System.Drawing.Point(278, 56);
            this.editBookDBTbxBookID.Margin = new System.Windows.Forms.Padding(4);
            this.editBookDBTbxBookID.Name = "editBookDBTbxBookID";
            this.editBookDBTbxBookID.Size = new System.Drawing.Size(654, 23);
            this.editBookDBTbxBookID.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 35);
            this.label5.TabIndex = 48;
            this.label5.Text = "SEARCH :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.label2.Size = new System.Drawing.Size(535, 97);
            this.label2.TabIndex = 75;
            this.label2.Text = "DELETE BOOKS";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Library_Management_System.Properties.Resources.iconfinder_Delete_27842;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(973, 24);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 74;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete_book_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.library_hero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 823);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_book_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_book_admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBookDBDgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admEditBookDBBtnClear;
        private System.Windows.Forms.Button editBookDBBtnAddToDB;
        private System.Windows.Forms.TextBox editBookDBTbxBookID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView editBookDBDgvTable;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton admEditBookDBRbBoth;
        private System.Windows.Forms.RadioButton admEditBookDBRbAuthor;
        private System.Windows.Forms.RadioButton admEditBookDBRbTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}