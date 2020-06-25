using System;
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
    public partial class show_issued_book : Form
    {
        SqlConnection con = new Database().GetConnection();

        public show_issued_book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void display()
        {
            try
            {
                string Query = "select library_books.isbn_no[Book ISBN #],library_books.title [Book Title], library_books.book_publisher [Book Publishers],library_books._book_author [Book Author] from library_books inner join Issued_Books_Record on  library_books.isbn_no = Issued_Books_Record.Book_id";
                SqlDataAdapter Search = new SqlDataAdapter(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                DataSet ds = new DataSet();
                con.Open();
                Search.Fill(ds);
                con.Close();
                if (ds == null)
                    MessageBox.Show("No Such Book Exist");
                issued_books_show_btn.DataSource = ds.Tables[0];
                issued_books_show_btn.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void show_issued_book_Load(object sender, EventArgs e)
        {
            display();
        }

        private void issued_ID_search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "select library_books.isbn_no[Book ISBN #],library_books.title [Book Title], library_books.book_publisher [Book Publishers],library_books._book_author [Book Author] from library_books inner join Issued_Books_Record on  library_books.isbn_no = Issued_Books_Record.Book_id where library_books.isbn_no = " + int.Parse(issued_ID_txtbox.Text);
                SqlDataAdapter Search = new SqlDataAdapter(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                DataSet ds = new DataSet();
                con.Open();
                Search.Fill(ds);
                con.Close();
                if (ds == null)
                    MessageBox.Show("No Such Book Exist");
                issued_books_show_btn.DataSource = ds.Tables[0];
                issued_books_show_btn.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
