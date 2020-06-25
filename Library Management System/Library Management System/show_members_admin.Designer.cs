namespace Library_Management_System
{
    partial class show_members_admin
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
            this.member_show_GV = new System.Windows.Forms.DataGridView();
            this.show_members_btn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.search_member_btn = new System.Windows.Forms.Button();
            this.search_member_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_show_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = global::Library_Management_System.Properties.Resources.thi_business_and_education_background1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.member_show_GV);
            this.panel1.Controls.Add(this.show_members_btn);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.search_member_btn);
            this.panel1.Controls.Add(this.search_member_txtbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(62, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 731);
            this.panel1.TabIndex = 1;
            // 
            // member_show_GV
            // 
            this.member_show_GV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.member_show_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.member_show_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.member_show_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.member_show_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.member_show_GV.Location = new System.Drawing.Point(38, 197);
            this.member_show_GV.Name = "member_show_GV";
            this.member_show_GV.Size = new System.Drawing.Size(1239, 484);
            this.member_show_GV.TabIndex = 5;
            // 
            // show_members_btn
            // 
            this.show_members_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.show_members_btn.BackColor = System.Drawing.Color.Teal;
            this.show_members_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_members_btn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_members_btn.ForeColor = System.Drawing.Color.Azure;
            this.show_members_btn.Location = new System.Drawing.Point(180, 120);
            this.show_members_btn.Name = "show_members_btn";
            this.show_members_btn.Size = new System.Drawing.Size(175, 54);
            this.show_members_btn.TabIndex = 2;
            this.show_members_btn.Text = "SHOW MEMBERS";
            this.show_members_btn.UseVisualStyleBackColor = false;
            this.show_members_btn.Click += new System.EventHandler(this.show_members_btn_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clear.BackColor = System.Drawing.Color.Teal;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Azure;
            this.clear.Location = new System.Drawing.Point(550, 120);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(149, 54);
            this.clear.TabIndex = 4;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_member_btn
            // 
            this.search_member_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.search_member_btn.BackColor = System.Drawing.Color.Teal;
            this.search_member_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_member_btn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_member_btn.ForeColor = System.Drawing.Color.Azure;
            this.search_member_btn.Location = new System.Drawing.Point(361, 120);
            this.search_member_btn.Name = "search_member_btn";
            this.search_member_btn.Size = new System.Drawing.Size(183, 54);
            this.search_member_btn.TabIndex = 3;
            this.search_member_btn.Text = "SEARCH MEMBER";
            this.search_member_btn.UseVisualStyleBackColor = false;
            this.search_member_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // search_member_txtbox
            // 
            this.search_member_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.search_member_txtbox.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_member_txtbox.Location = new System.Drawing.Point(380, 46);
            this.search_member_txtbox.Name = "search_member_txtbox";
            this.search_member_txtbox.Size = new System.Drawing.Size(320, 20);
            this.search_member_txtbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 27);
            this.label5.TabIndex = 48;
            this.label5.Text = "SEARCH ( MEMBER-SHIP ID #):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Image = global::Library_Management_System.Properties.Resources.twitter_corner_blue1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(49, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(751, 78);
            this.label2.TabIndex = 75;
            this.label2.Text = "SMART LIBRARY MEMBERS";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::Library_Management_System.Properties.Resources.iconfinder_Delete_27842;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1314, 20);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(60, 65);
            this.close.TabIndex = 6;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button3_Click);
            // 
            // show_members_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.library_hero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "show_members_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_book_admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_show_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox search_member_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button search_member_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button show_members_btn;
        private System.Windows.Forms.DataGridView member_show_GV;
    }
}