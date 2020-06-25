﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class add_book_admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\EDUCATION\BAHRIA UNIVERSITY\Semester 4\LABS\DBMS\PROJECTS\LMS\Library Management System\database\library_management_system.mdf;Integrated Security = True; Connect Timeout = 30");
        int book_id = 0;
        string title;
        string publisher;
        string author;
        int shelve = 0;

        public void combo_selection()
        {
            if(shelve_combo.SelectedIndex == 0)
            {
                shelve = 1;
            }
            else if (shelve_combo.SelectedIndex == 1)
            {
                shelve = 2;
            }
            else if(shelve_combo.SelectedIndex == 2)
            {
                shelve = 3;
            }
            else if(shelve_combo.SelectedIndex == 3)
            {
                shelve = 4;
            }
            else if(shelve_combo.SelectedIndex == 4)
            {
                shelve = 5;
            }
            else if(shelve_combo.SelectedIndex == 5)
            {
                shelve = 6;
            }
            else if(shelve_combo.SelectedIndex == 6)
            {
                shelve = 7;
            }
            else if(shelve_combo.SelectedIndex == 7)
            {
                shelve = 8;
            }
        }
        public void clearFields()
        {
            isbn_txtbox.Text = string.Empty;
            title_txtbox.Text = string.Empty;
            publisher_txtbox.Text = string.Empty;
            author_txtbox.Text = string.Empty;
            shelve_combo.Text = string.Empty;
        }
        public add_book_admin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool preliminaryAcceptedState = true;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (con.State == ConnectionState.Closed)
            { 
            con.Open();
            }
            try
            {
                book_id = Convert.ToInt32(isbn_txtbox.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the isbn # is an interger.");
                preliminaryAcceptedState = false;
            }
            try
            {
                combo_selection();
            }
            catch
            {
                MessageBox.Show("Please make sure that the shelve # is an interger.");
                preliminaryAcceptedState = false;
            }
            title = title_txtbox.Text;
            author = author_txtbox.Text;
            publisher = publisher_txtbox.Text;
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd.CommandText="insert into library_books(isbn_no, title, book_publisher, _book_author, Shelve_ID) values ('"+ book_id + "', '" + title + "','" + publisher + "', '" + author + "','" + shelve + "')";
                    int result = cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully added.");
                        clearFields();
                    }
                }
                catch
                {
                    MessageBox.Show("The Book is already exists in youir library with following ISBN # ( "+ Convert.ToString(book_id)+" ).");
                }
            }
}
        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_book_admin_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
